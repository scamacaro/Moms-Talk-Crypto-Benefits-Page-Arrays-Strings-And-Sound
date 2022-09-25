/*
 Sanyerlis Camacaro 09/26/2022 - CSC202 - Startup Company - Moms Talk Crypto Company Benefits - add arrays, strings, and sound - Sancamac@uat.edu
Log: As of September 21st,2022 I believe this project will take me to complete in less than 8 hours splitted in 2-3 days.
09/23/2022 Started rewatching the class to follow along with the examples, and added strings and functions Starting time was at 9:05pm, I've finished following along the class video around 11:30pm.
On 9/24/2022 I continued working from 9pm until 10:30 pm with and finished adding arrays and sound.

To Complete this StartUp Company Benifits project I've expected to complete the project within the most 3 days in total of 8 hours. In total I took 2 days where I work around for 2 hours each day
to complete the assigment. I believe that it took longer than I've expected because I had to redo my design form again since it was deleted from my computer.
Next time, I will try to organize myself better with home responsabilities and rewatch the classes ahead of time and ask questions when it's needed. 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Moms_Talk_Crypto_Company_Benefits_Arrays__Strings__and_Sound
{
    public partial class Form1 : Form
    {
        int[] nums = new int[100];
        Random rand = new Random();
        int die;
        string str1, str2;
        string textFile = "readfile.txt";

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
            using (StreamWriter sw = File.AppendText(textFile))
            {
                sw.WriteLine(calcula_percentage.ToString());
            }

            using (StreamWriter sw = File.AppendText(textFile))// to append text - write format
            {
                sw.WriteLine(comboBox1.Text.ToString());
                sw.WriteLine(textBox1enteryoursalary.Text.ToString());
                sw.WriteLine(textBox2salarybonus.Text.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startdate = dobdateTimePicker1.Value;
            DateTime Enddate = dateTimePicker2.Value;
            PTOTextBox.Text = CalcAge(startdate, Enddate).ToString();
            using (StreamWriter sw = File.AppendText(textFile))
            {
                sw.WriteLine(startdate.ToString());
                sw.WriteLine(Enddate.ToString());
            }

            using (StreamWriter sw = File.AppendText(textFile))// to append text - write format
            {
                sw.WriteLine(dobdateTimePicker1.Text.ToString());
                sw.WriteLine(dateTimePicker2.Text.ToString());
                sw.WriteLine(PTOTextBox.Text.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {

                }
        }
        public long CalcAge(System.DateTime StartDate, System.DateTime EndDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
            age = (long)(ts.Days / 365);
            using (StreamWriter sw = File.AppendText(textFile))
            {
                sw.WriteLine(StartDate.ToString());
                sw.WriteLine(EndDate.ToString());
            }

            using (StreamWriter sw = File.AppendText(textFile))// to append text - write format
            {
                sw.WriteLine(age.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {

                }

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
                using (StreamWriter sw = File.AppendText(textFile))//to append text - write format
                {
                    sw.WriteLine(HourWeeklyTextBox.Text.ToString());
                }
                //reading file
                string[] lines = File.ReadAllLines(textFile);//to read appended text
                using (StreamReader file = new StreamReader(textFile))
                    foreach (string line in lines)
                    {

                    }
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
            using (StreamWriter sw = File.AppendText(textFile))
            {
                sw.WriteLine(random.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {

                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str1 = NametextBox.Text;
            str2 = VerifyButton.Text;
            if (str1 == str2)
                MessageBox.Show("Accepted, Click Accept and Generate Username To Proceed");
            using (StreamWriter sw = File.AppendText(textFile))//to append text - write format
            {
                sw.WriteLine(NametextBox.Text.ToString());
                sw.WriteLine(VerifyButton.Text.ToString());
            }
            //reading file
            string[] lines = File.ReadAllLines(textFile);//to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {

                }
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
            String strnum1 = "";
            for (int i = 0; i < 100; i++)
            {
                nums[i] = rand.Next(0, 1000);
                strnum1 = strnum1 + nums[i].ToString() + " ";
            }
            textBox1.Text = strnum1;
            using (StreamWriter sw = File.AppendText(textFile))//to append text - write format
            {
                sw.WriteLine(textBox1.Text.ToString());
            }
            //reading file
            string[] lines = File.ReadAllLines(textFile);//to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {

                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Array.Sort(nums);
            String strnum1 = "";
            for (int i = 0; i < 100; i++)
            {
                nums[i] = rand.Next(0, 1000);
                strnum1 = strnum1 + nums[i].ToString() + " ";
            }
            textBox1.Text = strnum1;
            using (StreamWriter sw = File.AppendText(textFile))//to append text - write format
            {
                sw.WriteLine(textBox1.Text.ToString());
            }
            //reading file
            string[] lines = File.ReadAllLines(textFile);//to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {

                }
        }

        private void PassCodebutton_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\sanye\source\repos\Moms Talk Crypto Company Benefits Arrays, Strings, and Sound\Chime.wav");
            simpleSound.Play();

            str1 = NametextBox.Text;
            if (str1.Length >5)
            {
                str2 = str1.Substring(0, 5);
                str2 = str2.Trim();
                NametextBox.Text = str2;
                using (StreamWriter sw = File.AppendText(textFile))//to append text - write format
                {
                    sw.WriteLine(NametextBox.Text.ToString());
                }
                //reading file
                string[] lines = File.ReadAllLines(textFile);//to read appended text
                using (StreamReader file = new StreamReader(textFile))
                    foreach (string line in lines)
                    {

                    }
            }
        }
    }
}
