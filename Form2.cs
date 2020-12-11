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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbNome1.Text = Form1.SetValueForText1;
            lbCurso1.Text = Form1.SetValueForText2;
            lbAno1.Text = Form1.SetValueForText3;
        }
    }
}
