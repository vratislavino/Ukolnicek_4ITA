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
    public partial class PoznamkaView : UserControl
    {
        public event Action<Poznamka> DeleteRequested;

        Poznamka poznamka;

        public PoznamkaView(Poznamka p = null)
        {
            InitializeComponent();
            if(p != null) {
                nadpisLabel.Text = p.nadpis;
                casLabel.Text = p.cas.ToString();
                poznamka = p;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            DeleteRequested?.Invoke(poznamka);
        }
    }
}
