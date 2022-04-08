namespace zapis_app
{
    public partial class Form1 : Form
    {
        public DataHandler dh = new DataHandler();
        public string aktualniZS = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCombobox();
            //dh.LoadDB(dh.fileCSV);
        }
        



        // metoda pro naplnìní položek comboboxu
        private void FillCombobox()
        {
            foreach(var zs in dh.zakladniSkoly)
            {
                comboBox1.Items.Add(zs);
                comboBox1.SelectedIndex = 0;
                //System.Diagnostics.Debug.WriteLine(zs);
            } 
        }




        // tlaèítko Pokraèovat
        private void button1_Click(object sender, EventArgs e)
        {
            var Window = new Form2();
            Window.aktualniZS = aktualniZS;
            Window.Show();
        }


        // vybrání z combobox1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           aktualniZS = comboBox1.Text;
           //System.Diagnostics.Debug.WriteLine(aktualniZS);
        }
            
    }
}