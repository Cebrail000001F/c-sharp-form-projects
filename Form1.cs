namespace Geometri_Hesaplayıcı
{
    public partial class Form1 : Form
    {
        double pi = 3.14;
        double d = 0.33;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Koni alanı hesabı
            int koniYuksekligi= Convert.ToInt32(hKoni.Text);
            int koniYarıCapı= Convert.ToInt32(rKoni.Text);
            double koniAlani = (koniYuksekligi * koniYarıCapı * koniYarıCapı)*d;
            labelKoniSonuc.Text = koniAlani.ToString();

            //Kare alanı hesabı
            int kenarUzunluk =Convert.ToInt32(K.Text);
            int kareAlanı = kenarUzunluk * kenarUzunluk * kenarUzunluk;
            labelKareSonuc.Text=kareAlanı.ToString();

            //Silindir alanı hesabı
            int SilindirYuksekligi = Convert.ToInt32(hSilindir.Text);
            int SilindirYarıCapı = Convert.ToInt32(rSilindir.Text);
            double SilindirAlani = SilindirYuksekligi * SilindirYarıCapı * pi * SilindirYarıCapı;
            labelSilindirSonuc.Text = SilindirAlani.ToString();

        }

       
    }
}