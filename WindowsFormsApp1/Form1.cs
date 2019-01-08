using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        public User user { get; set; }
        public form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

    
        private void button_Click(object sender, EventArgs e)
        {
            user = new User();
            Random r = new Random();
            button.Left = r.Next(0, Width/2);
            button.Top = r.Next(0, Height/2);
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            var text = agetextBox.Text;
            user.Age = Convert.ToInt32(text);
            user.Name = nametextBox1.Text;
            user.Surname = surnametextBox.Text;
            var item = maleradioButton;
            string gender = string.Empty;
            foreach (var g in groupBox.Controls)
            {
                var casted = g as RadioButton;
                if (casted.Checked)
                {
                    gender = casted.Text;
                }
            }
            MessageBox.Show($"{user.Surname} {user.Name} {user.Age} {gender}");
        }


    }
}
