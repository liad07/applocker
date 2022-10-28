using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Security;
using System.ComponentModel;
namespace applocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string app = textBox1.Text;
            string password = textBox2.Text;
            string app2;
            string password2;
            string[] lines = System.IO.File.ReadAllLines(@"users.png");
            app2 = lines[0];
            password2 = lines[1];
            
            if (app == app2)
            {
                if (password == password2)
                {
                    this.Close();
                    Process.Start(@"C:\Users\USER\AppData\Local\JetBrains\IntelliJ IDEA Community Edition 2021.3.2\bin\idea64.exe");

                }
            }
            else
            {
                label1.Text = "ur not aloowed to this app";
            }
        }
    }
}
