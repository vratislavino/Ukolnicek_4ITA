using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukolnicek_4ITA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PridaniPoznamky addForm = new PridaniPoznamky();
            DialogResult res = addForm.ShowDialog();
            if(res == DialogResult.OK)
            {
                Poznamka pozn = addForm.GetPoznamka();
                MessageBox.Show("Přidání poznámky do souboru");
                // přidání poznámky do souboru
            } else
            {
                Console.WriteLine("Poznámka nebyla přidána...");
            }

        }
    }
}
