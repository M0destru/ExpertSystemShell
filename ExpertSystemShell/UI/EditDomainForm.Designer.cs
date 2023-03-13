namespace ExpertSystemShell.UI
{
    partial class EditDomainForm
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
            this.gbDomainName = new System.Windows.Forms.GroupBox();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbDomainValues = new System.Windows.Forms.GroupBox();
            this.btnDelDomainValue = new System.Windows.Forms.Button();
            this.panelDomainOperations = new System.Windows.Forms.Panel();
            this.tbDomainValue = new System.Windows.Forms.TextBox();
            this.btnEditDomainValue = new System.Windows.Forms.Button();
            this.lstBoxDomainValues = new EnhancedListBox.DragDropListBox();
            this.gbDomainName.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.gbDomainValues.SuspendLayout();
            this.panelDomainOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDomainName
            // 
            this.gbDomainName.Controls.Add(this.tbDomainName);
            this.gbDomainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDomainName.Location = new System.Drawing.Point(0, 0);
            this.gbDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.gbDomainName.Name = "gbDomainName";
            this.gbDomainName.Padding = new System.Windows.Forms.Padding(4);
            this.gbDomainName.Size = new System.Drawing.Size(419, 54);
            this.gbDomainName.TabIndex = 0;
            this.gbDomainName.TabStop = false;
            this.gbDomainName.Text = "Имя домена";
            // 
            // tbDomainName
            // 
            this.tbDomainName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDomainName.Location = new System.Drawing.Point(4, 19);
            this.tbDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(411, 22);
            this.tbDomainName.TabIndex = 0;
            this.tbDomainName.TextChanged += new System.EventHandler(this.tbDomainName_TextChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Controls.Add(this.btnOk);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 300);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(419, 36);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(315, 4);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbDomainValues
            // 
            this.gbDomainValues.Controls.Add(this.lstBoxDomainValues);
            this.gbDomainValues.Controls.Add(this.btnDelDomainValue);
            this.gbDomainValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDomainValues.Location = new System.Drawing.Point(0, 54);
            this.gbDomainValues.Margin = new System.Windows.Forms.Padding(4);
            this.gbDomainValues.Name = "gbDomainValues";
            this.gbDomainValues.Padding = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.gbDomainValues.Size = new System.Drawing.Size(419, 193);
            this.gbDomainValues.TabIndex = 3;
            this.gbDomainValues.TabStop = false;
            this.gbDomainValues.Text = "Допустимые значения домена";
            // 
            // btnDelDomainValue
            // 
            this.btnDelDomainValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelDomainValue.Location = new System.Drawing.Point(4, 158);
            this.btnDelDomainValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelDomainValue.Name = "btnDelDomainValue";
            this.btnDelDomainValue.Size = new System.Drawing.Size(411, 28);
            this.btnDelDomainValue.TabIndex = 0;
            this.btnDelDomainValue.Text = "Удалить";
            this.btnDelDomainValue.UseVisualStyleBackColor = true;
            this.btnDelDomainValue.Click += new System.EventHandler(this.btnDelDomainValue_Click);
            // 
            // panelDomainOperations
            // 
            this.panelDomainOperations.Controls.Add(this.tbDomainValue);
            this.panelDomainOperations.Controls.Add(this.btnEditDomainValue);
            this.panelDomainOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDomainOperations.Location = new System.Drawing.Point(0, 247);
            this.panelDomainOperations.Margin = new System.Windows.Forms.Padding(4);
            this.panelDomainOperations.Name = "panelDomainOperations";
            this.panelDomainOperations.Padding = new System.Windows.Forms.Padding(4);
            this.panelDomainOperations.Size = new System.Drawing.Size(419, 34);
            this.panelDomainOperations.TabIndex = 4;
            // 
            // tbDomainValue
            // 
            this.tbDomainValue.Location = new System.Drawing.Point(4, 4);
            this.tbDomainValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbDomainValue.Name = "tbDomainValue";
            this.tbDomainValue.Size = new System.Drawing.Size(297, 22);
            this.tbDomainValue.TabIndex = 2;
            // 
            // btnEditDomainValue
            // 
            this.btnEditDomainValue.Location = new System.Drawing.Point(311, 1);
            this.btnEditDomainValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDomainValue.Name = "btnEditDomainValue";
            this.btnEditDomainValue.Size = new System.Drawing.Size(100, 30);
            this.btnEditDomainValue.TabIndex = 1;
            this.btnEditDomainValue.Text = "Добавить";
            this.btnEditDomainValue.UseVisualStyleBackColor = true;
            this.btnEditDomainValue.Click += new System.EventHandler(this.btnEditDomainValue_Click);
            // 
            // lstBoxDomainValues
            // 
            this.lstBoxDomainValues.AllowDrop = true;
            this.lstBoxDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxDomainValues.FormattingEnabled = true;
            this.lstBoxDomainValues.ItemHeight = 16;
            this.lstBoxDomainValues.Location = new System.Drawing.Point(4, 19);
            this.lstBoxDomainValues.Name = "lstBoxDomainValues";
            this.lstBoxDomainValues.Size = new System.Drawing.Size(411, 139);
            this.lstBoxDomainValues.TabIndex = 1;
            this.lstBoxDomainValues.SelectedIndexChanged += new System.EventHandler(this.lstBoxDomainValues_SelectedIndexChanged);
            // 
            // EditDomainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 336);
            this.Controls.Add(this.panelDomainOperations);
            this.Controls.Add(this.gbDomainValues);
            this.Controls.Add(this.gbDomainName);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDomainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание домена";
            this.gbDomainName.ResumeLayout(false);
            this.gbDomainName.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.gbDomainValues.ResumeLayout(false);
            this.panelDomainOperations.ResumeLayout(false);
            this.panelDomainOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDomainName;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbDomainValues;
        private System.Windows.Forms.Button btnDelDomainValue;
        private System.Windows.Forms.Panel panelDomainOperations;
        private System.Windows.Forms.TextBox tbDomainValue;
        private System.Windows.Forms.Button btnEditDomainValue;
        private EnhancedListBox.DragDropListBox lstBoxDomainValues;
    }
}