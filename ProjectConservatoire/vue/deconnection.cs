using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConservatoire.vue
{
    public partial class Deconnection : Form
    {
        public Deconnection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "PageLogin")
                {
                    form.Close();
                }
            }
        }

        private void deconnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "PageLogin")
                {
                    form.Close();
                }
            }
        }

        private void Deconnection_Load(object sender, EventArgs e)
        {

        }
    }
}
