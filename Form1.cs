namespace Geometri_Hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Koni alanı hesabı
            int koniYuksekligi= Convert.ToInt32(hKoni.Text);
            int koniYarıCapı= Convert.ToInt32(rKoni.Text);
            int koniAlani = koniYuksekligi * koniYarıCapı;
            labelKoniSonuc.Text = koniAlani.ToString();

            //Kare alanı hesabı
            int kenarUzunluk =Convert.ToInt32(K.Text);
            int kareAlanı = kenarUzunluk * kenarUzunluk;
            labelKareSonuc.Text=kareAlanı.ToString();

            //Silindir alanı hesabı
            int SilindirYuksekligi = Convert.ToInt32(hSilindir.Text);
            int SilindirYarıCapı = Convert.ToInt32(rSilindir.Text);
            int SilindirAlani = SilindirYuksekligi * SilindirYarıCapı;
            labelSilindirSonuc.Text = SilindirAlani.ToString();

        }

        
    }
}