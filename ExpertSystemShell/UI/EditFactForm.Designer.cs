namespace ExpertSystemShell.UI
{
    partial class EditFactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFactForm));
            this.cbVariable = new System.Windows.Forms.ComboBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.btnEditVariable = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVariable
            // 
            this.cbVariable.FormattingEnabled = true;
            this.cbVariable.Location = new System.Drawing.Point(55, 28);
            this.cbVariable.Margin = new System.Windows.Forms.Padding(4);
            this.cbVariable.Name = "cbVariable";
            this.cbVariable.Size = new System.Drawing.Size(328, 24);
            this.cbVariable.TabIndex = 0;
            this.cbVariable.SelectedIndexChanged += new System.EventHandler(this.cbVariable_SelectedIndexChanged);
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(55, 85);
            this.cbValue.Margin = new System.Windows.Forms.Padding(4);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(328, 24);
            this.cbValue.TabIndex = 1;
            this.cbValue.SelectedIndexChanged += new System.EventHandler(this.cbValue_SelectedIndexChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Controls.Add(this.btnOk);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 131);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(459, 36);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(355, 4);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVariable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddVariable.Image = ((System.Drawing.Image)(resources.GetObject("btnAddVariable.Image")));
            this.btnAddVariable.Location = new System.Drawing.Point(389, 27);
            this.btnAddVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(31, 26);
            this.btnAddVariable.TabIndex = 3;
            this.btnAddVariable.UseVisualStyleBackColor = false;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // btnEditVariable
            // 
            this.btnEditVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVariable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditVariable.Image = ((System.Drawing.Image)(resources.GetObject("btnEditVariable.Image")));
            this.btnEditVariable.Location = new System.Drawing.Point(424, 27);
            this.btnEditVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditVariable.Name = "btnEditVariable";
            this.btnEditVariable.Size = new System.Drawing.Size(31, 26);
            this.btnEditVariable.TabIndex = 4;
            this.btnEditVariable.UseVisualStyleBackColor = false;
            this.btnEditVariable.Click += new System.EventHandler(this.btnEditVariable_Click);
            // 
            // EditFactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 167);
            this.Controls.Add(this.btnEditVariable);
            this.Controls.Add(this.btnAddVariable);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.cbVariable);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFactForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление факта посылки";
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVariable;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAddVariable;
        private System.Windows.Forms.Button btnEditVariable;
    }
}