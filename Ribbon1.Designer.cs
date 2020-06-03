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
            this.MainTab = this.Factory.CreateRibbonTab();
            this.EquationGroup = this.Factory.CreateRibbonGroup();
            this.CodeGroup = this.Factory.CreateRibbonGroup();
            this.IntroduceGroup = this.Factory.CreateRibbonGroup();
            this.btn_AboutThisAddIn = this.Factory.CreateRibbonButton();
            this.btn_InsertEquation = this.Factory.CreateRibbonButton();
            this.btn_InsertCodeBox = this.Factory.CreateRibbonButton();
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
            this.EquationGroup.Items.Add(this.btn_InsertEquation);
            this.EquationGroup.Label = "公式";
            this.EquationGroup.Name = "EquationGroup";
            // 
            // CodeGroup
            // 
            this.CodeGroup.Items.Add(this.btn_InsertCodeBox);
            this.CodeGroup.Label = "代码";
            this.CodeGroup.Name = "CodeGroup";
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
            this.btn_AboutThisAddIn.Label = "关于插件";
            this.btn_AboutThisAddIn.Name = "btn_AboutThisAddIn";
            this.btn_AboutThisAddIn.ShowImage = true;
            this.btn_AboutThisAddIn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_AboutThisAddIn_Click);
            // 
            // btn_InsertEquation
            // 
            this.btn_InsertEquation.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_InsertEquation.Image = global::Equation_and_Codebox.Properties.Resources.equation_icon;
            this.btn_InsertEquation.Label = "插入带编号的公式";
            this.btn_InsertEquation.Name = "btn_InsertEquation";
            this.btn_InsertEquation.ShowImage = true;
            this.btn_InsertEquation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InsertEquation_Click);
            // 
            // btn_InsertCodeBox
            // 
            this.btn_InsertCodeBox.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_InsertCodeBox.Image = global::Equation_and_Codebox.Properties.Resources.CodeTable_icon;
            this.btn_InsertCodeBox.Label = "从剪贴板插入代码";
            this.btn_InsertCodeBox.Name = "btn_InsertCodeBox";
            this.btn_InsertCodeBox.ShowImage = true;
            this.btn_InsertCodeBox.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InsertCodeBox_Click);
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_InsertCodeBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup IntroduceGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_AboutThisAddIn;
    }

    partial class ThisRibbonCollection {
        internal Ribbon1 Ribbon1 {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
