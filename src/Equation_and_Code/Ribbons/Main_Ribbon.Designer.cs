namespace Equation_and_Code.Ribbon {
    partial class Main_Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Main_Ribbon()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Ribbon));
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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            this.公式与代码 = this.Factory.CreateRibbonTab();
            this.Group_Equation = this.Factory.CreateRibbonGroup();
            this.btn_InsertFieldCode = this.Factory.CreateRibbonButton();
            this.btn_InsertEquation = this.Factory.CreateRibbonButton();
            this.Group_Code = this.Factory.CreateRibbonGroup();
            this.btn_InsertCodeBox = this.Factory.CreateRibbonButton();
            this.dropDown_lineStep = this.Factory.CreateRibbonDropDown();
            this.dropDown1 = this.Factory.CreateRibbonDropDown();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.dropDown_CodeFont_ASCII = this.Factory.CreateRibbonDropDown();
            this.dropDown_CodeFont_FarEast = this.Factory.CreateRibbonDropDown();
            this.Group_About = this.Factory.CreateRibbonGroup();
            this.btn_AboutAddinAndAuthor = this.Factory.CreateRibbonButton();
            this.TestGroup = this.Factory.CreateRibbonGroup();
            this.TestBtn = this.Factory.CreateRibbonButton();
            this.公式与代码.SuspendLayout();
            this.Group_Equation.SuspendLayout();
            this.Group_Code.SuspendLayout();
            this.Group_About.SuspendLayout();
            this.TestGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // 公式与代码
            // 
            this.公式与代码.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.公式与代码.Groups.Add(this.Group_Equation);
            this.公式与代码.Groups.Add(this.Group_Code);
            this.公式与代码.Groups.Add(this.Group_About);
            this.公式与代码.Groups.Add(this.TestGroup);
            this.公式与代码.Label = "公式与代码";
            this.公式与代码.Name = "公式与代码";
            // 
            // Group_Equation
            // 
            this.Group_Equation.Items.Add(this.btn_InsertFieldCode);
            this.Group_Equation.Items.Add(this.btn_InsertEquation);
            this.Group_Equation.Label = "公式";
            this.Group_Equation.Name = "Group_Equation";
            // 
            // btn_InsertFieldCode
            // 
            this.btn_InsertFieldCode.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_InsertFieldCode.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertFieldCode.Image")));
            this.btn_InsertFieldCode.Label = "插入 SEQ 域组合";
            this.btn_InsertFieldCode.Name = "btn_InsertFieldCode";
            this.btn_InsertFieldCode.ShowImage = true;
            this.btn_InsertFieldCode.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InsertFieldCode_Click);
            // 
            // btn_InsertEquation
            // 
            this.btn_InsertEquation.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_InsertEquation.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertEquation.Image")));
            this.btn_InsertEquation.Label = "插入带编号的公式";
            this.btn_InsertEquation.Name = "btn_InsertEquation";
            this.btn_InsertEquation.ShowImage = true;
            this.btn_InsertEquation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InsertEquation_Click);
            // 
            // Group_Code
            // 
            this.Group_Code.Items.Add(this.btn_InsertCodeBox);
            this.Group_Code.Items.Add(this.dropDown_lineStep);
            this.Group_Code.Items.Add(this.dropDown1);
            this.Group_Code.Items.Add(this.separator1);
            this.Group_Code.Items.Add(this.dropDown_CodeFont_ASCII);
            this.Group_Code.Items.Add(this.dropDown_CodeFont_FarEast);
            this.Group_Code.Label = "代码";
            this.Group_Code.Name = "Group_Code";
            // 
            // btn_InsertCodeBox
            // 
            this.btn_InsertCodeBox.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_InsertCodeBox.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertCodeBox.Image")));
            this.btn_InsertCodeBox.Label = "从剪贴板插入代码";
            this.btn_InsertCodeBox.Name = "btn_InsertCodeBox";
            this.btn_InsertCodeBox.ShowImage = true;
            this.btn_InsertCodeBox.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InsertCodeBox_Click);
            // 
            // dropDown_lineStep
            // 
            this.dropDown_lineStep.Image = ((System.Drawing.Image)(resources.GetObject("dropDown_lineStep.Image")));
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
            // dropDown1
            // 
            this.dropDown1.Image = ((System.Drawing.Image)(resources.GetObject("dropDown1.Image")));
            ribbonDropDownItemImpl5.Label = "9";
            ribbonDropDownItemImpl5.Tag = "";
            this.dropDown1.Items.Add(ribbonDropDownItemImpl5);
            this.dropDown1.Label = "字体大小";
            this.dropDown1.Name = "dropDown1";
            this.dropDown1.ShowImage = true;
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // dropDown_CodeFont_ASCII
            // 
            this.dropDown_CodeFont_ASCII.Image = ((System.Drawing.Image)(resources.GetObject("dropDown_CodeFont_ASCII.Image")));
            ribbonDropDownItemImpl6.Label = "Iosevka";
            ribbonDropDownItemImpl7.Label = "LM Mono 10";
            ribbonDropDownItemImpl8.Label = "Fira Code";
            ribbonDropDownItemImpl9.Label = "Consolas";
            ribbonDropDownItemImpl10.Label = "宋体";
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl6);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl7);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl8);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl9);
            this.dropDown_CodeFont_ASCII.Items.Add(ribbonDropDownItemImpl10);
            this.dropDown_CodeFont_ASCII.Label = "代码字体";
            this.dropDown_CodeFont_ASCII.Name = "dropDown_CodeFont_ASCII";
            this.dropDown_CodeFont_ASCII.ShowImage = true;
            // 
            // dropDown_CodeFont_FarEast
            // 
            this.dropDown_CodeFont_FarEast.Image = ((System.Drawing.Image)(resources.GetObject("dropDown_CodeFont_FarEast.Image")));
            ribbonDropDownItemImpl11.Label = "宋体";
            ribbonDropDownItemImpl12.Label = "等线";
            ribbonDropDownItemImpl13.Label = "微软雅黑";
            this.dropDown_CodeFont_FarEast.Items.Add(ribbonDropDownItemImpl11);
            this.dropDown_CodeFont_FarEast.Items.Add(ribbonDropDownItemImpl12);
            this.dropDown_CodeFont_FarEast.Items.Add(ribbonDropDownItemImpl13);
            this.dropDown_CodeFont_FarEast.Label = "中文字体";
            this.dropDown_CodeFont_FarEast.Name = "dropDown_CodeFont_FarEast";
            this.dropDown_CodeFont_FarEast.ShowImage = true;
            // 
            // Group_About
            // 
            this.Group_About.Items.Add(this.btn_AboutAddinAndAuthor);
            this.Group_About.Label = "关于";
            this.Group_About.Name = "Group_About";
            // 
            // btn_AboutAddinAndAuthor
            // 
            this.btn_AboutAddinAndAuthor.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_AboutAddinAndAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btn_AboutAddinAndAuthor.Image")));
            this.btn_AboutAddinAndAuthor.Label = "关于插件及作者";
            this.btn_AboutAddinAndAuthor.Name = "btn_AboutAddinAndAuthor";
            this.btn_AboutAddinAndAuthor.ShowImage = true;
            this.btn_AboutAddinAndAuthor.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_AboutAddinAndAuthor_Click);
            // 
            // TestGroup
            // 
            this.TestGroup.Items.Add(this.TestBtn);
            this.TestGroup.Label = "TEST";
            this.TestGroup.Name = "TestGroup";
            // 
            // TestBtn
            // 
            this.TestBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.TestBtn.Image = ((System.Drawing.Image)(resources.GetObject("TestBtn.Image")));
            this.TestBtn.Label = "test";
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.ShowImage = true;
            this.TestBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TestBtn_Click);
            // 
            // Main_Ribbon
            // 
            this.Name = "Main_Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.公式与代码);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.公式与代码.ResumeLayout(false);
            this.公式与代码.PerformLayout();
            this.Group_Equation.ResumeLayout(false);
            this.Group_Equation.PerformLayout();
            this.Group_Code.ResumeLayout(false);
            this.Group_Code.PerformLayout();
            this.Group_About.ResumeLayout(false);
            this.Group_About.PerformLayout();
            this.TestGroup.ResumeLayout(false);
            this.TestGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab 公式与代码;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Group_Equation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_InsertFieldCode;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_InsertEquation;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Group_Code;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_InsertCodeBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_lineStep;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_CodeFont_ASCII;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_CodeFont_FarEast;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Group_About;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_AboutAddinAndAuthor;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TestGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TestBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }
}
