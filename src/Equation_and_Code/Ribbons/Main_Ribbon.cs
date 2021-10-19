﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Equation_and_Code.Form_About;





namespace Equation_and_Code.Ribbon {
    public partial class Main_Ribbon {
        public Form_About.Form_About AboutWindow { get; private set; }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e) {

        }





        /// <summary>
        /// 插入公式编排所需的域代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InsertFieldCode_Click(object sender, RibbonControlEventArgs e) {
            // 创建一个 Word Doc 变量
            Word.Application app = Globals.ThisAddIn.Application;
            Word.Document doc = app.ActiveDocument;

            // 插入域代码
            {
                // { SEQ chapter \h }
                Field chapterNumber = app.Selection.Range.Fields.Add(
                    app.Selection.Range,
                    Word.WdFieldType.wdFieldSequence,
                    @"chapter \h",
                    false
                );
                // { SEQ equation \r \h }
                Field equationNumber = app.Selection.Range.Fields.Add(
                    app.Selection.Range,
                    Word.WdFieldType.wdFieldSequence,
                    @"equation \r \h",
                    false
                );
            }
        }





        /// <summary>
        /// 插入带有编号的公式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InsertEquation_Click(object sender, RibbonControlEventArgs e) {
            // 创建一个 Word Doc 变量
            Word.Application app = Globals.ThisAddIn.Application;
            Word.Document doc = app.ActiveDocument;

            // 在光标处插入一个名为 equationTable 的表格
            Word.Table equationTable = app.Selection.Tables.Add(app.Selection.Range, 1, 3);
            Range rng = equationTable.Range;

            // 设置 equationTable 每个单元格的具体宽度
            equationTable.Cell(1, 1).SetWidth(
                app.CentimetersToPoints(1.75f),
                Word.WdRulerStyle.wdAdjustNone
            );
            equationTable.Cell(1, 2).SetWidth(
                app.CentimetersToPoints(13.5f),
                Word.WdRulerStyle.wdAdjustNone
            );
            equationTable.Cell(1, 3).SetWidth(
                app.CentimetersToPoints(1.75f),
                Word.WdRulerStyle.wdAdjustNone
            );

            // 设置 equationTable 的整体边界距离为 0
            equationTable.LeftPadding = 0;
            equationTable.RightPadding = 0;

            // 居中、居右
            equationTable.Cell(1, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            equationTable.Cell(1, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            equationTable.Cell(1, 3).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            equationTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            equationTable.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            // 设置段前、后的距离
            rng.ParagraphFormat.LineUnitBefore = 0;
            rng.ParagraphFormat.LineUnitAfter = 0;
            rng.ParagraphFormat.SpaceBefore = 0;
            rng.ParagraphFormat.SpaceAfter = 0;
            rng.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceAtLeast;
            rng.ParagraphFormat.LineSpacing = 12;

            // 设置字体
            equationTable.Cell(1, 1).Range.Font.NameAscii = "LM Mono 10";
            equationTable.Cell(1, 2).Range.Font.NameAscii = "Latin Modern Math";
            equationTable.Cell(1, 3).Range.Font.NameAscii = "LM Mono 10";

            // 插入公式
            app.Selection.MoveRight(Word.WdUnits.wdCell, 1);
            app.Selection.OMaths.Add(app.Selection.Range);

            // 插入域代码
            app.Selection.MoveRight(Word.WdUnits.wdCell, 1);
            {
                // Type '('
                app.Selection.TypeText("(");

                // { SEQ Chapter \c } 
                Field chapterNumber = app.Selection.Range.Fields.Add(
                    app.Selection.Range,
                    Word.WdFieldType.wdFieldSequence,
                    @"chapter \c",
                    false
                );

                // Type '-'
                app.Selection.TypeText("-");

                // { SEQ Equation }
                Field equationNumber = app.Selection.Range.Fields.Add(
                    app.Selection.Range,
                    Word.WdFieldType.wdFieldSequence,
                    @"equation",
                    false
                );

                // Type ')'
                app.Selection.TypeText(")");
            }
        }




        /// <summary>
        /// 获取中英文混杂的字符串的实际占位宽度
        /// (1) ASCII 字符占 1 个半角
        /// (2) 其他字符占 2 个半角
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static int GetStrLength(string str) {

            // 如果空字符串，直接返回长度为 0
            if (string.IsNullOrEmpty(str)) {
                return 0;
            }

            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            byte[] s = ascii.GetBytes(str);
            for (int i = 0; i < s.Length; i++) {
                if ((int)s[i] == 63) {
                    tempLen += 2;
                } else {
                    tempLen += 1;
                }
            }
            return tempLen;
        }



        /// <summary>
        /// 将剪贴板中的内容放入表格，自动生成行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InsertCodeBox_Click(object sender, RibbonControlEventArgs e) {

            // 创建一个 Word Doc 变量
            Word.Application app = Globals.ThisAddIn.Application;
            Word.Document doc = app.ActiveDocument;

            // 在光标处插入一个名为 CodeTable 的表格
            Word.Table codeTable = app.Selection.Tables.Add(app.Selection.Range, 1, 2);

            // 打开代码单元格的表格边界
            codeTable.Cell(1, 2).Borders.Enable = 1;

            // 设置单元格宽度
            codeTable.Cell(1, 1).SetWidth(app.CentimetersToPoints(0.75f), Word.WdRulerStyle.wdAdjustNone);
            codeTable.Cell(1, 2).SetWidth(app.CentimetersToPoints(16.25f), Word.WdRulerStyle.wdAdjustNone);

            // 整体边界填充
            codeTable.LeftPadding = app.CentimetersToPoints(0.1f);
            codeTable.RightPadding = app.CentimetersToPoints(0.1f);

            // 设置段前、后的距离
            codeTable.Range.ParagraphFormat.LineUnitBefore = 0;
            codeTable.Range.ParagraphFormat.LineUnitAfter = 0;
            codeTable.Range.ParagraphFormat.SpaceBefore = 0;
            codeTable.Range.ParagraphFormat.SpaceAfter = 0;

            // 设置行距
            codeTable.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceExactly;
            codeTable.Range.ParagraphFormat.LineSpacing = 12;

            // 设置字体
            codeTable.Range.Font.NameAscii = dropDown_CodeFont_ASCII.SelectedItem.ToString();
            codeTable.Range.Font.NameFarEast = dropDown_CodeFont_FarEast.SelectedItem.ToString();
            codeTable.Range.Font.Size = 9;

            // 设置单元格对齐方式
            codeTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            codeTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            // 中英文字符间距自动调整：Disable
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndAlpha = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndDigit = 0;

            // 计算行号
            string tmp_clipboard = Clipboard.GetText();
            string[] AllLines = tmp_clipboard.Split('\n');
            int numberOfLines = AllLines.Length;

            // 打印连续的行号，最大步长 maxStep 从下拉菜单中选择，默认为 1
            int maxStep = Int32.Parse(dropDown_lineStep.SelectedItem.ToString());
            // int maxCharsOfEachLine = 97; // LM Mono 10, 9pt, 16.5cm
            int maxCharsOfEachLine = 102;   // Iosevka, 9pt, 16.5cm
            {
                // 某逻辑行对应的 word 物理行数
                string totalLines = "";

                // 某逻辑行在该 maxStep 下需要的换行数
                int numOfLineBreaks;
                
                // 
                for (int i = 1; i <= numberOfLines - 1; i++) {

                    // 单行字符数多于 maxCharsOfEachLine 时，多出的字符数量
                    int remainder = GetStrLength(AllLines[i - 1]) % maxCharsOfEachLine;

                    // 根据 remainder 判断该行是否存在溢出的字符
                    int isRemainderExist;
                    if (remainder == 0) {
                        isRemainderExist = 0;
                    }
                    else {
                        isRemainderExist = 1;
                    }

                    // 计算出该逻辑行在该 maxStep 下需要的换行数
                    numOfLineBreaks = GetStrLength(AllLines[i - 1]) / maxCharsOfEachLine + isRemainderExist;

                    // 判断：如果当前逻辑行的行号不能被 maxStep 整除，则不打印该行的逻辑行号
                    if (i % maxStep == 0) {
                        totalLines = totalLines + i.ToString();
                    }
                    
                    for (int j = 0; j < numOfLineBreaks; j++) {
                        totalLines = totalLines + "\n";
                    }
                }
                totalLines = totalLines + numberOfLines.ToString();

                // 在代码表格的第一列输出渲染得到的行号
                app.Selection.TypeText(totalLines);
            }

            // 将剪贴板中的 HTML 代码贴入
            app.Selection.MoveRight(Word.WdUnits.wdCell, 1);
            app.Selection.Range.Paste();

            // 调整代码单元格的内容
            codeTable.Cell(1, 2).Range.Font.NameAscii = dropDown_CodeFont_ASCII.SelectedItem.ToString();
            codeTable.Cell(1, 2).Range.Font.NameFarEast = dropDown_CodeFont_FarEast.SelectedItem.ToString();
            codeTable.Cell(1, 2).Range.Font.Size = 9;
            codeTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndAlpha = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndDigit = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.CharacterUnitFirstLineIndent = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.CharacterUnitLeftIndent = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.CharacterUnitRightIndent = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.FirstLineIndent = app.CentimetersToPoints(0);
            codeTable.Cell(1, 2).Range.ParagraphFormat.FarEastLineBreakControl = 0;
            codeTable.Range.ParagraphFormat.LineUnitBefore = 0;
            codeTable.Range.ParagraphFormat.LineUnitAfter = 0;
            codeTable.Range.ParagraphFormat.SpaceBefore = 0;
            codeTable.Range.ParagraphFormat.SpaceAfter = 0;
            codeTable.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceExactly;
            codeTable.Range.ParagraphFormat.LineSpacing = 12;
            codeTable.Range.Font.Bold = 0;
            codeTable.Range.ParagraphFormat.WordWrap = 0;
        }





        /// <summary>
        /// 弹出关于作者和本项目的信息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AboutAddinAndAuthor_Click(object sender, RibbonControlEventArgs e) {
            Form_About.Form_About AboutWindow = new Form_About.Form_About();
            AboutWindow.Show();
        }
    }
}
