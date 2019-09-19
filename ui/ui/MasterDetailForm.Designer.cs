namespace ui
{
    partial class MasterDetailForm
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
            this._listBoxProductNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _listBoxProductNames
            // 
            this._listBoxProductNames.DisplayMember = "Name";
            this._listBoxProductNames.Dock = System.Windows.Forms.DockStyle.Left;
            this._listBoxProductNames.FormattingEnabled = true;
            this._listBoxProductNames.Location = new System.Drawing.Point(0, 0);
            this._listBoxProductNames.Name = "_listBoxProductNames";
            this._listBoxProductNames.Size = new System.Drawing.Size(272, 696);
            this._listBoxProductNames.TabIndex = 0;
            this._listBoxProductNames.SelectedValueChanged += new System.EventHandler(this.ListBoxProductNames_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(368, 83);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.ReadOnly = true;
            this._textBoxName.Size = new System.Drawing.Size(403, 20);
            this._textBoxName.TabIndex = 3;
            // 
            // _textBoxDescription
            // 
            this._textBoxDescription.Location = new System.Drawing.Point(368, 156);
            this._textBoxDescription.Multiline = true;
            this._textBoxDescription.Name = "_textBoxDescription";
            this._textBoxDescription.ReadOnly = true;
            this._textBoxDescription.Size = new System.Drawing.Size(403, 220);
            this._textBoxDescription.TabIndex = 4;
            // 
            // MasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 696);
            this.Controls.Add(this._textBoxDescription);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._listBoxProductNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MasterDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.MasterDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBoxProductNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.TextBox _textBoxDescription;
    }
}

