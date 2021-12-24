﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Fonts = System.Drawing;
using JS = Microsoft.JScript;
using System.CodeDom.Compiler;
using System.Resources;
using System.Reflection;
using Jering.Web.SyntaxHighlighters.HighlightJS;


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
                Word.Field chapterNumber = app.Selection.Range.Fields.Add(
                    app.Selection.Range,
                    Word.WdFieldType.wdFieldSequence,
                    @"chapter \h",
                    false
                );
                // { SEQ equation \r \h }
                Word.Field equationNumber = app.Selection.Range.Fields.Add(
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
            // 创建一个 Word Document 变量
            Word.Application app = Globals.ThisAddIn.Application;
            Word.Document doc = app.ActiveDocument;

            // 计算相关版面参数
            Dictionary<string, float> page_info = GetDocLayout();

            // 计算边界值
            float LeftMargin = page_info["LeftMargin"];
            float RightMargin = page_info["RightMargin"];
            float PageWidth = page_info["PageWidth"];
            float WidthAvailable = PageWidth - (LeftMargin + RightMargin);
            float WidthForLeft = app.CentimetersToPoints(1.75f);
            float WidthForRight = app.CentimetersToPoints(1.75f);
            float WidthForMiddle = WidthAvailable - (WidthForLeft + WidthForRight);

            // 在光标处插入一个名为 equationTable 的表格
            Word.Table equationTable = app.Selection.Tables.Add(app.Selection.Range, 1, 3);
            Word.Range rng = equationTable.Range;

            // 设置 equationTable 每个单元格的具体宽度
            equationTable.Cell(1, 1).SetWidth(WidthForLeft,     Word.WdRulerStyle.wdAdjustNone);
            equationTable.Cell(1, 2).SetWidth(WidthForMiddle,   Word.WdRulerStyle.wdAdjustNone);
            equationTable.Cell(1, 3).SetWidth(WidthForRight,    Word.WdRulerStyle.wdAdjustNone);

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
            rng.ParagraphFormat.LineUnitBefore  = 0;
            rng.ParagraphFormat.LineUnitAfter   = 0;
            rng.ParagraphFormat.SpaceBefore     = 0;
            rng.ParagraphFormat.SpaceAfter      = 0;
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
                Word.Field chapterNumber = app.Selection.Range.Fields.Add(
                    app.Selection.Range,
                    Word.WdFieldType.wdFieldSequence,
                    @"chapter \c",
                    false
                );

                // Type '-'
                app.Selection.TypeText("-");

                // { SEQ Equation }
                Word.Field equationNumber = app.Selection.Range.Fields.Add(
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
        ///     (1) ASCII 字符占 1 个半角
        ///     (2) 其他字符占 2 个半角
        ///     (3) TODO: TAB 制表符默认为 4 个空格宽度，这个太过复杂，需要写一个替换操作。
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
        /// 获取当前 Word Document 的页边距
        ///     (1) 不需要传参，默认读取当前页面
        ///     (2) 返回字典对象，LeftMargin and RightMargin
        /// </summary>
        Dictionary<string, float> GetDocLayout() {

            var PageInfo = new Dictionary<string, float>();

            Word.Application app = Globals.ThisAddIn.Application;
            Word.Document doc = app.ActiveDocument;

            float LeftMargin   = doc.PageSetup.LeftMargin;
            float RightMargin  = doc.PageSetup.RightMargin;
            float PageWidth    = doc.PageSetup.PageWidth;

            PageInfo.Add("LeftMargin",  LeftMargin);
            PageInfo.Add("RightMargin", RightMargin);
            PageInfo.Add("PageWidth",   PageWidth);

            return PageInfo;
        }





        /// <summary>
        /// 将剪贴板中的内容放入表格，自动生成行号
        ///     (1) TODO:
        ///         I.   [*]  获取页面宽度
        ///         II.  [ ]  获取字体的宽度，写一个下拉菜单，获取字体的磅值 
        ///         III. [*]  计算出 maxCharsOfEachLine 的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InsertCodeBox_Click(object sender, RibbonControlEventArgs e) {

            // 创建一个 Word Document 变量
            Word.Application app = Globals.ThisAddIn.Application;
            
            // 根据下拉列表选择西文字体，默认字符为 9pt (9 points)
            // TO-DO: 字体的类型已经可以根据下拉菜单选取，后续添加根据下拉菜单选择字体大小的功能
            Fonts.Font CodeFont = new Fonts.Font(dropDown_CodeFont_ASCII.SelectedItem.ToString(), 9);

            // 计算相关版面参数
            Dictionary<string, float> page_layout = GetDocLayout();
            float LeftMargin        = page_layout["LeftMargin"];
            float RightMargin       = page_layout["RightMargin"];
            float PageWidth         = page_layout["PageWidth"];

            // 计算实际可用的值
            // TO-DO: 行号 WidthForLineNum 所占的宽度要根据代码行数动态计算
            float WidthAvailable    = PageWidth - (LeftMargin + RightMargin);
            float WidthForLineNum   = app.CentimetersToPoints(0.75f);
            float WidthForCodes     = WidthAvailable - WidthForLineNum;

            // TO-DO: 检查这个计算单个西文字符宽度的方法是否正确
            int maxCharsOfEachLine = (int)(WidthForCodes / (CodeFont.SizeInPoints / 2));

            // 在光标处插入一个名为 CodeTable 的表格
            Word.Table codeTable = app.Selection.Tables.Add(app.Selection.Range, 1, 2);

            // 打开代码单元格的表格边界
            codeTable.Cell(1, 2).Borders.Enable = 1;

            // 设置单元格宽度
            codeTable.Cell(1, 1).SetWidth(WidthForLineNum,  Word.WdRulerStyle.wdAdjustNone);
            codeTable.Cell(1, 2).SetWidth(WidthForCodes,    Word.WdRulerStyle.wdAdjustNone);

            // 整体边界填充
            codeTable.LeftPadding  = app.CentimetersToPoints(0.1f);
            codeTable.RightPadding = app.CentimetersToPoints(0.1f);

            // 设置段前、后的距离
            codeTable.Range.ParagraphFormat.LineUnitBefore  = 0;
            codeTable.Range.ParagraphFormat.LineUnitAfter   = 0;
            codeTable.Range.ParagraphFormat.SpaceBefore     = 0;
            codeTable.Range.ParagraphFormat.SpaceAfter      = 0;

            // 设置行距未固定 12pt
            codeTable.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceExactly;
            codeTable.Range.ParagraphFormat.LineSpacing = 12;

            // 设置字体及其大小
            // TO-DO: 根据下拉菜单动态生成合适的字体大小
            codeTable.Range.Font.NameAscii   = dropDown_CodeFont_ASCII.SelectedItem.ToString();
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
                    } else {
                        isRemainderExist = 1;
                    }

                    // 计算出该逻辑行在该 maxStep 下需要的换行数
                    numOfLineBreaks = GetStrLength(AllLines[i - 1]) / maxCharsOfEachLine + isRemainderExist;

                    // 如果当前逻辑行的行号不能被 maxStep 整除，则不打印该行的逻辑行号
                    if (i % maxStep == 0) {
                        totalLines += i.ToString();
                    }
                    
                    for (int j = 0; j < numOfLineBreaks; j++) {
                        totalLines += "\n";
                    }
                }

                // 最后一行的行号务必打印
                totalLines += numberOfLines.ToString();

                // 在代码表格的第一列输出渲染得到的行号
                app.Selection.TypeText(totalLines);
            }

            // 将剪贴板中的 HTML 代码贴入
            app.Selection.MoveRight(Word.WdUnits.wdCell, 1);
            app.Selection.Range.Paste();

            // 调整代码单元格的字体
            codeTable.Cell(1, 2).Range.Font.NameAscii   = dropDown_CodeFont_ASCII.SelectedItem.ToString();
            codeTable.Cell(1, 2).Range.Font.NameFarEast = dropDown_CodeFont_FarEast.SelectedItem.ToString();
            
            // 设置代码单元格的字体为 9pt
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
        




        /// <summary>
        /// TEST CODE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TestBtn_Click(object sender, RibbonControlEventArgs e) {
            string code = Properties.Resources.test_js_plus;

            // Highlight code
            string result = await StaticHighlightJSService.HighlightAsync(code, "csharp");
            Word.Application app = Globals.ThisAddIn.Application;

            // 构造 HTML 文件，嵌入 style css
            string html_head = Properties.Resources.header;
            string html_tail = Properties.Resources.tail;

            app.Selection.TypeText(html_head);
            app.Selection.TypeText(result);
            app.Selection.TypeText(html_tail);
        }
    }
}
