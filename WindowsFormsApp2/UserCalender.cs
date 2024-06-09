using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserCalender : UserControl
    {
        List<Label> labelList = new List<Label>();
        public UserCalender()
        {
            InitializeComponent();
            labelList.Add(day1);
            labelList.Add(day2);
            labelList.Add(day3);
            labelList.Add(day4);
            labelList.Add(day5);
            labelList.Add(day6);
            labelList.Add(day7);
            labelList.Add(day8);
            labelList.Add(day9);
            labelList.Add(day10);
            labelList.Add(day11);
            labelList.Add(day12);
            labelList.Add(day13);
            labelList.Add(day14);
            labelList.Add(day15);
            labelList.Add(day16);
            labelList.Add(day17);
            labelList.Add(day18);
            labelList.Add(day19);
            labelList.Add(day20);
            labelList.Add(day21);
            labelList.Add(day22);
            labelList.Add(day23);
            labelList.Add(day24);
            labelList.Add(day25);
            labelList.Add(day26);
            labelList.Add(day27);
            labelList.Add(day28);
            labelList.Add(day29);
            labelList.Add(day30);
            labelList.Add(day31);
            labelList.Add(day32);
            labelList.Add(day33);
            labelList.Add(day34);
            labelList.Add(day35);

            switch (DateTime.Now.Month)
            {
                case 1:
                    monthCombo.Text = "January";
                    break;
                case 2:
                    monthCombo.Text = "February";
                    break;
                case 3:
                    monthCombo.Text = "March";
                    break;
                case 4:
                    monthCombo.Text = "April";
                    break;
                case 5:
                    monthCombo.Text = "May";
                    break;
                case 6:
                    monthCombo.Text = "June";
                    break;
                case 7:
                    monthCombo.Text = "July";
                    break;
                case 8:
                    monthCombo.Text = "August";
                    break;
                case 9:
                    monthCombo.Text = "September";
                    break;
                case 10:
                    monthCombo.Text = "October";
                    break;
                case 11:
                    monthCombo.Text = "November";
                    break;
                case 12:
                    monthCombo.Text = "December";
                    break;
            }
            
            yearComboBox.Text = DateTime.Now.Year.ToString();
            showDate();
        }
        
        private void monthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDate();
        }

        public void showDate()
        {            
            day27.BackColor = Color.Gainsboro;
            int month = 0;
            if (monthCombo.Text == "January")
            {
                month = 1;
            }

            else if (monthCombo.Text == "February")
            {
                month = 2;
            }

            else if (monthCombo.Text == "March")
            {
                month = 3;
            }

            else if (monthCombo.Text == "April")
            {
                month = 4;
            }

            else if (monthCombo.Text == "May")
            {
                month = 5;
            }

            else if (monthCombo.Text == "June")
            {
                month = 6;
            }

            else if (monthCombo.Text == "July")
            {
                month = 7;
            }

            else if (monthCombo.Text == "August")
            {
                month = 8;
            }

            else if (monthCombo.Text == "September")
            {
                month = 9;
            }

            else if (monthCombo.Text == "October")
            {
                month = 10;
            }

            else if (monthCombo.Text == "November")
            {
                month = 11;
            }

            else if (monthCombo.Text == "December")
            {
                month = 12;
            }

            int year = Convert.ToInt32(yearComboBox.Text);
            Console.WriteLine(month + " " + year);
            int day = 1;
            int day1 = 1;
            int endDate = 0;
            
            DateTime date = new DateTime(year, month, day);
            string str = date.DayOfWeek.ToString();
            Console.WriteLine(date.Month + " " + date.Year + " " + str);
            
            if (date.Month == 1 || date.Month==3 || date.Month==5 || date.Month==7 || date.Month==8 || date.Month==10 || date.Month==12)
            {
                endDate = 31;
            }

            else
            {
                endDate = 30;
            }

            if (year % 4 == 0)
            {
                if (month == 2)
                {
                    endDate = 29;
                }
            }

            int index = 0;
            string startDay = "";

            switch (str)
            {
                case "Sunday":
                    index = 0;
                    startDay = "sun";
                    break;

                case "Monday":
                    index = 1;
                    startDay = "Mon";
                    break;

                case "Tueday":
                    index = 2;
                    startDay = "Tue";
                    break;

                case "Wednesday":
                    index = 3;
                    startDay = "Wed";
                    break;

                case "Thursday":
                    index = 4;
                    startDay = "Thu";
                    break;

                case "Friday":
                    index = 5;
                    startDay = "Fri";
                    break;

                case "Saturday":
                    index = 6;
                    startDay = "Sat";
                    break;
            }

            int count = 0;            

            int cnt = 0;
            
            int dateValue = 1;
            for (int i = index; i < labelList.Count; i++)
            {
                labelList[i].Text = dateValue.ToString();
                dateValue++;
                if(month==DateTime.Now.Month && dateValue == DateTime.Now.Day)
                {
                    labelList[i].BackColor = Color.LightSteelBlue;
                }
                else
                {
                    labelList[i].BackColor = Color.Gainsboro;
                }
                if (dateValue > endDate+1)
                {
                    labelList[i].Text = "";
                }
                
            }
            for (int i = 0; i < index; i++)
            {
                labelList[i].Text = dateValue.ToString();
                dateValue++;
                if (dateValue > endDate+1)
                {
                    labelList[i].Text = "";
                }
            }
            day1 = 1;
            cnt = 0;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDate();
        }
    }
}
