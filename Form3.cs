using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcranDialogue
{
    public partial class Form3 : Form
    {
        string adhérent;
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            adhérent = "Nouveau client";
            label1.Text = adhérent;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            adhérent = "Ancien client";
            label1.Text = adhérent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ecran ecran = new ecran();
            ecran.Show();
            this.Hide();
        }
    }
}
