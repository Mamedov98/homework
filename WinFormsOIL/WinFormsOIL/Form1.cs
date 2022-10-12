namespace WinFormsOIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "AI 92")
            {
                textBox1.Text = "1.0";


            }
            else if (comboBox1.Text == "AI 95")
            {
                textBox1.Text = "2.0";

            }
            else if (comboBox1.Text == "Diesel")
            {
                textBox1.Text = "0.80";

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) // хот дог
        {
            double a;
            a = Convert.ToDouble(textBox4.Text);


        }
        private void textBox8_TextChanged(object sender, EventArgs e) // бургер
        {
            double a;
            a = Convert.ToDouble(textBox8.Text);


        }

        private void textBox11_TextChanged(object sender, EventArgs e) // Кутаб
        {
            double a;
            a = Convert.ToDouble(textBox11.Text);



        }
        private void textBox6_TextChanged(object sender, EventArgs e) // оплата за кафе
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) // цена хот дога 
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // галочка для хот дога

        {
            /* if (checkBox1.Checked == true)
             {
                 textBox6.Text = Convert.ToString(b1 * 4);
                 summcafe = Convert.ToDouble(textBox6.Text);
                 textBox7.Text = Convert.ToString(c + summcafe);
             }*/
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.Text)
            {
                case "AI 92":
                    textBox3.Text = Convert.ToString(a * 1);
                    break;
                case "AI 95":
                    textBox3.Text = Convert.ToString(a * 2);
                    break;
                case "Diesel":
                    textBox3.Text = Convert.ToString(a * 0.80);
                    break;
            }


            double c;
            double d;


            c = Convert.ToDouble(textBox3.Text);
            // d = Convert.ToDouble(textBox6.Text);

            double a1;
            double b1;
            double c1;
            double d1;


            b1 = Convert.ToDouble(textBox4.Text);
            c1 = Convert.ToDouble(textBox8.Text);
            d1 = Convert.ToDouble(textBox11.Text);
            // textBox6.Text = Convert.ToString(b1 * 4);
            // textBox6.Text = Convert.ToString(c1 * 5);
            // textBox6.Text = Convert.ToString(d1 * 3);

            double summcafe;
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString((b1 * 4) + (c1 * 5) + (d1 * 3));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox1.Checked)
            {
                textBox6.Text = Convert.ToString(b1 * 4);
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox6.Text = Convert.ToString((b1 * 4) + (c1 * 5));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString((b1 * 4) + (d1 * 3));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox2.Checked)
            {
                textBox6.Text = Convert.ToString(c1 * 5);
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString((c1 * 5) + (d1 * 3));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString(d1 * 3);
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }

            else
            {
                textBox6.Text = Convert.ToString(0);
                textBox7.Text = Convert.ToString(c);
            }
            summcafe = Convert.ToDouble(textBox6.Text);
            textBox7.Text = Convert.ToString(c + summcafe);



        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {

        }
    }
}