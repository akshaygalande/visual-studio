namespace QPGS
{
    partial class AddQuestion
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
            this.components = new System.ComponentModel.Container();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbQuetype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbChapter = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.optiona = new System.Windows.Forms.TextBox();
            this.optionb = new System.Windows.Forms.TextBox();
            this.optionc = new System.Windows.Forms.TextBox();
            this.optiond = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mcqgroup = new System.Windows.Forms.GroupBox();
            this.mcqgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(169, 25);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(347, 24);
            this.cmbClass.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbClass, "Select Class or Standard");
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Question Type";
            // 
            // cmbQuetype
            // 
            this.cmbQuetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuetype.FormattingEnabled = true;
            this.cmbQuetype.Location = new System.Drawing.Point(169, 180);
            this.cmbQuetype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuetype.Name = "cmbQuetype";
            this.cmbQuetype.Size = new System.Drawing.Size(347, 24);
            this.cmbQuetype.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cmbQuetype, "Select Question Type");
            this.cmbQuetype.SelectedIndexChanged += new System.EventHandler(this.cmbQueType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(169, 233);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(347, 117);
            this.txtQuestion.TabIndex = 8;
            this.txtQuestion.Text = "";
            this.toolTip1.SetToolTip(this.txtQuestion, "Enter question here");
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lavender;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(197, 581);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(117, 43);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Lavender;
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(338, 581);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(119, 43);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancle";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chapter";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(169, 82);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(347, 24);
            this.cmbSubject.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbSubject, "Select Subject");
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // cmbChapter
            // 
            this.cmbChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChapter.FormattingEnabled = true;
            this.cmbChapter.Location = new System.Drawing.Point(170, 131);
            this.cmbChapter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChapter.Name = "cmbChapter";
            this.cmbChapter.Size = new System.Drawing.Size(347, 24);
            this.cmbChapter.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmbChapter, "Select Chapter");
            this.cmbChapter.SelectedIndexChanged += new System.EventHandler(this.cmbChapter_SelectedIndexChanged_1);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // optiona
            // 
            this.optiona.Location = new System.Drawing.Point(131, 31);
            this.optiona.Margin = new System.Windows.Forms.Padding(4);
            this.optiona.Name = "optiona";
            this.optiona.Size = new System.Drawing.Size(285, 23);
            this.optiona.TabIndex = 4;
            this.toolTip1.SetToolTip(this.optiona, "Enter 1st option");
            // 
            // optionb
            // 
            this.optionb.Location = new System.Drawing.Point(131, 69);
            this.optionb.Margin = new System.Windows.Forms.Padding(4);
            this.optionb.Name = "optionb";
            this.optionb.Size = new System.Drawing.Size(285, 23);
            this.optionb.TabIndex = 5;
            this.toolTip1.SetToolTip(this.optionb, "Enter 2nd option");
            // 
            // optionc
            // 
            this.optionc.Location = new System.Drawing.Point(131, 107);
            this.optionc.Margin = new System.Windows.Forms.Padding(4);
            this.optionc.Name = "optionc";
            this.optionc.Size = new System.Drawing.Size(285, 23);
            this.optionc.TabIndex = 6;
            this.toolTip1.SetToolTip(this.optionc, "Enter 3rd option");
            // 
            // optiond
            // 
            this.optiond.Location = new System.Drawing.Point(131, 142);
            this.optiond.Margin = new System.Windows.Forms.Padding(4);
            this.optiond.Name = "optiond";
            this.optiond.Size = new System.Drawing.Size(285, 23);
            this.optiond.TabIndex = 7;
            this.toolTip1.SetToolTip(this.optiond, "Enter 4th option");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Option A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Option B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Option C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Option D";
            // 
            // mcqgroup
            // 
            this.mcqgroup.Controls.Add(this.optiond);
            this.mcqgroup.Controls.Add(this.optionc);
            this.mcqgroup.Controls.Add(this.optionb);
            this.mcqgroup.Controls.Add(this.optiona);
            this.mcqgroup.Controls.Add(this.label9);
            this.mcqgroup.Controls.Add(this.label8);
            this.mcqgroup.Controls.Add(this.label7);
            this.mcqgroup.Controls.Add(this.label5);
            this.mcqgroup.Location = new System.Drawing.Point(39, 392);
            this.mcqgroup.Margin = new System.Windows.Forms.Padding(4);
            this.mcqgroup.Name = "mcqgroup";
            this.mcqgroup.Padding = new System.Windows.Forms.Padding(4);
            this.mcqgroup.Size = new System.Drawing.Size(481, 177);
            this.mcqgroup.TabIndex = 16;
            this.mcqgroup.TabStop = false;
            this.mcqgroup.Text = "For MCQ only";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(577, 629);
            this.Controls.Add(this.mcqgroup);
            this.Controls.Add(this.cmbChapter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbQuetype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbClass);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestion";
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            this.mcqgroup.ResumeLayout(false);
            this.mcqgroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbQuetype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbChapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox optiona;
        private System.Windows.Forms.TextBox optionb;
        private System.Windows.Forms.TextBox optionc;
        private System.Windows.Forms.TextBox optiond;
        private System.Windows.Forms.GroupBox mcqgroup;
    }
}