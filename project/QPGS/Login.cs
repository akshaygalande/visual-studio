using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QPGS
{
    public partial class Login : Form
    {
        
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();

        public Login()
        {
            InitializeComponent();

            //cmbLoginAs = objfunc.LoadCombo(cmbLoginAs,"select Role_Name from Role");
            //cmbLoginAs.SelectedIndex = 0;
        }
        private bool validate()
        {
            bool valid = true;
            if (txtUsername.Text == "")
            {
                valid = false;
                txtUsername.BackColor = Color.Red;
            }
            else
            {
                txtUsername.BackColor = Color.White;
            }
            if (txtPassword.Text == "")
            {

                valid = false;
                txtPassword.BackColor = Color.Red;
            }
            else
            {
                txtPassword.BackColor = Color.White;
            }
           
            return valid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    string username = "", password = "",roleID="";
                    objcon.Open();
                    string query = "select User_Username,User_Password,User_Role_Id from tbl_User where User_Username='" + txtUsername.Text + "' and User_Password='" + txtPassword.Text + "' ";
                    objcon.cmd.CommandText = query;
                    objcon.reader = objcon.cmd.ExecuteReader();
                    if (objcon.reader.Read())
                    {
                        username = objcon.reader.GetValue(0).ToString();
                        password = objcon.reader.GetValue(1).ToString();
                        roleID = objcon.reader.GetValue(2).ToString();

                    }
                    objcon.reader.Close();
                    objcon.Close();
                    if (username == txtUsername.Text && password == txtPassword.Text)
                    {
                        switch (roleID)
                        {
                            case "1": PrincipleMainForm obj = new PrincipleMainForm();
                                this.Hide();
                                obj.Show();
                                break;
                            
                            case "2": StaffMainForm obj2 = new StaffMainForm();
                                this.Hide();
                                obj2.Show();
                                break;

                            case "3": Operator_main_form obj1 = new Operator_main_form();
                                this.Hide();
                                obj1.Show();
                                break;
                        }


                    }
                    else
                    {
                        MessageBox.Show("Username or Password are incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void lblfrgtpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recover_Password obj = new Recover_Password();
            this.Hide();
            obj.Show();

        }
    }
}
