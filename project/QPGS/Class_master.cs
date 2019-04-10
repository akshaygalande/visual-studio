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
    public partial class Class_master : Form
    {
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        string strID = "";
        static int classid;
        
        public Class_master()
        {
            InitializeComponent();
        }

    

        private void btnsave_Click(object sender, EventArgs e)
        {
            

        }

        private void Class_master_Load(object sender, EventArgs e)
        {
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Class_ID,ClassName from Class_Mst");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Class_master obj = new Class_master();
            obj.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (strID != "")
                {
                    objcon.Open();
                    string query = "Update Class_Mst set ClassName= @ClassName where Class_ID=" + strID + " ";
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@ClassName", txtclass.Text);
                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Data Saved Sucessfully...");
                    objfunc.CleanForm(this);
                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Class_ID,ClassName from Class_Mst");
                    txtclass.Clear();
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

        private void btnclose_Click_1(object sender, EventArgs e)
        {

            Class_master obj = new Class_master();
            this.Hide();
            obj.Close();
        }

        //private void btndelete_Click(object sender, DataGridViewCellEventArgs e)
        //{
           
        // }

        private bool checkdata()
        {
            classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + txtclass.Text + "'");
            bool check = true;
            if (objfunc.CheckDup("select CSM_ID from Class_Subject_Mapping where Class_ID='" + classid + "'"))
            {
                MessageBox.Show("Subject for this class has been mapped so cannot delete this class ");
                return check;
            }
            if (objfunc.CheckDup("select CEM_ID from Class_Exam_Mapping where Class_ID='" + classid + "'"))
            {
                MessageBox.Show("Exam for this class has been mapped so cannot delete this class ");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks1_FIB where Class_ID='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks1_TRUEORFALSE where Question='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks2_ONESENTENCE where Question='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks3_ANSTHEFOLLOWING where Question='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks4_GIVEREASON where Question='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks5_ANSINBRIEF where Question='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks5_ANSINBRIEF where Question='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks1_MCQ where Question='" + classid + "'"))
            {
                MessageBox.Show("Question for this class is been stored in database so you cant delete this class");
                return check;
            }

            else
            {
                return check;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (strID != "")
                {
                    if (checkdata())
                    {
                       // MessageBox.Show("Cannot Delete this class as there are Questions, Chapters or Subjects assigned to it");
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            objcon.Open();
                            string query = "DELETE FROM Class_Mst WHERE Class_ID=@strID";
                            objcon.cmd.CommandText = query;
                            objcon.cmd.Parameters.AddWithValue("strID", strID);
                            objcon.cmd.ExecuteNonQuery();
                            objcon.Close();
                            MessageBox.Show("Data deleted Sucessfully...");
                            objfunc.CleanForm(this);
                            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Class_ID,ClassName from Class_Mst");
                            txtclass.Clear();
                            strID = "";
                        }
                        else
                        {
                            return;
                        }
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                strID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                btndelete.Enabled = true;
                txtclass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }


        private bool validate()
        {
            bool valid = true;
            if (txtclass.Text == "")
            {
                valid = false;
                txtclass.BackColor = Color.Red;
            }
            else
            {
                txtclass.BackColor = Color.White;
            }
            return valid;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {

                    objcon.Open();
                    string query = "insert into Class_Mst values(@ClassName)";
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@ClassName", txtclass.Text);
                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Data Saved Sucessfully...");
                    objfunc.CleanForm(this);
                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Class_ID,ClassName from Class_Mst");
                }
                else
                {
                    MessageBox.Show("Enter Values...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtclass_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtclass.Text)
            {
                if (char.IsNumber(character) || char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtclass.Text = str;
                    txtclass.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Numbers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        }

       
}
