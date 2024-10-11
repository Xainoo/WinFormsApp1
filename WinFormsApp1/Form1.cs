namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random r;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - button1.Width;
            int maxY = this.Size.Height - button1.Height;
            Point p = new Point();
            p.X = r.Next(20, maxX);
            p.Y = r.Next(20, maxY);
            button1.Location = p;
        }
    }
}
