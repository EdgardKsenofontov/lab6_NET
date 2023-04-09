using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_NET
{
    public partial class Form1 : Form
    {
        public  bool flag = false;
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            


        }

        private void AboutTeachers_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                
                form2.MdiParent = this;
                form2.LayoutMdi(MdiLayout.Cascade);
                form2.Text = "Сведения об преподавателях";
                form2.Show();
            }
            flag = true;

        }

        private void AboutStudents_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                
                form2.MdiParent = this;
                form2.LayoutMdi(MdiLayout.Cascade);
                form2.Text = "Сведения о студентах";
                form2.Show();
                
            }
            flag = true;
        }

        private void CloseAbout_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            form2.Hide();
            flag = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "lab6_NET";
            notifyIcon1.BalloonTipText = "Приложение свернуто";
            notifyIcon1.Text = "lab6_NET";
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
