namespace radioButton_CheckBox_Panel
{
    public partial class Form1 : Form
    {
       
        
        public Form1()

        {
            InitializeComponent();
        }

        //button1: sipari� 1
        public void button1_Click(object sender, EventArgs e)
        {
            

        richTextBox1.Text = dateTimePicker2.Text + Environment.NewLine + dateTimePicker1.Text + Environment.NewLine + "Sipari� 1" + Environment.NewLine + "---------" + Environment.NewLine + "Tost" + " : ";
            if (checkBox1.Checked == true)
            {
                
                richTextBox1.Text = richTextBox1.Text + " " + "Yumurta";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text  + ""; 
            }
            
                

            if (checkBox2.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + "Sucuk";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + ""; 
            }

            if (checkBox3.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Kasar Peynir";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            if (checkBox4.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Ketcap";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }
            
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "��ecek" + ":";

            if (radioButton1.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Meyve Suyu";
            }
            else if (radioButton2.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "�ay";
            }
            else if (radioButton3.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Kahve";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + " " + "i�ecek yok";
            }
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "------------------------------";


        }
        
       
        //button2: sipari� 2
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker2.Text + Environment.NewLine + dateTimePicker1.Text + Environment.NewLine + "Sipari� 2" + Environment.NewLine + "---------" + Environment.NewLine + "Tost" + " : ";
            if (checkBox8.Checked == true)
            {

                richTextBox1.Text = richTextBox1.Text + " " + "Yumurta";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }



            if (checkBox7.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + "Sucuk";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            if (checkBox6.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Kasar Peynir";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            if (checkBox5.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Ketcap";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "��ecek" + ":";

            if (radioButton6.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Meyve Suyu";
            }
            else if (radioButton5.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "�ay";
            }
            else if (radioButton4.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Kahve";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + " " + "i�ecek yok";
            }
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "------------------------------";
        }
        //button3: sipari� 3
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker2.Text + Environment.NewLine + dateTimePicker1.Text + Environment.NewLine + "Sipari� 3" + Environment.NewLine + "---------" + Environment.NewLine + "Tost" + " : ";
            if (checkBox24.Checked == true)
            {

                richTextBox1.Text = richTextBox1.Text + " " + "Yumurta";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }



            if (checkBox23.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + "Sucuk";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            if (checkBox22.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Kasar Peynir";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            if (checkBox21.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Ketcap";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "��ecek" + ":";

            if (radioButton18.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Meyve Suyu";
            }
            else if (radioButton17.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "�ay";
            }
            else if (radioButton16.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Kahve";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + " " + "i�ecek yok";
            }
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "------------------------------";
        }
        //button1: sipari� 4
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker2.Text + Environment.NewLine + dateTimePicker1.Text + Environment.NewLine + "Sipari� 4" + Environment.NewLine + "---------" + Environment.NewLine + "Tost" + " : ";
            if (checkBox12.Checked == true)
            {

                richTextBox1.Text = richTextBox1.Text + " " + "Yumurta";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }



            if (checkBox11.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + "Sucuk";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            if (checkBox10.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Kasar Peynir";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            if (checkBox9.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " + " + "Ketcap";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }

            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "��ecek" + ":";

            if (radioButton9.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Meyve Suyu";
            }
            else if (radioButton8.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "�ay";
            }
            else if (radioButton7.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + "Kahve";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + " " + "i�ecek yok";
            }
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "------------------------------";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(richTextBox1.Text);
        }
    }
}