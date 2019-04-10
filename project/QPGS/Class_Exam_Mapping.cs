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
    public partial class Class_Exam_Mapping : Form
    {
        static int classid, examid;
        string strID = "";
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        public Class_Exam_Mapping()
        {
            InitializeComponent();
        }

        private void Class_Exam_Mapping_Load(object sender, EventArgs e)
        {
           
            objfunc.LoadCombo(cmbClass, "select ClassName from Class_Mst");
            objfunc.LoadCombo(cmbexam, "select Exam_Type from Exam_Mst");
            
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select CEM_ID,ClassName,Exam_Type from Class_Exam_Mapping inner join Class_Mst on Class_Exam_Mapping.Class_ID=Class_Mst.Class_ID inner join Exam_Mst on Class_Exam_Mapping.Exam_ID=Exam_Mst.Exam_ID");
            
        }


        private bool validate()
        {
            bool valid = true;
            if (cmbClass.Text == "")
            {
                valid = false;
                cmbClass.BackColor = Color.Red;
            }
            else
            {
                cmbClass.BackColor = Color.White;
            }
            if (cmbexam.Text == "")
            {

                valid = false;
                cmbexam.BackColor = Color.Red;
            }
            else
            {
                cmbexam.BackColor = Color.White;
            }

            return valid;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnattach_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbClass.Text + "'");
                examid = objfunc.GetId("select Exam_ID from Exam_MST where Exam_Type='" + cmbexam.Text + "'");

                try
                {
                    objcon.Open();
                    string query = "insert into Class_Exam_Mapping(Class_ID,Exam_ID) values(@classid,@examid)";
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@classid", classid);
                    objcon.cmd.Parameters.AddWithValue("@examid", examid);
                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Data Saved Sucessfully...");
                    objfunc.CleanForm(this);
                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select CEM_ID,ClassName,Exam_Type from Class_Exam_Mapping inner join Class_Mst on Class_Exam_Mapping.Class_ID=Class_Mst.Class_ID inner join Exam_Mst on Class_Exam_Mapping.Exam_ID=Exam_Mst.Exam_ID");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select Values...");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                strID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                                string query = "DELETE FROM Class_Exam_Mapping WHERE CEM_ID=@strID";
                                objcon.cmd.CommandText = query;
                                objcon.cmd.Parameters.AddWithValue("strID", strID);
                                objcon.cmd.ExecuteNonQuery();
                                objcon.Close();
                                MessageBox.Show("Data deleted Sucessfully...");
                                objfunc.CleanForm(this);
                                dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select CEM_ID,ClassName,Exam_Type from Class_Exam_Mapping inner join Class_Mst on Class_Exam_Mapping.Class_ID=Class_Mst.Class_ID inner join Exam_Mst on Class_Exam_Mapping.Exam_ID=Exam_Mst.Exam_ID");
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
    }
}
