using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moms_Talk_Crypto_Company_Benefits_Arrays__Strings__and_Sound
{
    public partial class Form1 : Form
    {
        int die;
        string str1, str2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Moms Talk Crypto Company Benefits Page!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBonusbutton_Click(object sender, EventArgs e)
        {
            decimal calcula_percentage = (Convert.ToDecimal(comboBox1.Text) / 100) * Convert.ToDecimal(textBox1enteryoursalary.Text);
            textBox2salarybonus.Text = (decimal.Parse(textBox1enteryoursalary.Text) + calcula_percentage).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startdate = dobdateTimePicker1.Value;
            DateTime Enddate = dateTimePicker2.Value;
            PTOTextBox.Text = CalcAge(startdate, Enddate).ToString();
        }
        public long CalcAge(System.DateTime StartDate, System.DateTime EndDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
            age = (long)(ts.Days / 365);

            return age;
        }

        private void HourlyEarningsbutton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            die = random.Next(100, 10000);
            MessageBox.Show("Company Hourly Earnings =" + die);
            die++; //SC equivalent to die = die +1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result;
            string str = HourWeeklyTextBox.Text;
            if (int.TryParse(str, out result))
            {
                if (result <= 40)
                {
                    MessageBox.Show("You Have 3 Hours Of Earned PTO");
                }
                else if (result <=80)
                {
                    MessageBox.Show("You Have 6 Hours Of Earned PTO");
                }
            }
            else
            {
                MessageBox.Show("Not a Valid Integer");
            }
            try//if its not an integer it will catch the error
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("Enter Valid Hours");
                MessageBox.Show("Please Try Again!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            die = random.Next(1, 10);
            MessageBox.Show("Extra Vacation Days =" + die);
            die++; //SC equivalent to die = die +1;
            MessageBox.Show("Bonus JACKPOT =" + die);
            die = die + 8;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str1 = NametextBox.Text;
            str2 = VerifyButton.Text;
            if (str1 == str2)
                MessageBox.Show("Accepted, Click Accept and Generate Username To Proceed");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NametextBox.Text = NametextBox.Text.ToUpper();
        }

        private void PTOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void PassCodebutton_Click(object sender, EventArgs e)
        {
            str1 = NametextBox.Text;
            if (str1.Length >5)
            {
                str2 = str1.Substring(0, 5);
                str2 = str2.Trim();
                NametextBox.Text = str2;
            }
        }
    }
}
