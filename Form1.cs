namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        byte sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i <= 80; i += 30)
            {
                sayac++;
                

                if (sayac % 50 == 0)
                {
                    pictureBox1.Image = Resource1._103;
                }
                if (sayac % 50 == 10)
                {
                    pictureBox1.Image = Resource1._104;
                }
                if (sayac % 50 == 20)
                {
                    pictureBox1.Image = Resource1._105;
                }
                if (sayac % 50 == 30)
                {
                    pictureBox1.Image = Resource1._106;
                }
                if (sayac % 50 == 40)
                {
                    pictureBox1.Image = Resource1._107;
                }
            }

        }

       
    }
}