using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NkbWork
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorsAdd ad = new VisitorsAdd();
            ad.Show();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }

        private void editDeleteShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorsEdit ad = new VisitorsEdit();
            ad.Show();
        }

        private void studentInfoReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRPF rp = new CRPF();
            rp.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CandidateAdd tf = new CandidateAdd();
            tf.Show();
        }

        private void editDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CandidateEdit tf = new CandidateEdit();
            tf.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm ad = new EditForm();
            ad.Show();
        }

        private void showEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SP_Curd ad = new SP_Curd();
            ad.Show(); 
        }

        private void tutorInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRPF2 rp = new CRPF2();
            rp.Show();
        }

        private void subReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRPF3 rp = new CRPF3();
            rp.Show();
        }
    }
}
