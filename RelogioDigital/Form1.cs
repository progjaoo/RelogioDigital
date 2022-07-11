namespace RelogioDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LblRelógio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}