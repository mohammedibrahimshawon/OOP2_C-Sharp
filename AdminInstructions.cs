﻿using System;
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
    public partial class AdminInstructions : Form
    {
        public AdminInstructions()
        {
            InitializeComponent();
        }
        public string name, type;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

     
        

        private void button1_Click(object sender, EventArgs e)
        {
           // DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[CoachInstruction].* FROM [Soccer].[dbo].[CoachInstruction] where [Soccer].[dbo].[CoachInstruction].UserID = '" + name + "'");

            //dataGridView1.DataSource = dt;
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();
        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            Coach c = new Coach();
            c.name= this.name;
           c.type = this.type;
            c.Show();
            this.Hide();
        }

        private void AdminInstruction_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }

}
