namespace BMI_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gewicht = Convert.ToDouble(textBox2.Text);
            double groesse = Convert.ToDouble(textBox1.Text);
            double bmi  = Math.Round((gewicht / (groesse * groesse)),2);

            label3.Text = "Ihr BMI ist: " + bmi.ToString();
        }
    }
}