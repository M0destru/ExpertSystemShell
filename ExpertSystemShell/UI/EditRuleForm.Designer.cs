namespace ExpertSystemShell.UI
{
    partial class EditRuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRuleName = new System.Windows.Forms.Panel();
            this.lblRuleName = new System.Windows.Forms.Label();
            this.tbRuleName = new System.Windows.Forms.TextBox();
            this.gbRulePremise = new System.Windows.Forms.GroupBox();
            this.lstBoxPremise = new EnhancedListBox.DragDropListBox();
            this.btnAddPremiseFact = new System.Windows.Forms.Button();
            this.btnChangePremiseFact = new System.Windows.Forms.Button();
            this.btnDelPremiseFact = new System.Windows.Forms.Button();
            this.gbRuleInference = new System.Windows.Forms.GroupBox();
            this.lstBoxInference = new EnhancedListBox.DragDropListBox();
            this.btnAddInferenceFact = new System.Windows.Forms.Button();
            this.btnChangeInferenceFact = new System.Windows.Forms.Button();
            this.btnDelInferenceFact = new System.Windows.Forms.Button();
            this.panelExplanation = new System.Windows.Forms.Panel();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.tbExplanation = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOKRule = new System.Windows.Forms.Button();
            this.panelRuleName.SuspendLayout();
            this.gbRulePremise.SuspendLayout();
            this.gbRuleInference.SuspendLayout();
            this.panelExplanation.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRuleName
            // 
            this.panelRuleName.Controls.Add(this.lblRuleName);
            this.panelRuleName.Controls.Add(this.tbRuleName);
            this.panelRuleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRuleName.Location = new System.Drawing.Point(0, 0);
            this.panelRuleName.Name = "panelRuleName";
            this.panelRuleName.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.panelRuleName.Size = new System.Drawing.Size(584, 49);
            this.panelRuleName.TabIndex = 0;
            // 
            // lblRuleName
            // 
            this.lblRuleName.AutoSize = true;
            this.lblRuleName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRuleName.Location = new System.Drawing.Point(3, 6);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(95, 16);
            this.lblRuleName.TabIndex = 1;
            this.lblRuleName.Text = "Имя правила:";
            // 
            // tbRuleName
            // 
            this.tbRuleName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbRuleName.Location = new System.Drawing.Point(3, 22);
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.Size = new System.Drawing.Size(578, 22);
            this.tbRuleName.TabIndex = 0;
            this.tbRuleName.TextChanged += new System.EventHandler(this.tbRuleName_TextChanged);
            // 
            // gbRulePremise
            // 
            this.gbRulePremise.Controls.Add(this.lstBoxPremise);
            this.gbRulePremise.Controls.Add(this.btnAddPremiseFact);
            this.gbRulePremise.Controls.Add(this.btnChangePremiseFact);
            this.gbRulePremise.Controls.Add(this.btnDelPremiseFact);
            this.gbRulePremise.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbRulePremise.Location = new System.Drawing.Point(0, 49);
            this.gbRulePremise.Name = "gbRulePremise";
            this.gbRulePremise.Size = new System.Drawing.Size(290, 184);
            this.gbRulePremise.TabIndex = 1;
            this.gbRulePremise.TabStop = false;
            this.gbRulePremise.Text = "Посылка";
            // 
            // lstBoxPremise
            // 
            this.lstBoxPremise.AllowDrop = true;
            this.lstBoxPremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxPremise.FormattingEnabled = true;
            this.lstBoxPremise.HorizontalScrollbar = true;
            this.lstBoxPremise.ItemHeight = 16;
            this.lstBoxPremise.Location = new System.Drawing.Point(3, 18);
            this.lstBoxPremise.Name = "lstBoxPremise";
            this.lstBoxPremise.Size = new System.Drawing.Size(284, 103);
            this.lstBoxPremise.TabIndex = 4;
            this.lstBoxPremise.SelectedIndexChanged += new System.EventHandler(this.lstBoxPremise_SelectedIndexChanged);
            // 
            // btnAddPremiseFact
            // 
            this.btnAddPremiseFact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddPremiseFact.Location = new System.Drawing.Point(3, 121);
            this.btnAddPremiseFact.Name = "btnAddPremiseFact";
            this.btnAddPremiseFact.Size = new System.Drawing.Size(284, 20);
            this.btnAddPremiseFact.TabIndex = 1;
            this.btnAddPremiseFact.Text = "Добавить";
            this.btnAddPremiseFact.UseVisualStyleBackColor = true;
            this.btnAddPremiseFact.Click += new System.EventHandler(this.btnAddPremiseFact_Click);
            // 
            // btnChangePremiseFact
            // 
            this.btnChangePremiseFact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangePremiseFact.Location = new System.Drawing.Point(3, 141);
            this.btnChangePremiseFact.Name = "btnChangePremiseFact";
            this.btnChangePremiseFact.Size = new System.Drawing.Size(284, 20);
            this.btnChangePremiseFact.TabIndex = 2;
            this.btnChangePremiseFact.Text = "Изменить";
            this.btnChangePremiseFact.UseVisualStyleBackColor = true;
            this.btnChangePremiseFact.Click += new System.EventHandler(this.btnChangePremiseFact_Click);
            // 
            // btnDelPremiseFact
            // 
            this.btnDelPremiseFact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelPremiseFact.Location = new System.Drawing.Point(3, 161);
            this.btnDelPremiseFact.Name = "btnDelPremiseFact";
            this.btnDelPremiseFact.Size = new System.Drawing.Size(284, 20);
            this.btnDelPremiseFact.TabIndex = 3;
            this.btnDelPremiseFact.Text = "Удалить";
            this.btnDelPremiseFact.UseVisualStyleBackColor = true;
            this.btnDelPremiseFact.Click += new System.EventHandler(this.btnDelPremiseFact_Click);
            // 
            // gbRuleInference
            // 
            this.gbRuleInference.Controls.Add(this.lstBoxInference);
            this.gbRuleInference.Controls.Add(this.btnAddInferenceFact);
            this.gbRuleInference.Controls.Add(this.btnChangeInferenceFact);
            this.gbRuleInference.Controls.Add(this.btnDelInferenceFact);
            this.gbRuleInference.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbRuleInference.Location = new System.Drawing.Point(294, 49);
            this.gbRuleInference.Name = "gbRuleInference";
            this.gbRuleInference.Size = new System.Drawing.Size(290, 184);
            this.gbRuleInference.TabIndex = 2;
            this.gbRuleInference.TabStop = false;
            this.gbRuleInference.Text = "Заключение";
            // 
            // lstBoxInference
            // 
            this.lstBoxInference.AllowDrop = true;
            this.lstBoxInference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxInference.FormattingEnabled = true;
            this.lstBoxInference.HorizontalScrollbar = true;
            this.lstBoxInference.ItemHeight = 16;
            this.lstBoxInference.Location = new System.Drawing.Point(3, 18);
            this.lstBoxInference.Name = "lstBoxInference";
            this.lstBoxInference.Size = new System.Drawing.Size(284, 103);
            this.lstBoxInference.TabIndex = 4;
            this.lstBoxInference.SelectedIndexChanged += new System.EventHandler(this.lstBoxInference_SelectedIndexChanged);
            // 
            // btnAddInferenceFact
            // 
            this.btnAddInferenceFact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddInferenceFact.Location = new System.Drawing.Point(3, 121);
            this.btnAddInferenceFact.Name = "btnAddInferenceFact";
            this.btnAddInferenceFact.Size = new System.Drawing.Size(284, 20);
            this.btnAddInferenceFact.TabIndex = 1;
            this.btnAddInferenceFact.Text = "Добавить";
            this.btnAddInferenceFact.UseVisualStyleBackColor = true;
            this.btnAddInferenceFact.Click += new System.EventHandler(this.btnAddInferenceFact_Click);
            // 
            // btnChangeInferenceFact
            // 
            this.btnChangeInferenceFact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeInferenceFact.Location = new System.Drawing.Point(3, 141);
            this.btnChangeInferenceFact.Name = "btnChangeInferenceFact";
            this.btnChangeInferenceFact.Size = new System.Drawing.Size(284, 20);
            this.btnChangeInferenceFact.TabIndex = 3;
            this.btnChangeInferenceFact.Text = "Изменить";
            this.btnChangeInferenceFact.UseVisualStyleBackColor = true;
            this.btnChangeInferenceFact.Click += new System.EventHandler(this.btnChangeInferenceFact_Click);
            // 
            // btnDelInferenceFact
            // 
            this.btnDelInferenceFact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelInferenceFact.Location = new System.Drawing.Point(3, 161);
            this.btnDelInferenceFact.Name = "btnDelInferenceFact";
            this.btnDelInferenceFact.Size = new System.Drawing.Size(284, 20);
            this.btnDelInferenceFact.TabIndex = 2;
            this.btnDelInferenceFact.Text = "Удалить";
            this.btnDelInferenceFact.UseVisualStyleBackColor = true;
            this.btnDelInferenceFact.Click += new System.EventHandler(this.btnDelInferenceFact_Click);
            // 
            // panelExplanation
            // 
            this.panelExplanation.Controls.Add(this.lblExplanation);
            this.panelExplanation.Controls.Add(this.tbExplanation);
            this.panelExplanation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExplanation.Location = new System.Drawing.Point(0, 233);
            this.panelExplanation.Name = "panelExplanation";
            this.panelExplanation.Padding = new System.Windows.Forms.Padding(3);
            this.panelExplanation.Size = new System.Drawing.Size(584, 49);
            this.panelExplanation.TabIndex = 3;
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblExplanation.Location = new System.Drawing.Point(3, -4);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(82, 16);
            this.lblExplanation.TabIndex = 1;
            this.lblExplanation.Text = "Пояснение:";
            // 
            // tbExplanation
            // 
            this.tbExplanation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbExplanation.Location = new System.Drawing.Point(3, 12);
            this.tbExplanation.Multiline = true;
            this.tbExplanation.Name = "tbExplanation";
            this.tbExplanation.Size = new System.Drawing.Size(578, 34);
            this.tbExplanation.TabIndex = 0;
            this.tbExplanation.TextChanged += new System.EventHandler(this.tbExplanation_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnOKRule);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 282);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnOKRule
            // 
            this.btnOKRule.Location = new System.Drawing.Point(506, 3);
            this.btnOKRule.Name = "btnOKRule";
            this.btnOKRule.Size = new System.Drawing.Size(75, 23);
            this.btnOKRule.TabIndex = 1;
            this.btnOKRule.Text = "ОК";
            this.btnOKRule.UseVisualStyleBackColor = true;
            this.btnOKRule.Click += new System.EventHandler(this.btnOKRule_Click);
            // 
            // EditRuleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.gbRuleInference);
            this.Controls.Add(this.gbRulePremise);
            this.Controls.Add(this.panelExplanation);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelRuleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRuleForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление правила";
            this.panelRuleName.ResumeLayout(false);
            this.panelRuleName.PerformLayout();
            this.gbRulePremise.ResumeLayout(false);
            this.gbRuleInference.ResumeLayout(false);
            this.panelExplanation.ResumeLayout(false);
            this.panelExplanation.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRuleName;
        private System.Windows.Forms.Label lblRuleName;
        private System.Windows.Forms.TextBox tbRuleName;
        private System.Windows.Forms.GroupBox gbRulePremise;
        private System.Windows.Forms.Button btnDelPremiseFact;
        private System.Windows.Forms.Button btnChangePremiseFact;
        private System.Windows.Forms.Button btnAddPremiseFact;
        private System.Windows.Forms.GroupBox gbRuleInference;
        private System.Windows.Forms.Button btnDelInferenceFact;
        private System.Windows.Forms.Button btnChangeInferenceFact;
        private System.Windows.Forms.Button btnAddInferenceFact;
        private System.Windows.Forms.Panel panelExplanation;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.TextBox tbExplanation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOKRule;
        private EnhancedListBox.DragDropListBox lstBoxPremise;
        private EnhancedListBox.DragDropListBox lstBoxInference;
    }
}