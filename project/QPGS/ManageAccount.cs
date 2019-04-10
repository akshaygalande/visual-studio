using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPGS
{
    public partial class ManageAccount : Form
    {
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        string strID = "";
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateAccount obj = new CreateAccount();
            obj.ShowDialog();
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select User_Id,User_FName,User_LName,User_Username,Role_Name from tbl_User inner join  Role on tbl_User.User_Role_Id =Role.Role_Id");
               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = "";
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CreateAccount obj = new CreateAccount(id);
            obj.ShowDialog();
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select User_Id,User_FName,User_LName,User_Username,Role_Name from tbl_User inner join  Role on tbl_User.User_Role_Id =Role.Role_Id");
            strID = "";
               
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select User_Id,User_FName,User_LName,User_Username,Role_Name from tbl_User inner join  Role on tbl_User.User_Role_Id =Role.Role_Id");
            cmbRole = objfunc.LoadCombo(cmbRole, "select Role_Name from Role");
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

            if (cmbRole.Text == "")
            {
                valid = false;
                cmbRole.BackColor = Color.Red;
            }
            else
            {
                cmbRole.BackColor = Color.White;
            }
            return valid;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select User_Id,User_FName,User_LName,User_Username,Role_Name from tbl_User inner join  Role on tbl_User.User_Role_Id =Role.Role_Id where User_FName LIKE '" + txtFirstName.Text + "%' and User_LName LIKE '" + txtLastName.Text + "%' and Role_Name='" + cmbRole.Text + "'");
                }
                else
                {
                    MessageBox.Show("Enter values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ManageAccount obj = new ManageAccount();
            this.Hide();
            obj.Close();
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (strID != "")
                {
                    if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objcon.Open();
                        string query = "DELETE FROM tbl_User WHERE User_Id=@strID";
                        objcon.cmd.CommandText = query;
                        objcon.cmd.Parameters.AddWithValue("strID", strID);
                        objcon.cmd.ExecuteNonQuery();
                        objcon.Close();
                        MessageBox.Show("Data deleted Sucessfully...");
                        objfunc.CleanForm(this);
                        dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select User_Id,User_FName,User_LName,User_Username,Role_Name from tbl_User inner join  Role on tbl_User.User_Role_Id =Role.Role_Id");
                        strID = "";
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Any row was not selected (Double click on the row to select it).");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                strID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                btnDelete.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
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

       
    }
}
