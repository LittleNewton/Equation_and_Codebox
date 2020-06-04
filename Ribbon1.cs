using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;

namespace Equation_and_Codebox {
    public partial class Ribbon1 {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e) {

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
            codeTable.Range.Font.NameAscii = "LM Mono 10";
            codeTable.Range.Font.NameFarEast = "宋体";
            codeTable.Range.Font.Size = 9;

            // 设置单元格对齐方式
            codeTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            codeTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            // 中英文字符间距自动调整：Disable
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndAlpha = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndDigit = 0;

            // 输入连续的行号
            string stringNumberOfLines = Microsoft.VisualBasic.Interaction.InputBox("请输入代码终止行数", "输入行数", "50");
            int NumberOfLines = Int32.Parse(stringNumberOfLines);
            for (int i = 1; i <= NumberOfLines - 1; i++) {
                app.Selection.TypeText(i.ToString() + "\n");
            }
            app.Selection.TypeText(stringNumberOfLines);

            // 将剪贴板中的 HTML 代码贴入
            app.Selection.MoveRight(Word.WdUnits.wdCell, 1);
            app.Selection.Range.Paste();

            // 调整代码单元格的内容
            codeTable.Cell(1, 2).Range.Font.NameAscii = "LM Mono 10";
            codeTable.Cell(1, 2).Range.Font.NameFarEast = "宋体";
            codeTable.Cell(1, 2).Range.Font.Size = 9;
            codeTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndAlpha = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.AddSpaceBetweenFarEastAndDigit = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.CharacterUnitFirstLineIndent = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.CharacterUnitLeftIndent = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.CharacterUnitRightIndent = 0;
            codeTable.Cell(1, 2).Range.ParagraphFormat.FirstLineIndent = app.CentimetersToPoints(0);
            codeTable.Range.ParagraphFormat.LineUnitBefore = 0;
            codeTable.Range.ParagraphFormat.LineUnitAfter = 0;
            codeTable.Range.ParagraphFormat.SpaceBefore = 0;
            codeTable.Range.ParagraphFormat.SpaceAfter = 0;
            codeTable.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceExactly;
            codeTable.Range.ParagraphFormat.LineSpacing = 12;
            codeTable.Range.Font.Bold = 0;

            // 删掉代码块的最后一个空行
            app.Selection.EndOf(WdUnits.wdCell);
            app.Selection.TypeBackspace();
        }





        /// <summary>
        /// 显示版权信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AboutThisAddIn_Click(object sender, RibbonControlEventArgs e) {
            MessageBox.Show("Copyright @刘鹏, 2020,\nContact: littleNewton6@gmail.com");
        }





        /// <summary>
        /// 插入公式编排所需的域代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertFieldCode_Click(object sender, RibbonControlEventArgs e) {
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
    }
}
