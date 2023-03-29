namespace ProvaAPrendermi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNO_MouseMove(object sender, MouseEventArgs e)
        {
            btnNO.Left = Random.Shared.Next(0, this.Width-btnNO.Width);
            btnNO.Top = Random.Shared.Next(0, this.Height-20-btnNO.Height);
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi hai preso!!!");
        }
    }
}