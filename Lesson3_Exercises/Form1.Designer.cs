namespace Lesson3_Exercises
{
    partial class print
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
            this.printdisplayListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printdisplayListbox
            // 
            this.printdisplayListbox.FormattingEnabled = true;
            this.printdisplayListbox.ItemHeight = 16;
            this.printdisplayListbox.Location = new System.Drawing.Point(30, 46);
            this.printdisplayListbox.Name = "printdisplayListbox";
            this.printdisplayListbox.Size = new System.Drawing.Size(423, 340);
            this.printdisplayListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 34);
            this.label1.TabIndex = 41;
            this.label1.Text = "KKoppi & Co. – Café • Cakes • Pasta";
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printdisplayListbox);
            this.Name = "print";
            this.Text = "Transaction Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox printdisplayListbox;
        private System.Windows.Forms.Label label1;
    }
}