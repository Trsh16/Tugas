namespace Tugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bttn_proses_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text.Contains("isi:")|| txtBox1.Text.Contains("ISI:") || txtBox1.Text.Contains("IsI:")|| txtBox1.Text.Contains("iSi:") || txtBox1.Text.Contains("isI:") || txtBox1.Text.Contains("Isi:") || txtBox1.Text.Contains("ISi:") || txtBox1.Text.Contains("iSI:"))
            {
                label_empty.Text = txtBox1.Text.Substring(4);
            }
            else
            {
                MessageBox.Show("Syntax tidak terdaftar!");
            }
        }
        public void Pengaturan()
        {
            if (txtBox1.Text == "SHOWN")
            {
                label_empty.Visible = true;
            }
            if (txtBox1.Text == "HIDE")
            {
                label_empty.Visible = false;
            }
        }
        public void isi()
        {

        }
        public void ukuran()
        {

        }
        public void warna()
        {
          
                label_empty.ForeColor = Color.Black; 
                label_empty.ForeColor = Color.Red;
                label_empty.ForeColor = Color.Green;
                label_empty.ForeColor = Color.Blue; 
        }
        public void restart()
        {

        }

    }
}