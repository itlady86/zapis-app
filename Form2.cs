using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zapis_app
{
    public partial class Form2 : Form
    {
        public DataHandler dh = new DataHandler();
        DataTable dt = new DataTable();
        public string aktualniZS = "";


        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add(dh.rok);
            comboBox1.SelectedIndex = 0;
            
        }

        //předání parametrů z Form1
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "ZÁKLADNÍ ŠKOLA " + aktualniZS;
            CreateDGV();
            dataGridView1.RefreshEdit();

        }


        private void CreateDGV() 
        {
            Hlavicka();
            ImportCSV();
        }


        private void Hlavicka()
        {
            dt.Columns.Add("id", Type.GetType("System.Int32"));
            dt.Columns.Add("Jméno", Type.GetType("System.String"));
            dt.Columns.Add("Příjmení", Type.GetType("System.String"));
            dt.Columns.Add("Bydliště", Type.GetType("System.String"));
            dt.Columns.Add("Datum narození", Type.GetType("System.String"));
            dt.Columns.Add("Základní škola", Type.GetType("System.String"));
            dataGridView1.DataSource = dt;
        }

        private void ImportCSV()
        {
            var row = dh.SortData(aktualniZS);
            foreach (var i in row)
            {
               dt.Rows.Add(i.Id, i.Jmeno, i.Prijmeni, i.Bydliste, i.DatumNarozeni, i.Skola);
            }
        }

        //tlačítko Zpět
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
