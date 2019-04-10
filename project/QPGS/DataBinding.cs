using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace QPGS
{
    class DataBinding
    {
        Connection objcon = new Connection();

        public ComboBox LoadCombo(ComboBox cmb , string query)
        {
            try
            {
                cmb.Items.Clear();
                //cmb.Items.Add("<Select>");
                objcon.Open();
                objcon.cmd.CommandText = query;
                objcon.reader = objcon.cmd.ExecuteReader();
                while (objcon.reader.Read())
                {
                    cmb.Items.Add(objcon.reader.GetValue(0).ToString());
                }
                objcon.reader.Close();
                objcon.Close();
                //cmbclass.DisplayMember = "ClassName";
                //cmbclass.ValueMember = "Class_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
            return cmb;
        }

        public int GetId(string query)
        {
             int id = 0;
            try
            {
                objcon.Open();
                objcon.cmd.CommandText = query;
                objcon.reader = objcon.cmd.ExecuteReader();
                if(objcon.reader.Read())
                {
                    id = Convert.ToInt32( objcon.reader.GetValue(0));
                }
                objcon.reader.Close();
                objcon.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }

        

        public void CleanForm(Form frm)
        {
            foreach (var c in frm.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = String.Empty;
                }

                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = String.Empty;
                }

                if (c is GroupBox)
                {
                    ((GroupBox)c).Text = string.Empty;
                }
            }
        }

        public DataGridView GridLoadDS(DataGridView dgv, string query)
        {
            dgv.Rows.Clear();
            objcon.Open();
            objcon.cmd.CommandText = query;

            DataTable table = new DataTable();
            table.Load(objcon.cmd.ExecuteReader());

            int rows = table.Rows.Count;
            int r = 0;
            foreach(DataRow dr in table.Rows)
            {
                dgv.Rows.Add();
                for (int i = 0; i < table.Columns.Count;i++)
                {
                    dgv.Rows[r].Cells[i].Value = dr[i].ToString();
                }
                r++;
            }
            //dgv.DataSource=table;
            objcon.Close();
            return dgv;

        }
        public bool CheckDup(string query)
        {
            bool exist = false;
             try
             {
                 objcon.Open();
                 objcon.cmd.CommandText=query;
                 objcon.reader = objcon.cmd.ExecuteReader();

                 if(objcon.reader.Read())
                 {
                     exist = true;
                 }
                 objcon.reader.Close();
                 objcon.Close();
             }
            catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             return exist;
        }

    }
}
