using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;

namespace Equation_and_Codebox {
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory()) {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            this.MainTab = this.Factory.CreateRibbonTab();
            this.EquationGroup = this.Factory.CreateRibbonGroup();
            this.InsertFieldCode = this.Factory.CreateRibbonButton();
            this.btn_InsertEquation = this.Factory.CreateRibbonButton();
            this.CodeGroup = this.Factory.CreateRibbonGroup();
            this.btn_InsertCodeBox = this.Factory.CreateRibbonButton();
            this.dropDown_lineStep = this.Factory.CreateRibbonDropDown();
            this.dropDown_CodeFont_ASCII = this.Factory.CreateRibbonDropDown();
            this.dropDown_CodeFont_FarEast = this.Factory.CreateRibbonDropDown();
            this.IntroduceGroup = this.Factory.CreateRibbonGroup();
            this.btn_AboutThisAddIn = this.Factory.CreateRibbonButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainTab.SuspendLayout();
            this.EquationGroup.SuspendLayout();
            this.CodeGroup.SuspendLayout();
            this.IntroduceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.MainTab.Groups.Add(this.EquationGroup);
            this.MainTab.Groups.Add(this.CodeGroup);
            this.MainTab.Groups.Add(this.IntroduceGroup);
            this.MainTab.Label = "公式与代码";
            this.MainTab.Name = "MainTab";
            // 
            // EquationGroup
            // 
            this.EquationGroup.Items.Add(this.InsertFieldCode);
            this.EquationGroup.Items.Add(this.btn_InsertEquation);
            this.EquationGroup.Label = "公式";
            this.EquationGroup.Name = "EquationGroup";
            // 
            // InsertFieldCode
            // 
            this.InsertFieldCode.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.InsertFieldCode.Image = global::Equation_and_Codebox.Properties.Resources.InsertFieldCode;
            this.InsertFieldCode.Label = "插入 SEQ 域组合";
            this.InsertFieldCode.Name = "InsertFieldCode";
            this.InsertFieldCode.ShowImage = true;
            this.InsertFieldCode.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InsertFieldCode_Click);
            // 
            // btn_InsertEquation
            // 
            this.btn_InsertEquation.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_InsertEquation.Image = global::Equation_and_Codebox.Properties.Resources.InsertEquation;
            this.btn_InsertEquation.Label = "插入带编号的公式";
            this.btn_InsertEquation.Name = "btn_InsertEquation";
            this.btn_InsertEquation.ShowImage = true;
            this.btn_InsertEquation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InsertEquation_Click);
            // 
            // CodeGroup
            // 
            this.CodeGroup.Items.Add(this.btn_InsertCodeBox);
            this.CodeGroup.Items.Add(this.dropDown_lineStep);
            this.CodeGroup.Items.Add(this.dropDown_CodeFont_ASCII);
            this.CodeGroup.Items.Add(this.dropDown_CodeFont_FarEast);
            this.CodeGroup.Label = "代码";
            this.CodeGroup.Name = "CodeGroup";
            // 
            // btn_InsertCodeBox
            // 
            this.btn_InsertCodeBox.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_InsertCodeBox.Image = global::Equation_and_Codebox.Properties.Resources.InsertCode;
            this.btn_InsertCodeBox.Label = "从剪贴板插入纯文本代码";
            this.btn_InsertCodeBox.Name = "btn_InsertCodeBox";
            this.btn_InsertCodeBox.ShowImage = true;
            this.btn_InsertCodeBox.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InsertCodeBox_Click);
            // 
            // dropDown_lineStep
            // 
            this.dropDown_lineStep.Image = global::Equation_and_Codebox.Properties.Resources.delta;
            ribbonDropDownItemImpl1.Label = "1";
            ribbonDropDownItemImpl2.Label = "5";
            ribbonDropDownItemImpl3.Label = "10";
            ribbonDropDownItemImpl4.Label = "20";
            this.dropDown_lineStep.Items.Add(ribbonDropDownItemImpl1);
            this.dropDown_lineStep.Items.Add(ribbonDropDownItemImpl2);
            this.dropDown_lineStep.Items.Add(ribbonDropDownItemImpl3);
            this.dropDown_lineStep.Items.Add(ribbonDropDownItemImpl4);
            this.dropDown_lineStep.Label = "行号步长";
            this.dropDown_lineStep.Name = "dropDown_lineStep";
            this.dropDown_lineStep.ShowImage = true;
            // 
            // dropDown_CodeFont_ASCII
            // 
            this.dropDown_CodeFont_ASCII.Image = global::Equation_and_Codebox.Properties.Resources.AsciiCharFont;
            ribbonDropDownItemImpl5.Label = "LM Mono 10";
            ribbonDropDownItemImpl6.Label = "Fira Code";
            ribbonDropDownItemImpl7.Label = "Iosevka";
            ribbonDropDownItemImpl8.Label = "Consolas";
            ribbonDropDownItemImpl9.Label = "宋体";
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl5);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl6);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl7);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl8);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl9);
            this.dropDown_CodeFont_ASCII.Label = "代码字体";
            this.dropDown_CodeFont_ASCII.Name = "dropDown_CodeFont_ASCII";
            this.dropDown_CodeFont_ASCII.ShowImage = true;
            // 
            // dropDown_CodeFont_FarEast
            // 
            this.dropDown_CodeFont_FarEast.Image = global::Equation_and_Codebox.Properties.Resources.FarEastCharFont;
            ribbonDropDownItemImpl10.Label = "宋体";
            ribbonDropDownItemImpl11.Label = "等线";
            ribbonDropDownItemImpl12.Label = "微软雅黑";
            this.dropDown_CodeFont_FarEast.Items.Add(ribbonDropDownItemImpl10);
            this.dropDown_CodeFont_FarEast.Items.Add(ribbonDropDownItemImpl11);
            this.dropDown_CodeFont_FarEast.Items.Add(ribbonDropDownItemImpl12);
            this.dropDown_CodeFont_FarEast.Label = "中文字体";
            this.dropDown_CodeFont_FarEast.Name = "dropDown_CodeFont_FarEast";
            this.dropDown_CodeFont_FarEast.ShowImage = true;
            // 
            // IntroduceGroup
            // 
            this.IntroduceGroup.Items.Add(this.btn_AboutThisAddIn);
            this.IntroduceGroup.Label = "关于";
            this.IntroduceGroup.Name = "IntroduceGroup";
            // 
            // btn_AboutThisAddIn
            // 
            this.btn_AboutThisAddIn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_AboutThisAddIn.Image = global::Equation_and_Codebox.Properties.Resources.About;
            this.btn_AboutThisAddIn.Label = "关于插件";
            this.btn_AboutThisAddIn.Name = "btn_AboutThisAddIn";
            this.btn_AboutThisAddIn.ShowImage = true;
            this.btn_AboutThisAddIn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_AboutThisAddIn_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.MainTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.EquationGroup.ResumeLayout(false);
            this.EquationGroup.PerformLayout();
            this.CodeGroup.ResumeLayout(false);
            this.CodeGroup.PerformLayout();
            this.IntroduceGroup.ResumeLayout(false);
            this.IntroduceGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab MainTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup EquationGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_InsertEquation;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup CodeGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup IntroduceGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_AboutThisAddIn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton InsertFieldCode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_InsertCodeBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_lineStep;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_CodeFont_ASCII;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_CodeFont_FarEast;
    }

    partial class ThisRibbonCollection {
        internal Ribbon1 Ribbon1 {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
