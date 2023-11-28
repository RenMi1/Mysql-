using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Myclass;
namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        Class1 con = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectdb.Open();
                label1.Text = "";
                
                con.connectdb.Close();
            }
            catch (Exception)
            {
                label1.Text = "You are Connected to the MySql Database!";
                label1.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
