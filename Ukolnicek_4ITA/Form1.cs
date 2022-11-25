using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Ukolnicek_4ITA
{
    public partial class Form1 : Form
    {
        string datapath = "poznamky.json";

        List<Poznamka> poznamky = new List<Poznamka>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            NactiPoznamky();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            UlozPoznamky();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PridaniPoznamky addForm = new PridaniPoznamky();
            DialogResult res = addForm.ShowDialog();
            if(res == DialogResult.OK)
            {
                Poznamka pozn = addForm.GetPoznamka();
                poznamky.Add(pozn);
                UpdateUI();
            } else
            {
                Console.WriteLine("Poznámka nebyla přidána...");
            }
        }
        
        private void UlozPoznamky() {
            string json = JsonConvert.SerializeObject(poznamky);

            using (StreamWriter sw = new StreamWriter(datapath)) {
                sw.Write(json);
            }

        }

        private void NactiPoznamky() {

            try {
                string obsahSouboru = File.ReadAllText(datapath);
                var poznamky = JsonConvert.DeserializeObject<List<Poznamka>>(obsahSouboru);
                this.poznamky = poznamky;
                UpdateUI();
            } catch(Exception ex) {
                MessageBox.Show("Nepodařilo se načíst poznámky. " + ex.Message);
            }
        }

        private void UpdateUI() {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < poznamky.Count; i++) {

                PoznamkaView view = new PoznamkaView(poznamky[i]);

                view.DeleteRequested += OnDeleteRequested;

                flowLayoutPanel1.Controls.Add(view);
            }
        }

        private void OnDeleteRequested(Poznamka pozn) {
            poznamky.Remove(pozn);
            UpdateUI();
        }
    }
}
