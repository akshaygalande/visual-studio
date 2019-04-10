namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.adminlbl = new System.Windows.Forms.Label();
            this.adminuserlbl = new System.Windows.Forms.Label();
            this.adminpasslbl = new System.Windows.Forms.Label();
            this.adminusertb = new System.Windows.Forms.TextBox();
            this.adminpasstb = new System.Windows.Forms.TextBox();
            this.adminsigninbtn = new System.Windows.Forms.Button();
            this.deolbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deousertb = new System.Windows.Forms.TextBox();
            this.deopasstb = new System.Windows.Forms.TextBox();
            this.deosigninbtn = new System.Windows.Forms.Button();
            this.qpglbl = new System.Windows.Forms.Label();
            this.qpguserlbl = new System.Windows.Forms.Label();
            this.qpgpasslbl = new System.Windows.Forms.Label();
            this.qpgusertb = new System.Windows.Forms.TextBox();
            this.qpgpasstb = new System.Windows.Forms.TextBox();
            this.qpgsigninbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminlbl
            // 
            this.adminlbl.AutoSize = true;
            this.adminlbl.Location = new System.Drawing.Point(500, 30);
            this.adminlbl.Name = "adminlbl";
            this.adminlbl.Size = new System.Drawing.Size(36, 13);
            this.adminlbl.TabIndex = 0;
            this.adminlbl.Text = "Admin";
            this.adminlbl.Click += new System.EventHandler(this.adminlbl_Click);
            // 
            // adminuserlbl
            // 
            this.adminuserlbl.AutoSize = true;
            this.adminuserlbl.Location = new System.Drawing.Point(442, 63);
            this.adminuserlbl.Name = "adminuserlbl";
            this.adminuserlbl.Size = new System.Drawing.Size(41, 13);
            this.adminuserlbl.TabIndex = 1;
            this.adminuserlbl.Text = "User Id";
            this.adminuserlbl.Click += new System.EventHandler(this.adminuserlbl_Click);
            // 
            // adminpasslbl
            // 
            this.adminpasslbl.AutoSize = true;
            this.adminpasslbl.Location = new System.Drawing.Point(442, 106);
            this.adminpasslbl.Name = "adminpasslbl";
            this.adminpasslbl.Size = new System.Drawing.Size(53, 13);
            this.adminpasslbl.TabIndex = 2;
            this.adminpasslbl.Text = "Password";
            this.adminpasslbl.Click += new System.EventHandler(this.adminpasslbl_Click);
            // 
            // adminusertb
            // 
            this.adminusertb.Location = new System.Drawing.Point(580, 63);
            this.adminusertb.Name = "adminusertb";
            this.adminusertb.Size = new System.Drawing.Size(100, 20);
            this.adminusertb.TabIndex = 3;
            // 
            // adminpasstb
            // 
            this.adminpasstb.Location = new System.Drawing.Point(580, 106);
            this.adminpasstb.Name = "adminpasstb";
            this.adminpasstb.Size = new System.Drawing.Size(100, 20);
            this.adminpasstb.TabIndex = 4;
            this.adminpasstb.TextChanged += new System.EventHandler(this.adminpasstb_TextChanged);
            // 
            // adminsigninbtn
            // 
            this.adminsigninbtn.FlatAppearance.BorderSize = 0;
            this.adminsigninbtn.Location = new System.Drawing.Point(492, 141);
            this.adminsigninbtn.Name = "adminsigninbtn";
            this.adminsigninbtn.Size = new System.Drawing.Size(75, 23);
            this.adminsigninbtn.TabIndex = 5;
            this.adminsigninbtn.Text = "Sign In";
            this.adminsigninbtn.UseVisualStyleBackColor = true;
            this.adminsigninbtn.Click += new System.EventHandler(this.adminsigninlbl_Click);
            // 
            // deolbl
            // 
            this.deolbl.AutoSize = true;
            this.deolbl.Location = new System.Drawing.Point(480, 196);
            this.deolbl.Name = "deolbl";
            this.deolbl.Size = new System.Drawing.Size(101, 13);
            this.deolbl.TabIndex = 6;
            this.deolbl.Text = "Data Entry Operator";
            this.deolbl.Click += new System.EventHandler(this.deolbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // deousertb
            // 
            this.deousertb.Location = new System.Drawing.Point(580, 232);
            this.deousertb.Name = "deousertb";
            this.deousertb.Size = new System.Drawing.Size(100, 20);
            this.deousertb.TabIndex = 9;
            // 
            // deopasstb
            // 
            this.deopasstb.Location = new System.Drawing.Point(580, 278);
            this.deopasstb.Name = "deopasstb";
            this.deopasstb.Size = new System.Drawing.Size(100, 20);
            this.deopasstb.TabIndex = 10;
            // 
            // deosigninbtn
            // 
            this.deosigninbtn.Location = new System.Drawing.Point(492, 316);
            this.deosigninbtn.Name = "deosigninbtn";
            this.deosigninbtn.Size = new System.Drawing.Size(75, 23);
            this.deosigninbtn.TabIndex = 11;
            this.deosigninbtn.Text = "Sign In";
            this.deosigninbtn.UseVisualStyleBackColor = true;
            // 
            // qpglbl
            // 
            this.qpglbl.AutoSize = true;
            this.qpglbl.Location = new System.Drawing.Point(470, 368);
            this.qpglbl.Name = "qpglbl";
            this.qpglbl.Size = new System.Drawing.Size(130, 13);
            this.qpglbl.TabIndex = 12;
            this.qpglbl.Text = "Question Paper Generator";
            // 
            // qpguserlbl
            // 
            this.qpguserlbl.AutoSize = true;
            this.qpguserlbl.Location = new System.Drawing.Point(442, 410);
            this.qpguserlbl.Name = "qpguserlbl";
            this.qpguserlbl.Size = new System.Drawing.Size(41, 13);
            this.qpguserlbl.TabIndex = 13;
            this.qpguserlbl.Text = "User Id";
            // 
            // qpgpasslbl
            // 
            this.qpgpasslbl.AutoSize = true;
            this.qpgpasslbl.Location = new System.Drawing.Point(442, 457);
            this.qpgpasslbl.Name = "qpgpasslbl";
            this.qpgpasslbl.Size = new System.Drawing.Size(53, 13);
            this.qpgpasslbl.TabIndex = 14;
            this.qpgpasslbl.Text = "Password";
            // 
            // qpgusertb
            // 
            this.qpgusertb.Location = new System.Drawing.Point(580, 407);
            this.qpgusertb.Name = "qpgusertb";
            this.qpgusertb.Size = new System.Drawing.Size(100, 20);
            this.qpgusertb.TabIndex = 15;
            // 
            // qpgpasstb
            // 
            this.qpgpasstb.Location = new System.Drawing.Point(580, 457);
            this.qpgpasstb.Name = "qpgpasstb";
            this.qpgpasstb.Size = new System.Drawing.Size(100, 20);
            this.qpgpasstb.TabIndex = 16;
            // 
            // qpgsigninbtn
            // 
            this.qpgsigninbtn.Location = new System.Drawing.Point(492, 486);
            this.qpgsigninbtn.Name = "qpgsigninbtn";
            this.qpgsigninbtn.Size = new System.Drawing.Size(75, 23);
            this.qpgsigninbtn.TabIndex = 17;
            this.qpgsigninbtn.Text = "Sign In";
            this.qpgsigninbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 521);
            this.Controls.Add(this.qpgsigninbtn);
            this.Controls.Add(this.qpgpasstb);
            this.Controls.Add(this.qpgusertb);
            this.Controls.Add(this.qpgpasslbl);
            this.Controls.Add(this.qpguserlbl);
            this.Controls.Add(this.qpglbl);
            this.Controls.Add(this.deosigninbtn);
            this.Controls.Add(this.deopasstb);
            this.Controls.Add(this.deousertb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deolbl);
            this.Controls.Add(this.adminsigninbtn);
            this.Controls.Add(this.adminpasstb);
            this.Controls.Add(this.adminusertb);
            this.Controls.Add(this.adminpasslbl);
            this.Controls.Add(this.adminuserlbl);
            this.Controls.Add(this.adminlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminlbl;
        private System.Windows.Forms.Label adminuserlbl;
        private System.Windows.Forms.Label adminpasslbl;
        private System.Windows.Forms.TextBox adminusertb;
        private System.Windows.Forms.TextBox adminpasstb;
        private System.Windows.Forms.Button adminsigninbtn;
        private System.Windows.Forms.Label deolbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deousertb;
        private System.Windows.Forms.TextBox deopasstb;
        private System.Windows.Forms.Button deosigninbtn;
        private System.Windows.Forms.Label qpglbl;
        private System.Windows.Forms.Label qpguserlbl;
        private System.Windows.Forms.Label qpgpasslbl;
        private System.Windows.Forms.TextBox qpgusertb;
        private System.Windows.Forms.TextBox qpgpasstb;
        private System.Windows.Forms.Button qpgsigninbtn;
    }
}

