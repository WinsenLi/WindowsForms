namespace BMI_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("m/kg");
            comboBox1.Items.Add("in/lb");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bitte geben Sie Größe und Gewicht an");
            }
            else
            {

                double gewicht = Convert.ToDouble(textBox2.Text);
                double groesse = Convert.ToDouble(textBox1.Text);
                double bmi = gewicht / (groesse * groesse);

                label3.Text = "Ihr BMI ist: " + bmi.ToString("N2");

                if (bmi < 18.5)
                {
                    label4.Text = "BMI-Kategorie: Untergewicht";
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    label4.Text = "BMI-Kategorie: Normalgewicht";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    label4.Text = "BMI-Kategorie: Übergewicht";
                }
                else
                {
                    label4.Text = "BMI-Kategorie: Adipositas";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "Größe in ";
            }
        }
    }
}