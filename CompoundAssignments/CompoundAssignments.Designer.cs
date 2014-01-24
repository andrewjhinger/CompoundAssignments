namespace CompoundAssignments
{
    partial class CompoundAssignments
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
            this.seetingsGroupBox = new System.Windows.Forms.GroupBox();
            this.letterLabel = new System.Windows.Forms.Label();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.gridSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawGroupBox = new System.Windows.Forms.GroupBox();
            this.seetingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // seetingsGroupBox
            // 
            this.seetingsGroupBox.Controls.Add(this.letterLabel);
            this.seetingsGroupBox.Controls.Add(this.letterTextBox);
            this.seetingsGroupBox.Controls.Add(this.gridSizeComboBox);
            this.seetingsGroupBox.Controls.Add(this.label1);
            this.seetingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.seetingsGroupBox.Name = "seetingsGroupBox";
            this.seetingsGroupBox.Size = new System.Drawing.Size(268, 62);
            this.seetingsGroupBox.TabIndex = 0;
            this.seetingsGroupBox.TabStop = false;
            // 
            // letterLabel
            // 
            this.letterLabel.AutoSize = true;
            this.letterLabel.Location = new System.Drawing.Point(121, 24);
            this.letterLabel.Name = "letterLabel";
            this.letterLabel.Size = new System.Drawing.Size(37, 13);
            this.letterLabel.TabIndex = 3;
            this.letterLabel.Text = "Letter:";
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(162, 21);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(100, 20);
            this.letterTextBox.TabIndex = 2;
            this.letterTextBox.TextChanged += new System.EventHandler(this.letterTextBox_TextChanged);
            // 
            // gridSizeComboBox
            // 
            this.gridSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gridSizeComboBox.FormattingEnabled = true;
            this.gridSizeComboBox.Items.AddRange(new object[] {
            "4",
            "10",
            "20"});
            this.gridSizeComboBox.Location = new System.Drawing.Point(64, 21);
            this.gridSizeComboBox.Name = "gridSizeComboBox";
            this.gridSizeComboBox.Size = new System.Drawing.Size(51, 21);
            this.gridSizeComboBox.TabIndex = 1;
            this.gridSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.gridSizeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Size:";
            // 
            // drawGroupBox
            // 
            this.drawGroupBox.Location = new System.Drawing.Point(12, 95);
            this.drawGroupBox.Name = "drawGroupBox";
            this.drawGroupBox.Size = new System.Drawing.Size(268, 166);
            this.drawGroupBox.TabIndex = 1;
            this.drawGroupBox.TabStop = false;
            this.drawGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawGroupBox_Paint);
            // 
            // CompoundAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.drawGroupBox);
            this.Controls.Add(this.seetingsGroupBox);
            this.Name = "CompoundAssignments";
            this.Text = "CompoundAssignments";
            this.seetingsGroupBox.ResumeLayout(false);
            this.seetingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox seetingsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox drawGroupBox;
        private System.Windows.Forms.ComboBox gridSizeComboBox;
        private System.Windows.Forms.Label letterLabel;
        private System.Windows.Forms.TextBox letterTextBox;
    }
}

