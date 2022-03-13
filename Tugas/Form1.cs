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
            if (txtBox1.Text.Contains("isi:") || txtBox1.Text.Contains("ISI:") || txtBox1.Text.Contains("Isi:") || txtBox1.Text == "SHOWN" || txtBox1.Text == "shown" || txtBox1.Text == "Shown" || txtBox1.Text == "HIDE" || txtBox1.Text == "hide" || txtBox1.Text == "Hide" || txtBox1.Text.Contains("BESARKAN") || txtBox1.Text.Contains("besarkan") || txtBox1.Text.Contains("Besarkan") || txtBox1.Text.Contains("Kecilkan") || txtBox1.Text.Contains("KECILKAN") || txtBox1.Text.Contains("kecilkan") || txtBox1.Text == "Warna: Default" || txtBox1.Text == "WARNA: DEFAULT" || txtBox1.Text == "warna: default" || txtBox1.Text == "Warna: Merah" || txtBox1.Text == "WARNA: MERAH" || txtBox1.Text == "warna: merah" || txtBox1.Text == "Warna: Hijau" || txtBox1.Text == "WARNA: HIJAU" || txtBox1.Text == "warna: hijau" || txtBox1.Text == "Warna: Biru" || txtBox1.Text == "WARNA: BIRU" || txtBox1.Text == "warna: biru" || txtBox1.Text == "Restart" || txtBox1.Text == "RESTART" || txtBox1.Text == "restart" || txtBox1.Text == "Warna:Default" || txtBox1.Text == "WARNA:DEFAULT" || txtBox1.Text == "warna:default" || txtBox1.Text == "Warna:Merah" || txtBox1.Text == "WARNA:MERAH" || txtBox1.Text == "warna:merah" || txtBox1.Text == "Warna:Hijau" || txtBox1.Text == "WARNA:HIJAU" || txtBox1.Text == "warna:hijau" || txtBox1.Text == "Warna:Biru" || txtBox1.Text == "WARNA:BIRU" || txtBox1.Text == "warna:biru" || txtBox1.Text.Contains("ISi:") || txtBox1.Text.Contains("iSi:") || txtBox1.Text.Contains("isI:"))
            {
                Isi();
                Pengaturan();
                Ukuran();
                Restart();
                Warna();
            }
            else
            {
                MessageBox.Show("Syntax Tidak Terdaftar!");
            }
        }
        public void Isi()
        {
            if (txtBox1.Text.Contains("isi:") || txtBox1.Text.Contains("ISI:") || txtBox1.Text.Contains("Isi:") || txtBox1.Text.Contains("ISi:") || txtBox1.Text.Contains("iSi:") || txtBox1.Text.Contains("isI:"))
            {
                label_empty.Text = txtBox1.Text.Substring(4);                
            }
        }
        public void Pengaturan()
        {
            if (txtBox1.Text == "SHOWN" || txtBox1.Text == "shown" || txtBox1.Text == "Shown")
            {
                label_empty.Visible = true;
            }
           
            else if (txtBox1.Text == "HIDE" || txtBox1.Text == "hide" || txtBox1.Text == "Hide")
            {
                label_empty.Visible = false;
            }
           
        }
        public void Ukuran()
        { 
            if (txtBox1.Text.Contains("BESARKAN") || txtBox1.Text.Contains("besarkan") || txtBox1.Text.Contains("Besarkan"))
            {
                float size;
                size = label_empty.Font.Size;
                size += 5.0F;
                label_empty.Font = new Font(label_empty.Font.Name, size, label_empty.Font.Style, label_empty.Font.Unit);               
            }
            else if (txtBox1.Text.Contains("Kecilkan") || txtBox1.Text.Contains("KECILKAN") || txtBox1.Text.Contains("kecilkan"))
            {
                float size;
                size = label_empty.Font.Size;
                size -= 5.0F;
                label_empty.Font = new Font(label_empty.Font.Name, size, label_empty.Font.Style, label_empty.Font.Unit);
            }
        }
        public void Warna()
        {
            if (txtBox1.Text == "Warna: Default" || txtBox1.Text == "WARNA: DEFAULT" || txtBox1.Text == "warna: default" || txtBox1.Text == "Warna:Default" || txtBox1.Text == "WARNA:DEFAULT" || txtBox1.Text == "warna:default")
            {
                label_empty.ForeColor = Color.Black;
            }
            else if (txtBox1.Text == "Warna: Merah" || txtBox1.Text == "WARNA: MERAH" || txtBox1.Text == "warna: merah" || txtBox1.Text == "Warna:Merah" || txtBox1.Text == "WARNA:MERAH" || txtBox1.Text == "warna:merah")
            {
                label_empty.ForeColor = Color.Red;
            }
            else if (txtBox1.Text == "Warna: Hijau" || txtBox1.Text == "WARNA: HIJAU" || txtBox1.Text == "warna: hijau" || txtBox1.Text == "Warna:Hijau" || txtBox1.Text == "WARNA:HIJAU" || txtBox1.Text == "warna:hijau")
            {
                label_empty.ForeColor = Color.Green;
            }
            else if (txtBox1.Text == "Warna: Biru" || txtBox1.Text == "WARNA: BIRU" || txtBox1.Text == "warna: biru" || txtBox1.Text == "Warna:Biru" || txtBox1.Text == "WARNA:BIRU" || txtBox1.Text == "warna:biru")
            {
                label_empty.ForeColor = Color.Blue;
            }
           
        }
        public void Restart()
        {
            if (txtBox1.Text == "Restart" || txtBox1.Text == "RESTART" || txtBox1.Text == "restart")
            {
              Application.Restart();
            }
           
        }
    }
}