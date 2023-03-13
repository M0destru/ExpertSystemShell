namespace ExpertSystemShell.UI
{
    partial class ExplanationForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.panelRules = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.lblRules = new System.Windows.Forms.Label();
            this.panelVariables = new System.Windows.Forms.Panel();
            this.lstViewVariables = new System.Windows.Forms.ListView();
            this.columnVarName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVarValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblVariables = new System.Windows.Forms.Label();
            this.panelTitles = new System.Windows.Forms.Panel();
            this.labelHideTree = new System.Windows.Forms.Label();
            this.panelRules.SuspendLayout();
            this.panelVariables.SuspendLayout();
            this.panelTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRules
            // 
            this.panelRules.Controls.Add(this.treeView);
            this.panelRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRules.Location = new System.Drawing.Point(0, 32);
            this.panelRules.Margin = new System.Windows.Forms.Padding(4);
            this.panelRules.Name = "panelRules";
            this.panelRules.Size = new System.Drawing.Size(939, 413);
            this.panelRules.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.FullRowSelect = true;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(939, 413);
            this.treeView.TabIndex = 1;
            this.treeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCollapse);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // lblRules
            // 
            this.lblRules.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRules.Location = new System.Drawing.Point(0, 0);
            this.lblRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblRules.Size = new System.Drawing.Size(68, 32);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = "Правила";
            // 
            // panelVariables
            // 
            this.panelVariables.Controls.Add(this.lstViewVariables);
            this.panelVariables.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVariables.Location = new System.Drawing.Point(621, 32);
            this.panelVariables.Margin = new System.Windows.Forms.Padding(4);
            this.panelVariables.Name = "panelVariables";
            this.panelVariables.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelVariables.Size = new System.Drawing.Size(318, 413);
            this.panelVariables.TabIndex = 1;
            // 
            // lstViewVariables
            // 
            this.lstViewVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVarName,
            this.columnVarValue});
            this.lstViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewVariables.FullRowSelect = true;
            this.lstViewVariables.GridLines = true;
            this.lstViewVariables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewVariables.HideSelection = false;
            this.lstViewVariables.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lstViewVariables.Location = new System.Drawing.Point(4, 0);
            this.lstViewVariables.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewVariables.Name = "lstViewVariables";
            this.lstViewVariables.Size = new System.Drawing.Size(314, 413);
            this.lstViewVariables.TabIndex = 0;
            this.lstViewVariables.UseCompatibleStateImageBehavior = false;
            this.lstViewVariables.View = System.Windows.Forms.View.Details;
            // 
            // columnVarName
            // 
            this.columnVarName.Text = "Имя";
            this.columnVarName.Width = 122;
            // 
            // columnVarValue
            // 
            this.columnVarValue.Text = "Значение";
            this.columnVarValue.Width = 241;
            // 
            // lblVariables
            // 
            this.lblVariables.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVariables.Location = new System.Drawing.Point(842, 0);
            this.lblVariables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblVariables.Size = new System.Drawing.Size(97, 32);
            this.lblVariables.TabIndex = 1;
            this.lblVariables.Text = "Переменные";
            // 
            // panelTitles
            // 
            this.panelTitles.Controls.Add(this.labelHideTree);
            this.panelTitles.Controls.Add(this.lblRules);
            this.panelTitles.Controls.Add(this.lblVariables);
            this.panelTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitles.Location = new System.Drawing.Point(0, 0);
            this.panelTitles.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitles.Name = "panelTitles";
            this.panelTitles.Size = new System.Drawing.Size(939, 32);
            this.panelTitles.TabIndex = 2;
            // 
            // labelHideTree
            // 
            this.labelHideTree.AutoSize = true;
            this.labelHideTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHideTree.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHideTree.Location = new System.Drawing.Point(64, 10);
            this.labelHideTree.Name = "labelHideTree";
            this.labelHideTree.Size = new System.Drawing.Size(86, 16);
            this.labelHideTree.TabIndex = 2;
            this.labelHideTree.Text = "(скрыть все)";
            this.labelHideTree.Click += new System.EventHandler(this.labelHideTree_Click);
            // 
            // ExplanationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 445);
            this.Controls.Add(this.panelVariables);
            this.Controls.Add(this.panelRules);
            this.Controls.Add(this.panelTitles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExplanationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Объяснение";
            this.panelRules.ResumeLayout(false);
            this.panelVariables.ResumeLayout(false);
            this.panelTitles.ResumeLayout(false);
            this.panelTitles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRules;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Panel panelVariables;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.ListView lstViewVariables;
        private System.Windows.Forms.ColumnHeader columnVarName;
        private System.Windows.Forms.ColumnHeader columnVarValue;
        private System.Windows.Forms.Panel panelTitles;
        private System.Windows.Forms.Label labelHideTree;
    }
}