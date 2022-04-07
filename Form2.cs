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
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add(dh.rok);
            comboBox1.SelectedIndex = 0;

        }
    }
}
