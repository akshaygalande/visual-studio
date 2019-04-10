namespace QPGS
{
    partial class Recover_Password
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbsecurityq = new System.Windows.Forms.ComboBox();
            this.txtsecurityans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(292, 24);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(337, 23);
            this.txtuname.TabIndex = 5;
            this.txtuname.TextChanged += new System.EventHandler(this.txtuname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select your security Question";
            // 
            // cmbrole
            // 
            this.cmbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(292, 66);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(337, 24);
            this.cmbrole.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select your Role";
            // 
            // cmbsecurityq
            // 
            this.cmbsecurityq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsecurityq.FormattingEnabled = true;
            this.cmbsecurityq.Location = new System.Drawing.Point(292, 112);
            this.cmbsecurityq.Name = "cmbsecurityq";
            this.cmbsecurityq.Size = new System.Drawing.Size(337, 24);
            this.cmbsecurityq.TabIndex = 9;
            // 
            // txtsecurityans
            // 
            this.txtsecurityans.Location = new System.Drawing.Point(292, 161);
            this.txtsecurityans.Name = "txtsecurityans";
            this.txtsecurityans.Size = new System.Drawing.Size(337, 23);
            this.txtsecurityans.TabIndex = 10;
            this.txtsecurityans.TextChanged += new System.EventHandler(this.txtsecurityans_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter your answer for Security Question";
            // 
            // btnsubmit
            // 
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.Location = new System.Drawing.Point(260, 218);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 12;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Recover_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(645, 253);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsecurityans);
            this.Controls.Add(this.cmbsecurityq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Recover_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover_Password";
            this.Load += new System.EventHandler(this.Recover_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbsecurityq;
        private System.Windows.Forms.TextBox txtsecurityans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsubmit;
    }
}