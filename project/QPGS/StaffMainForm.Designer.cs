namespace QPGS
{
    partial class StaffMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generateQuestionPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateQuestionPaperToolStripMenuItem,
            this.addQuestionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateQuestionPaperToolStripMenuItem
            // 
            this.generateQuestionPaperToolStripMenuItem.Name = "generateQuestionPaperToolStripMenuItem";
            this.generateQuestionPaperToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.generateQuestionPaperToolStripMenuItem.Text = "Generate Question Paper";
            this.generateQuestionPaperToolStripMenuItem.Click += new System.EventHandler(this.generateQuestionPaperToolStripMenuItem_Click);
            // 
            // addQuestionsToolStripMenuItem
            // 
            this.addQuestionsToolStripMenuItem.Name = "addQuestionsToolStripMenuItem";
            this.addQuestionsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.addQuestionsToolStripMenuItem.Text = "Add Questions";
            this.addQuestionsToolStripMenuItem.Click += new System.EventHandler(this.addQuestionsToolStripMenuItem_Click);
            // 
            // StaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 537);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateQuestionPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionsToolStripMenuItem;
    }
}