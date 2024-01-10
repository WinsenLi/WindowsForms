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
                BMIBerechnen();
            }

        }

        public void BMIBerechnen()
        {

            double gewicht = Convert.ToDouble(textBox2.Text);
            double groesse = Convert.ToDouble(textBox1.Text);

            if (comboBox1.SelectedIndex == 1) 
            {
                const double ZOLL_IN_METER = 0.0254;
                const double PFUND_IN_KILOGRAMM = 0.453592;

                groesse *= ZOLL_IN_METER;
                gewicht *= PFUND_IN_KILOGRAMM;
            }

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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "Größe in m";
                label2.Text = "Gewicht in kg";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = "Größe in inch";
                label2.Text = "Gewicht in Pounds";
            }
        }
    }
}