using System.Drawing.Text;
using System.Numerics;

namespace Bmi_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double height))
            {
                if (double.TryParse(textBox1.Text, out double weight))
                {
                    double bmi = (weight / (height * height));
                    label3.Text = bmi.ToString();

                    progressBar1.Maximum = 40;
                    progressBar1.Minimum = 10;

                    if (bmi >= 10)
                    {
                        progressBar1.Value = 10;
                        label5.Text = "You should contact a doctor";
                    }
                    else if (bmi >= 40)
                    {
                        progressBar1.Value = 40;
                        label5.Text = "You have Obesity Class III";
                    }
                    else
                    {
                        progressBar1.Value = ((int)bmi);
                    }
                    

                    if (bmi < 18.5)
                    {
                        label5.Text = "You are Underweight";
                    }
                    else if (bmi >= 18.5 && bmi < 24.9)
                    {
                        label5.Text = "Normal weight";
                    }
                    else if (bmi >= 25.0 && bmi < 29.9)
                    {
                        label5.Text = "Overweight";
                    }
                    else if (bmi >= 30.0 && bmi < 34.9)
                    {
                        label5.Text = "You have Obesity Class I";
                    }
                    else if (bmi >= 35.0 && bmi < 39.9)
                    {
                        label5.Text = "You have Obesity Class II";
                    }
            }
        }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

