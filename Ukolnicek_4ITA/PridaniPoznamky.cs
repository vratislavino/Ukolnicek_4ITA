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
    public partial class PridaniPoznamky : Form
    {
        public PridaniPoznamky()
        {
            InitializeComponent();
        }

        public Poznamka GetPoznamka()
        {
            return new Poznamka() { 
                nadpis = nadpisTextbox.Text,
                text = textTextbox.Text,
                cas = DateTime.Now
            };
        }
    }
}
