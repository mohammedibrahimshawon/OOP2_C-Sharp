using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddEmployee addE = new AddEmployee();
            addE.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDetails ed = new EmployeeDetails();
            ed.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageStaffs manageStaffs = new ManageStaffs();
            manageStaffs.Show();
            this.Hide();
        }

     
    }
}
