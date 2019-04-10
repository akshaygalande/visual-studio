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
    public partial class Chapter_Mst : Form
    {
        static int classid;
        //string strID = "";
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();

        public Chapter_Mst()
        {
            InitializeComponent();
        }

        private void Chapter_Mst_Load(object sender, EventArgs e)
        {


        }

        private void btnattach_Click(object sender, EventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbClass.Text + "'");
            cmbSubject = objfunc.LoadCombo(cmbSubject, "select SubjectName from Class_Subject_Mapping inner join Subject_MST on Class_Subject_Mapping.Subject_ID=Subject_MST.Subject_ID inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_MST.Class_ID where (Class_Subject_Mapping.Class_ID=" + classid + ")");
        }

        private void Chapter_Mst_Load_1(object sender, EventArgs e)
        {
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select CSM_ID,ClassName,SubjectName from Class_Subject_Mapping inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_Mst.Class_ID inner join Subject on Class_Subject_Mapping.Subject_ID=Subject.Subject_ID");
            objfunc.LoadCombo(cmbClass, "select ClassName from Class_Mst");
        }

    }
}
