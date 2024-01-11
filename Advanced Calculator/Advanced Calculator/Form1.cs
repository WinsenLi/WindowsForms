using System.Data;

namespace Advanced_Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region 1 bis 10
        private void button0_Click(object sender, EventArgs e)
        {
            Type(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Type(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Type(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Type(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Type(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Type(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Type(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Type(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Type(9);
        }
        #endregion

        #region Sonderzeichen
        private void button_Komma_Click(object sender, EventArgs e)
        {
            TypeSonderzeichen(",");
        }

        private void button_geteilt_Click(object sender, EventArgs e)
        {
            TypeSonderzeichen("/");
        }

        private void button_mal_Click(object sender, EventArgs e)
        {
            TypeSonderzeichen("*");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            TypeSonderzeichen("-");
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            TypeSonderzeichen("+");
        }
        #endregion


        public void Type(int i)
        {
            if (label_Display.Text.Any(char.IsLetter))
            {
                label_Display.Text = i.ToString();
            }
            else
            {
                label_Display.Text += i.ToString();
            }
        }

        public void TypeSonderzeichen(string s)
        {
            label_Display.Text += s;

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            label_Display.Text = null;
        }

        private void button_gleich_Click(object sender, EventArgs e)
        {
            string rechnung = label_Display.Text;
            double result = Berechnung(rechnung);
            label_Display.Text = result.ToString();
        }

        private double Berechnung(string rechnung)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(rechnung, ""));

        }

        private void button_Potenz_Click(object sender, EventArgs e)
        {

        }
    }
}