namespace TicTacToe
{
    partial class FieldTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblField = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblField
            // 
            this.lblField.BackColor = System.Drawing.Color.Silver;
            this.lblField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblField.Location = new System.Drawing.Point(0, 0);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(150, 150);
            this.lblField.TabIndex = 0;
            this.lblField.Text = "?";
            this.lblField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField.Click += new System.EventHandler(this.lblField_Click);
            this.lblField.MouseEnter += new System.EventHandler(this.lblField_MouseEnter);
            this.lblField.MouseLeave += new System.EventHandler(this.lblField_MouseLeave);
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(8, 8);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(18, 20);
            this.lblPos.TabIndex = 1;
            this.lblPos.Text = "?";
            // 
            // FieldTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblField);
            this.Name = "FieldTile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblPos;
    }
}
