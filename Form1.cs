using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
    }

        private void btnForm_Click(object sender, EventArgs e)
        {
            SetValueForText1 = tbNome.Text;
            SetValueForText2 = tbCurso.Text;
            SetValueForText3 = tbAno.Text;
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
