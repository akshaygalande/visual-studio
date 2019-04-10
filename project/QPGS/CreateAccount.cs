using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QPGS
{
    public partial class CreateAccount : Form
    {
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        static int roleid =0;
        string operation = "",userid="";
        //string dupaccount;
        public CreateAccount()
        {
            InitializeComponent();
            cmbRole = objfunc.LoadCombo(cmbRole,"select Role_Name from Role");
            operation = "Save";
        }

        public CreateAccount(string id)
        {
            InitializeComponent();
            userid = id;
            cmbRole = objfunc.LoadCombo(cmbRole, "select Role_Name from Role");
            string query = "select User_FName,User_LName,User_EmailId,User_Address,User_ConatctNo,User_Username,User_Password,Role_Name from tbl_User inner join  Role on tbl_User.User_Role_Id =Role.Role_Id where User_Id=" + id + "";
            btnSave.Text = "Update";
            //btnSave.BackgroundImage= Properties.Resources.button_update;
            objcon.Open();
            objcon.cmd.CommandText = query;
            objcon.reader = objcon.cmd.ExecuteReader();

            if (objcon.reader.Read())
            {
                txtFirstName.Text = objcon.reader.GetValue(0).ToString();
                txtLastName.Text = objcon.reader.GetValue(1).ToString();
                txtEmailId.Text = objcon.reader.GetValue(2).ToString();
                 txtAddress.Text = objcon.reader.GetValue(3).ToString();
                 txtContact.Text = objcon.reader.GetValue(4).ToString();
                 txtUsername.Text = objcon.reader.GetValue(5).ToString();
                 txtPasword.Text = objcon.reader.GetValue(6).ToString();
                 cmbRole.Text = objcon.reader.GetValue(7).ToString();
            }
            objcon.reader.Close();
            objcon.Close();

            txtUsername.Enabled = false;
            cmbRole.Enabled = false;

        }


        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            roleid = objfunc.GetId("select Role_Id from Role where  Role_Name='"+cmbRole.Text+"'");
        }

        private bool validate()
        {
            bool valid = true;
            if (txtFirstName.Text == "")
            {
                valid = false;
                txtFirstName.BackColor = Color.Red;
            }
            else
            {
                txtFirstName.BackColor = Color.White;
            }
            if (txtLastName.Text == "")
            {

                valid = false;
                txtLastName.BackColor = Color.Red;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }

            if (txtEmailId.Text == "")
            {
                valid = false;
                txtEmailId.BackColor = Color.Red;
            }
            else
            {
                txtEmailId.BackColor = Color.White;
            }
            if (txtAddress.Text == "")
            {
                valid = false;
                txtAddress.BackColor = Color.Red;
            }
            else
            {
                txtAddress.BackColor = Color.White;
            }
            if (txtContact.Text == "")
            {
                valid = false;
                txtContact.BackColor = Color.Red;
            }
            else
            {
                txtContact.BackColor = Color.White;
            }
            if (cmbRole.Text == "")
            {
                valid = false;
                cmbRole.BackColor = Color.Red;
            }
            else
            {
                cmbRole.BackColor = Color.White;
            }
            if (txtUsername.Text == "")
            {
                valid = false;
                txtUsername.BackColor = Color.Red;
            }
            else
            {
                txtUsername.BackColor = Color.White;
            }
            if (txtPasword.Text == "")
            {
                valid = false;
                txtPasword.BackColor = Color.Red;
            }
            else
            {
                txtPasword.BackColor = Color.White;
            }
            //if (Convert.ToBoolean(btnSave.Text = "Save"))
            //{
            //    if (cmbsecurityQ.Text == "")
            //    {
            //        valid = false;
            //        cmbsecurityQ.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        cmbsecurityQ.BackColor = Color.White;
            //    }
            //    if (txtsecurityans.Text == "")
            //    {
            //        valid = false;
            //        txtsecurityans.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        txtsecurityans.BackColor = Color.White;
            //    }
            //}

           
            return valid;
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            try
            {

                if (validate())
                {
                    if (btnSave.Text == "Save")
                    {
                        
                       
                        if (objfunc.CheckDup("select User_Username from tbl_User where User_Username ='" + txtUsername.Text + "'"))
                        {
                            MessageBox.Show("Username already assigned for another user");
                        }
                        else
                        {
                            string query = "insert into tbl_User values(@fname,@lname,@email,@address,@contact,@username,@password,@roleid,@SecurityQue,@SecurityAns)";
                            objcon.Open();
                            objcon.cmd.CommandText = query;
                            objcon.cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                            objcon.cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                            objcon.cmd.Parameters.AddWithValue("@email", txtEmailId.Text);
                            objcon.cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                            objcon.cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                            objcon.cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            objcon.cmd.Parameters.AddWithValue("@password", txtPasword.Text);
                            objcon.cmd.Parameters.AddWithValue("@roleid", roleid);
                            objcon.cmd.Parameters.AddWithValue("@SecurityQue", cmbsecurityQ.Text);
                            objcon.cmd.Parameters.AddWithValue("@SecurityAns", txtsecurityans.Text);
                            objcon.cmd.ExecuteNonQuery();
                            objcon.Close();
                            MessageBox.Show("Data Saved Sucessfully...");
                            objfunc.CleanForm(this);
                        }
                       
                    }
                    else
                    {

                        cmbsecurityQ.Enabled = false;
                        txtsecurityans.Enabled = false;
 
                        roleid = objfunc.GetId("select Role_Id from Role where  Role_Name='" + cmbRole.Text + "'");
                        string query = " Update tbl_User set User_FName=@fname, User_LName= @lname, User_EmailId=@email,User_Address= @address, User_ConatctNo= @contact, User_Password=@password,User_Role_Id=@roleid where User_Id=" + userid + "";
                        objcon.Open();
                        objcon.cmd.CommandText = query;
                        objcon.cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                        objcon.cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                        objcon.cmd.Parameters.AddWithValue("@email", txtEmailId.Text);
                        objcon.cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        objcon.cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        objcon.cmd.Parameters.AddWithValue("@password", txtPasword.Text);
                        objcon.cmd.Parameters.AddWithValue("@roleid", roleid);
                        objcon.cmd.ExecuteNonQuery();
                        objcon.Close();
                        MessageBox.Show("Data Saved Sucessfully...");
                        objfunc.CleanForm(this);
                        cmbsecurityQ.Enabled = true;
                        txtsecurityans.Enabled = true;

                    }

                }
                else
                {
                    MessageBox.Show("Enter Values..");
                }
            }
            //}

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount obj = new CreateAccount();
            this.Hide();
            obj.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

            if (btnSave.Text == "Update")
            {
                cmbsecurityQ.Enabled = false;
                txtsecurityans.Enabled = false;
            }
            else
            {
                cmbsecurityQ = objfunc.LoadCombo(cmbsecurityQ, "Select Security_Question from SQ_Table");
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
             string str = "";
            foreach (char character in txtFirstName.Text)
            {
                if (char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtFirstName.Text = str;
                    txtFirstName.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Letters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLastName_TextChanged_1(object sender, EventArgs e)
        {

            string str = "";
            foreach (char character in txtLastName.Text)
            {
                if (char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtLastName.Text = str;
                    txtLastName.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Letters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtEmailId_Validated(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtContact.Text)
            {
                if (char.IsNumber(character))
                {
                    str += character;
                }
                else
                {
                    txtContact.Text = str;
                    txtContact.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Numbers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtUsername.Text)
            {
                if (char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtUsername.Text = str;
                    txtUsername.SelectionStart = str.Length;
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
