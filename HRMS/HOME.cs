using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADVANCE ad = new ADVANCE();
            ad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ATTENDENCE at = new ATTENDENCE();
            at.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ISSUE_SALARY s = new ISSUE_SALARY();
            s.Show();
            this.Hide();
        }
    }
}
