namespace Lesson3_Exercises
{
    partial class PrintForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.printListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 34);
            this.label1.TabIndex = 41;
            this.label1.Text = "KKoppi & Co. – Café • Cakes • Pasta";
            // 
            // printListbox
            // 
            this.printListbox.FormattingEnabled = true;
            this.printListbox.ItemHeight = 16;
            this.printListbox.Location = new System.Drawing.Point(12, 46);
            this.printListbox.Name = "printListbox";
            this.printListbox.Size = new System.Drawing.Size(496, 404);
            this.printListbox.TabIndex = 42;
            // 
            // PrintForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lesson3_Exercises.Properties.Resources._2e5ed7a03c1399634d33ae43d502dac71;
            this.ClientSize = new System.Drawing.Size(520, 462);
            this.Controls.Add(this.printListbox);
            this.Controls.Add(this.label1);
            this.Name = "PrintForm2";
            this.Text = "PrintForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox printListbox;
    }
}