using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QPGS
{
    public partial class Recover_Password : Form
    {
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        static int roleid = 0;
       // int password;

        public Recover_Password()
        {
            InitializeComponent();
        }

        private void Recover_Password_Load(object sender, EventArgs e)
        {
            objfunc.LoadCombo(cmbrole, "Select Role_Name from Role");
            objfunc.LoadCombo(cmbsecurityq, "select Security_Question from SQ_Table");
        }


        private bool validate()
        {
            bool valid = true;
            if (txtuname.Text == "")
            {
                valid = false;
                txtuname.BackColor = Color.Red;
            }
            else
            {
                txtuname.BackColor = Color.White;
            }
            if (cmbrole.Text == "")
            {
                valid = false;
                cmbrole.BackColor = Color.Red;
            }
            else
            {
                cmbrole.BackColor = Color.White;
            }
            if (cmbsecurityq.Text == "")
            {
                valid = false;
                cmbsecurityq.BackColor = Color.Red;
            }
            else
            {
                cmbsecurityq.BackColor = Color.White;
            }
            if (txtsecurityans.Text == "")
            {
                valid = false;
                txtsecurityans.BackColor = Color.Red;
            }
            else
            {
                txtsecurityans.BackColor = Color.White;
            }
            return valid;
        }

        


        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //SqlDataReader reader;

            if (validate())
                {
                    roleid = objfunc.GetId("select Role_Id from Role where  Role_Name='" + cmbrole.Text + "'");

                    string que="", ans="",password="";

                    objcon.Open();
                    string query = "select Security_Question, Security_Answer,User_Password from tbl_User where User_Username='" + txtuname.Text + "'  ";
                    objcon.cmd.CommandText = query;
                    objcon.reader = objcon.cmd.ExecuteReader();
                    if (objcon.reader.Read())
                    {
                        que = objcon.reader.GetValue(0).ToString();
                        ans = objcon.reader.GetValue(1).ToString();
                        password =objcon.reader.GetValue(2).ToString();
                    }
                    objcon.reader.Close();
                    objcon.Close();

                    if (cmbsecurityq.Text == que && ans == txtsecurityans.Text)
                    {
                        MessageBox.Show("Your Password is :" + password);

                    }
                    else
                    {

                    }

                    Login obj = new Login();
                    this.Hide();
                    obj.Show();


                   //// string query = "select User_Password from tbl_User where(User_Username=" + txtuname + " and User_Role_Id=" + roleid + " and Security_Question=" + cmbsecurityq + " and Security_Answer="+txtsecurityans+")";
                   // //objcon.cmd.CommandText = "select User_Password from tbl_User where(User_Username='" + txtuname.Text + "' and User_Role_Id=" + roleid + " and Security_Question='" + cmbsecurityq.Text + "' and Security_Answer='" + txtsecurityans.Text + "')";
                   // objcon.reader = objcon.cmd.ExecuteReader();
                   // if (objcon.reader.Read())
                   // {
                   //     password = Convert.ToInt32(objcon.reader.GetValue(0));
                   // }
                   // objcon.reader.Close();
                   // objcon.Close();
            }
            else
            {
                MessageBox.Show("Enter Values");
            }
           
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtuname.Text)
            {
                if (char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtuname.Text = str;
                    txtuname.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Letters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtsecurityans_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtsecurityans.Text)
            {
                if (char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtsecurityans.Text = str;
                    txtsecurityans.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Letters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
