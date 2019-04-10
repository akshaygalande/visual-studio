using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InsertUpdateDeleteSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string mstrEmpID = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDes();
            LoadData();
        }
        private void LoadDes()
        {
            try
            {
                SqlConnection con = new SqlConnection(Commons.GetConnectionString);
                string strcmd = "SELECT DesID, DesName "+
                                " FROM            Des_MST "+
                                " ORDER BY DesName";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataAdapter dtadp = new SqlDataAdapter();
                dtadp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dtadp.Fill(dt);
                cmbDes.DataSource = dt;
                cmbDes.DisplayMember = "DesName";
                cmbDes.ValueMember = "DesID";
            }
            catch (Exception ex) { throw ex; }
        }
        private void SaveData()
        {
            try
            {
                SqlConnection con = new SqlConnection(Commons.GetConnectionString);
                string strcmd = "INSERT INTO Emp_MST " +
                                "(EmpName, DesID, Salary) " +
                                "VALUES        (@EmpName,@DesID,@Salary)";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.Parameters.AddWithValue("EmpName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("DesID", 
                cmbDes.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("Salary", txtSalary.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Emloyee saved successfully");
                Clears();
                LoadData();
            }
            catch (Exception ex) { throw ex; }
        }
        private void CheckData()
        {
            try
            {
                SqlConnection con = new SqlConnection(Commons.GetConnectionString);
                string strcmd = "SELECT        EmpID " +
                                "FROM            Emp_MST " +
                                "WHERE        (EmpName = @EmpName)";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.Parameters.AddWithValue("EmpName", txtEmpName.Text);
                SqlDataAdapter dtadp = new SqlDataAdapter();
                dtadp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dtadp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //EmpName found
                    MessageBox.Show("Employee name is already exist !!!");
                    txtEmpName.Focus();
                }
                else
                {
                    SaveData();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        
        private void Clears()
        {
            mstrEmpID = "";
            txtEmpName.Clear();
            txtSalary.Clear();
            cmbDes.SelectedIndex = 0;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtEmpName.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text.Trim() == "")
            {
                MessageBox.Show("Employee name can not be blank");
                txtEmpName.Focus();
            }
            else if (cmbDes.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Select Designation");
                cmbDes.Focus();
            }
            else if (txtSalary.Text.Trim() == "")
            {
                MessageBox.Show("Salary can not be empty");
                txtSalary.Focus();
            }
            else
            {
                CheckData();
            }
        }
        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(Commons.GetConnectionString);
                string strcmd = "SELECT  Emp_MST.EmpID, Emp_MST.EmpName, "+
                                "Des_MST.DesName, Emp_MST.Salary "+
                                " FROM            Emp_MST INNER JOIN "+
                                " Des_MST ON Emp_MST.DesID = Des_MST.DesID "+
                                "ORDER BY Emp_MST.EmpID";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataAdapter dtadp = new SqlDataAdapter(strcmd, con);
                dtadp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dtadp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                mstrEmpID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEmpName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbDes.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //blank check
            try
            {
                SqlConnection con = new SqlConnection(Commons.GetConnectionString);
                string strcmd = "UPDATE       Emp_MST "+
                                " SET    EmpName = @EmpName,"+
                                " DesID = @DesID, "+
                                " Salary = @Salary "+
                                " WHERE        (EmpID = @EmpID)";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.Parameters.AddWithValue("EmpName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("DesID",
                    cmbDes.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("Salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("EmpID", mstrEmpID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Emloyee updated successfully");
                Clears();
                LoadData();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete?",
                "Question", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = 
                        new SqlConnection(Commons.GetConnectionString);
                    string strcmd = "delete from Emp_MST  " +
                                    " WHERE        (EmpID = @EmpID)";
                    SqlCommand cmd = new SqlCommand(strcmd, con);
                    cmd.Parameters.AddWithValue("EmpID", mstrEmpID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Emloyee deleted successfully");
                    Clears();
                    LoadData();
                }
                catch (Exception ex) { throw ex; }
            }
        }
    }
}
