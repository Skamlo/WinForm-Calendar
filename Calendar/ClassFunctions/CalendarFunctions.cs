using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Calendar.ClassData;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -methods which are refreshing the text in the buttons
//      -methods which change the currentDateTime

namespace Calendar.ClassFunctions
{
    public static class CalendarFunctions
    {
        public static void refreshCalendar(List<Button> listButtons, DateTime time)
        {
            int firstDay = 1;
            int lastDay;

            // creating timeTemporary - first day of month
            DateTime timeTemporary = time.AddDays(-(time.Day - 1));
            
            // first day calculating
            if (Data.currentFirstDay == "monday")
            {
                if (((int)timeTemporary.DayOfWeek) == 0)
                {
                    firstDay = 7;
                }
                else
                {
                    firstDay = ((int)timeTemporary.DayOfWeek);
                }
            }
            else if (Data.currentFirstDay == "sunday")
            {
                firstDay = ((int)timeTemporary.DayOfWeek) + 1;
            }

            // calculating number of days in month
            while (true)
            {
                timeTemporary = timeTemporary.AddDays(1);
                Data.UserControlCalendar.listLabels[6].Text = timeTemporary.Day.ToString() + ",";
                if (timeTemporary.Day == 1)
                {
                    break;
                }
            }
            timeTemporary = timeTemporary.AddDays(-1);

            // calcualting last day
            lastDay = firstDay + timeTemporary.Day - 1;

            timeTemporary = timeTemporary.AddDays(-(timeTemporary.Day - 1));
            timeTemporary = timeTemporary.AddDays(-(firstDay - 1));

            for (int i = 0; i < firstDay - 1; i++)
            {
                listButtons[i].Text = timeTemporary.Day.ToString();
                timeTemporary = timeTemporary.AddDays(1);
                listButtons[i].ForeColor = Color.Gray;
            }

            for (int i = firstDay - 1; i < lastDay; i++)
            {
                listButtons[i].Text = timeTemporary.Day.ToString();
                timeTemporary = timeTemporary.AddDays(1);
                listButtons[i].ForeColor = Color.White;
            }

            for (int i = lastDay; i < 42; i++)
            {
                listButtons[i].Text = timeTemporary.Day.ToString();
                timeTemporary = timeTemporary.AddDays(1);
                listButtons[i].ForeColor = Color.Gray;
            }

            Colors.refreshColorCalendar(Data.UserControlCalendar.UC, Data.UserControlCalendar.listLabels,
                                        Data.UserControlCalendar.listButtons, firstDay, lastDay);
       }

        public static void refreshDateButton(Button btnDate)
        {
            btnDate.Text = Language.currentLanguage.Date.months[Date.currentDateTime.Month - 1] +
                           " " + Date.currentDateTime.Year;
        }

        public static void refreshFormDateButtons(List<Button> listButtons, Button yearMonthButton,
                                                  Button btnUp, Button btnDown, DateTime time)
        {
            if (Data.FormDate.currentPage == "year")
            {
                yearMonthButton.Text = Language.currentLanguage.Date.months[Date.currentDateTime.Month - 1];
                btnUp.Visible = true;
                btnDown.Visible = true;

                int iter = 0;
                for (int i = time.Year - 5; i < time.Year + 7; i++)
                {
                    listButtons[iter].Text = i.ToString();
                    iter++;
                }
            }
            else if (Data.FormDate.currentPage == "month")
            {
                yearMonthButton.Text = Date.currentDateTime.Year.ToString(); ;
                btnUp.Visible = false;
                btnDown.Visible = false;

                for (int i = 0; i < 12; i++)
                {
                    listButtons[i].Text = Language.currentLanguage.Date.monthShortcuts[i];
                }
            }
            Colors.refreshColorFormDateButtons(Data.FormDate.listButtons, Date.currentFormDateTime);
        }

        public static void clickFormDateButton(DateTime time, int numberOfButton) 
        {
            if (Data.FormDate.currentPage == "year")
            {
                Date.currentDateTime = time.AddYears(-6 + numberOfButton);
            }
            else if (Data.FormDate.currentPage == "month")
            {
                Date.currentDateTime = Date.currentDateTime.AddMonths(-(Date.currentDateTime.Month - 1));
                Date.currentDateTime = Date.currentDateTime.AddMonths(numberOfButton - 1);
            }
        }
    }
}
