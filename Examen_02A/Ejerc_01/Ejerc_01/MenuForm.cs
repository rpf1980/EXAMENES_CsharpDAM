using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc_01
{
    public partial class MenuForm : Form
    {
        AddPisoForm addPisoForm = null;
        Form1 form1 = null;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPisoForm = new AddPisoForm();
            addPisoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
        }
    }
}
