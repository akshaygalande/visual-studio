namespace QPGS
{
    partial class PrincipleMainForm
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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapterMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classSubjectMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classExamMAppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperMastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateQuestionPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.mappingToolStripMenuItem,
            this.paperMastersToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classMasterToolStripMenuItem,
            this.subjectMasterToolStripMenuItem,
            this.examMasterToolStripMenuItem,
            this.chapterMasterToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.masterToolStripMenuItem.Text = "&Master";
            // 
            // classMasterToolStripMenuItem
            // 
            this.classMasterToolStripMenuItem.Name = "classMasterToolStripMenuItem";
            this.classMasterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.classMasterToolStripMenuItem.Text = "&Class Master";
            this.classMasterToolStripMenuItem.Click += new System.EventHandler(this.classMasterToolStripMenuItem_Click);
            // 
            // subjectMasterToolStripMenuItem
            // 
            this.subjectMasterToolStripMenuItem.Name = "subjectMasterToolStripMenuItem";
            this.subjectMasterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.subjectMasterToolStripMenuItem.Text = "&Subject Master";
            this.subjectMasterToolStripMenuItem.Click += new System.EventHandler(this.subjectMasterToolStripMenuItem_Click);
            // 
            // examMasterToolStripMenuItem
            // 
            this.examMasterToolStripMenuItem.Name = "examMasterToolStripMenuItem";
            this.examMasterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.examMasterToolStripMenuItem.Text = "Exam Master";
            this.examMasterToolStripMenuItem.Click += new System.EventHandler(this.examMasterToolStripMenuItem_Click);
            // 
            // chapterMasterToolStripMenuItem
            // 
            this.chapterMasterToolStripMenuItem.Name = "chapterMasterToolStripMenuItem";
            this.chapterMasterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.chapterMasterToolStripMenuItem.Text = "Chapter Master";
            this.chapterMasterToolStripMenuItem.Click += new System.EventHandler(this.chapterMasterToolStripMenuItem_Click);
            // 
            // mappingToolStripMenuItem
            // 
            this.mappingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classSubjectMappingToolStripMenuItem,
            this.classExamMAppingToolStripMenuItem});
            this.mappingToolStripMenuItem.Name = "mappingToolStripMenuItem";
            this.mappingToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.mappingToolStripMenuItem.Text = "Mapping";
            // 
            // classSubjectMappingToolStripMenuItem
            // 
            this.classSubjectMappingToolStripMenuItem.Name = "classSubjectMappingToolStripMenuItem";
            this.classSubjectMappingToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.classSubjectMappingToolStripMenuItem.Text = "Class Subject Mapping";
            this.classSubjectMappingToolStripMenuItem.Click += new System.EventHandler(this.classSubjectMappingToolStripMenuItem_Click_1);
            // 
            // classExamMAppingToolStripMenuItem
            // 
            this.classExamMAppingToolStripMenuItem.Name = "classExamMAppingToolStripMenuItem";
            this.classExamMAppingToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.classExamMAppingToolStripMenuItem.Text = "Class Exam MApping";
            this.classExamMAppingToolStripMenuItem.Click += new System.EventHandler(this.classExamMAppingToolStripMenuItem_Click);
            // 
            // paperMastersToolStripMenuItem
            // 
            this.paperMastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionsToolStripMenuItem,
            this.generateQuestionPaperToolStripMenuItem});
            this.paperMastersToolStripMenuItem.Name = "paperMastersToolStripMenuItem";
            this.paperMastersToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.paperMastersToolStripMenuItem.Text = "Paper Masters";
            this.paperMastersToolStripMenuItem.Click += new System.EventHandler(this.paperMastersToolStripMenuItem_Click);
            // 
            // addQuestionsToolStripMenuItem
            // 
            this.addQuestionsToolStripMenuItem.Name = "addQuestionsToolStripMenuItem";
            this.addQuestionsToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.addQuestionsToolStripMenuItem.Text = "Add Questions";
            this.addQuestionsToolStripMenuItem.Click += new System.EventHandler(this.addQuestionsToolStripMenuItem_Click);
            // 
            // generateQuestionPaperToolStripMenuItem
            // 
            this.generateQuestionPaperToolStripMenuItem.Name = "generateQuestionPaperToolStripMenuItem";
            this.generateQuestionPaperToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.generateQuestionPaperToolStripMenuItem.Text = "Generate Question Paper";
            this.generateQuestionPaperToolStripMenuItem.Click += new System.EventHandler(this.generateQuestionPaperToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.usersToolStripMenuItem.Text = "Manage Accounts";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // PrincipleMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(726, 438);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipleMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipleMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipleMainForm_FormClosing);
            this.Load += new System.EventHandler(this.PrincipleMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paperMastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classSubjectMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classExamMAppingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateQuestionPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapterMasterToolStripMenuItem;


    }
}