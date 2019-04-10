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
    public partial class Exam_Master : Form
    {
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        string strID = "";
        public Exam_Master()
        {
            InitializeComponent();
        }

        private void Exam_Master_Load(object sender, EventArgs e)
        {
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Exam_ID,Exam_Type from Exam_Mst");
             
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            PrincipleMainForm obj = new PrincipleMainForm();
            this.Hide();
            obj.Close();
        }

        private bool validate()
        {
            bool valid = true;
            if (txtexam.Text == "")
            {
                valid = false;
                txtexam.BackColor = Color.Red;
            }
            else
            {
                txtexam.BackColor = Color.White;
            }
            
            return valid;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    if (objfunc.CheckDup("select Exam_Type from Exam_Mst where Exam_Type ='" + txtexam.Text + "'"))
                    {
                        MessageBox.Show(" This Exam Type already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objcon.Open();
                        string query = "insert into Exam_Mst(Exam_Type) values(@Exam_Type)";
                        objcon.cmd.CommandText = query;
                        objcon.cmd.Parameters.AddWithValue("@Exam_Type", txtexam.Text);
                        objcon.cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Saved Sucessfully...");
                        objfunc.CleanForm(this);
                        dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Exam_ID,Exam_Type from Exam_Mst");
                        objcon.Close();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (strID != "")
                {
                    objcon.Open();
                    string query = "Update Exam_Mst set Exam_Type= @Exam_Type where Exam_ID=" + strID + " ";
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@Exam_Type", txtexam.Text);
                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Data Saved Sucessfully...");
                    objfunc.CleanForm(this);
                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Exam_ID,Exam_Type from Exam_Mst");
                    txtexam.Clear();
                    strID = "";
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

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (strID != "")
                {
                    if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objcon.Open();
                        string query = "DELETE FROM Exam_Mst WHERE Exam_ID=@strID";
                        objcon.cmd.CommandText = query;
                        objcon.cmd.Parameters.AddWithValue("strID", strID);
                        objcon.cmd.ExecuteNonQuery();
                        objcon.Close();
                        MessageBox.Show("Data deleted Sucessfully...");
                        objfunc.CleanForm(this);
                        dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Exam_ID,Exam_Type from Exam_Mst");
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
                btndelete.Enabled = true;
                txtexam.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtexam_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtexam.Text)
            {
                if (char.IsNumber(character) || char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtexam.Text = str;
                    txtexam.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Numbers or letters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
