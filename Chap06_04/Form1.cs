using System.Runtime.CompilerServices;

namespace Chap06_04
{
    public partial class Form1 : Form
    {
        bool resultflg = false;
        bool firstflg = true;
        bool dotflg = false;
        bool calflg = false;

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (resultflg)
            {
                display.Text = "0";
                resultflg = false;
                dotflg = false;
            }
            if (display.Text[display.Text.Length - 1] == '0' && firstflg)
            {
                display.Text = String.Concat(display.Text.Remove(display.Text.Length - 1), ((Button)sender).Text[0]);
            }
            else
            {
                display.Text = String.Concat(display.Text, ((Button)sender).Text[0]);
            }

            calflg = false;
            if (((Button)sender).Text[0] != '0')
                firstflg = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (calflg) return;
            if (display.Text[display.Text.Length - 1] == '.') display.Text = String.Concat(display.Text, "0");
            display.Text = String.Concat(display.Text, ((Button)sender).Text);

            calflg = true;
            dotflg = false;
            firstflg = true;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (dotflg) return;
            if (calflg)
            {
                display.Text = String.Concat(display.Text, "0.");
            }
            else
            {
                display.Text = String.Concat(display.Text, ".");
            }
            calflg = false;
            dotflg = true;
            firstflg = false;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (resultflg) return;

            double temp = Cal.cal_text(display.Text);
            display.Text = string.Concat(display.Text," = ", temp.ToString());
            calflg = true;
            dotflg = true;
            firstflg = true;
            resultflg = true;
        }

        public Form1()
        {
            InitializeComponent();

        }


    }
}
