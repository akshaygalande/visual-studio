namespace QPGS
{
    partial class Generate_Question_Paper
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
            this.cmbexam = new System.Windows.Forms.ComboBox();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbqtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSubTitle = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.cmbmarks = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAddeddMarks = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnLoadQuestions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbexam
            // 
            this.cmbexam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbexam.FormattingEnabled = true;
            this.cmbexam.Items.AddRange(new object[] {
            "All",
            "English",
            "Hindi",
            "Marathi",
            "Science",
            "Maths",
            "History",
            "Geography"});
            this.cmbexam.Location = new System.Drawing.Point(189, 48);
            this.cmbexam.Margin = new System.Windows.Forms.Padding(4);
            this.cmbexam.Name = "cmbexam";
            this.cmbexam.Size = new System.Drawing.Size(329, 24);
            this.cmbexam.TabIndex = 20;
            this.toolTip1.SetToolTip(this.cmbexam, "Select Exam Type");
            this.cmbexam.SelectedIndexChanged += new System.EventHandler(this.cmbexam_SelectedIndexChanged);
            // 
            // cmbclass
            // 
            this.cmbclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "All",
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th",
            "9th",
            "10th"});
            this.cmbclass.Location = new System.Drawing.Point(189, 12);
            this.cmbclass.Margin = new System.Windows.Forms.Padding(4);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(329, 24);
            this.cmbclass.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cmbclass, "Select Class Type");
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Exam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Class";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "All",
            "English",
            "Hindi",
            "Marathi",
            "Science",
            "Maths",
            "History",
            "Geography"});
            this.cmbSubject.Location = new System.Drawing.Point(189, 85);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(329, 24);
            this.cmbSubject.TabIndex = 22;
            this.toolTip1.SetToolTip(this.cmbSubject, "Select Subject Type");
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            this.cmbSubject.TextChanged += new System.EventHandler(this.cmbSubject_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select Subject";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select Question Type";
            // 
            // cmbqtype
            // 
            this.cmbqtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbqtype.FormattingEnabled = true;
            this.cmbqtype.Items.AddRange(new object[] {
            "All",
            "English",
            "Hindi",
            "Marathi",
            "Science",
            "Maths",
            "History",
            "Geography"});
            this.cmbqtype.Location = new System.Drawing.Point(189, 119);
            this.cmbqtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbqtype.Name = "cmbqtype";
            this.cmbqtype.Size = new System.Drawing.Size(329, 24);
            this.cmbqtype.TabIndex = 27;
            this.toolTip1.SetToolTip(this.cmbqtype, "Select Question Type");
            this.cmbqtype.SelectedIndexChanged += new System.EventHandler(this.cmbqtype_SelectedIndexChanged);
            this.cmbqtype.SelectedValueChanged += new System.EventHandler(this.cmbqtype_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Select Chapter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Question No.";
            // 
            // txtQNo
            // 
            this.txtQNo.Location = new System.Drawing.Point(189, 329);
            this.txtQNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtQNo.Name = "txtQNo";
            this.txtQNo.Size = new System.Drawing.Size(130, 23);
            this.txtQNo.TabIndex = 30;
            this.toolTip1.SetToolTip(this.txtQNo, "Enter numer of Question in Question type");
            this.txtQNo.TextChanged += new System.EventHandler(this.txtQNo_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Select});
            this.dataGridView1.Location = new System.Drawing.Point(4, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(759, 241);
            this.dataGridView1.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Question_ID";
            this.Column1.HeaderText = "Qpq_ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Question";
            this.Column2.FillWeight = 179.6954F;
            this.Column2.HeaderText = "Question";
            this.Column2.Name = "Column2";
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Chk";
            this.Select.FalseValue = "0";
            this.Select.FillWeight = 20.30457F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.TrueValue = "1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // txtSubTitle
            // 
            this.txtSubTitle.Location = new System.Drawing.Point(406, 329);
            this.txtSubTitle.Name = "txtSubTitle";
            this.txtSubTitle.Size = new System.Drawing.Size(100, 23);
            this.txtSubTitle.TabIndex = 39;
            this.toolTip1.SetToolTip(this.txtSubTitle, "Remove Blankif there is no any sub title for question\r\n\r\nSub Title Exam.: 1 A\r\n  " +
                    "                           1 B");
            this.txtSubTitle.TextChanged += new System.EventHandler(this.txtSubTitle_TextChanged);
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(189, 366);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(329, 23);
            this.txttitle.TabIndex = 48;
            this.toolTip1.SetToolTip(this.txttitle, "Title for the question to be appeared on Question paper");
            // 
            // cmbmarks
            // 
            this.cmbmarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarks.FormattingEnabled = true;
            this.cmbmarks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbmarks.Location = new System.Drawing.Point(588, 369);
            this.cmbmarks.Name = "cmbmarks";
            this.cmbmarks.Size = new System.Drawing.Size(121, 24);
            this.cmbmarks.TabIndex = 50;
            this.toolTip1.SetToolTip(this.cmbmarks, "Marks for each selected question of above question type");
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(257, 398);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 26);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Location = new System.Drawing.Point(435, 398);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(78, 26);
            this.btnGenerate.TabIndex = 37;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sub Title";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(765, 683);
            this.shapeContainer1.TabIndex = 40;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(588, 23);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(156, 144);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Enter Total Marks";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(603, 56);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(121, 23);
            this.txtTotalMarks.TabIndex = 42;
            this.txtTotalMarks.TextChanged += new System.EventHandler(this.txtTotalMarks_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Added Marks";
            // 
            // lblAddeddMarks
            // 
            this.lblAddeddMarks.AutoSize = true;
            this.lblAddeddMarks.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddeddMarks.Location = new System.Drawing.Point(610, 125);
            this.lblAddeddMarks.Name = "lblAddeddMarks";
            this.lblAddeddMarks.Size = new System.Drawing.Size(24, 23);
            this.lblAddeddMarks.TabIndex = 44;
            this.lblAddeddMarks.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Enter Marks for this question type";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(579, 208);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(121, 23);
            this.txtMarks.TabIndex = 46;
            this.txtMarks.TextChanged += new System.EventHandler(this.txtMarks_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Enter Title for question";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Select marks for each question";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(189, 153);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(329, 130);
            this.checkedListBox1.TabIndex = 51;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnLoadQuestions
            // 
            this.btnLoadQuestions.AutoSize = true;
            this.btnLoadQuestions.Location = new System.Drawing.Point(189, 288);
            this.btnLoadQuestions.Name = "btnLoadQuestions";
            this.btnLoadQuestions.Size = new System.Drawing.Size(119, 26);
            this.btnLoadQuestions.TabIndex = 52;
            this.btnLoadQuestions.Text = "Load Questions";
            this.btnLoadQuestions.UseVisualStyleBackColor = true;
            this.btnLoadQuestions.Click += new System.EventHandler(this.btnLoadQuestions_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(340, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 53;
            this.button1.Text = "Clear Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Generate_Question_Paper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoadQuestions);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cmbmarks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAddeddMarks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbqtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbexam);
            this.Controls.Add(this.cmbclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Generate_Question_Paper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Paper Generator";
            this.Load += new System.EventHandler(this.Generate_Question_Paper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbexam;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbqtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox txtSubTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lblAddeddMarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.ComboBox cmbmarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnLoadQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button button1;
    }
}