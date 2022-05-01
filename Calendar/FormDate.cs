using System;
using System.Windows.Forms;
using Calendar.ClassData;
using Calendar.ClassFunctions;

namespace Calendar
{
    public partial class FormDate : Form
    {
        public FormDate()
        {
            InitializeComponent();
        }

        private void FormDate_Load(object sender, EventArgs e)
        {
            Data.FormDate.listButtons.Clear();
            // A
            Data.FormDate.listButtons.Add(btnA1);
            Data.FormDate.listButtons.Add(btnA2);
            Data.FormDate.listButtons.Add(btnA3);
            Data.FormDate.listButtons.Add(btnA4);
            // B
            Data.FormDate.listButtons.Add(btnB1);
            Data.FormDate.listButtons.Add(btnB2);
            Data.FormDate.listButtons.Add(btnB3);
            Data.FormDate.listButtons.Add(btnB4);
            // C
            Data.FormDate.listButtons.Add(btnC1);
            Data.FormDate.listButtons.Add(btnC2);
            Data.FormDate.listButtons.Add(btnC3);
            Data.FormDate.listButtons.Add(btnC4);

            Date.currentFormDateTime = Date.currentDateTime;

            // framework
            Framework.refreshSizeFormDate(btnMonthYear, btnMonthYearUp, btnMonthYearDown,
                Data.FormDate.listButtons, this.Size.Width, this.Size.Height);

            // colors
            this.BackColor = Colors.CurrentColors.back;
            CalendarFunctions.refreshFormDateButtons(Data.FormDate.listButtons, btnMonthYear,
                                                     btnMonthYearUp, btnMonthYearDown, Date.currentFormDateTime);
            

            // buttons visible
            btnMonthYearUp.Visible = false;
            btnMonthYearDown.Visible = false;

            // language
            this.Text = Language.currentLanguage.FormsNames.formDate;
        }

        private void btnMonthYear_Click(object sender, EventArgs e)
        {
            if (Data.FormDate.currentPage == "year")
            {
                Data.FormDate.currentPage = "month";
            }
            else if (Data.FormDate.currentPage == "month")
            {
                Date.currentFormDateTime = Date.currentDateTime;
                Data.FormDate.currentPage = "year";
            }
            CalendarFunctions.refreshFormDateButtons(Data.FormDate.listButtons, btnMonthYear,
                                                     btnMonthYearUp, btnMonthYearDown, Date.currentFormDateTime);
            Framework.refreshSizeFormDate(btnMonthYear, btnMonthYearUp, btnMonthYearDown, Data.FormDate.listButtons,
                                          this.Size.Width, this.Size.Height);
        }

        private void btnMonthYearUp_Click(object sender, EventArgs e)
        {
            Date.currentFormDateTime = Date.currentFormDateTime.AddYears(-12);
            CalendarFunctions.refreshFormDateButtons(Data.FormDate.listButtons, btnMonthYear,
                                                     btnMonthYearUp, btnMonthYearDown, Date.currentFormDateTime);
        }

        private void btnMonthYearDown_Click(object sender, EventArgs e)
        {
            Date.currentFormDateTime = Date.currentFormDateTime.AddYears(12);
            CalendarFunctions.refreshFormDateButtons(Data.FormDate.listButtons, btnMonthYear,
                                                     btnMonthYearUp, btnMonthYearDown, Date.currentFormDateTime);
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 1);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnA2_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 2);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnA3_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 3);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnA4_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 4);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnB1_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 5);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnB2_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 6);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnB3_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 7);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnB4_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 8);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnC1_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 9);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnC2_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 10);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnC3_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 11);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }
        private void btnC4_Click(object sender, EventArgs e)
        {
            CalendarFunctions.clickFormDateButton(Date.currentFormDateTime, 12);
            CalendarFunctions.refreshDateButton(Data.Form1.dateButton);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            this.Close();
        }

        private void FormDate_SizeChanged(object sender, EventArgs e)
        {
            Framework.refreshSizeFormDate(btnMonthYear, btnMonthYearUp, btnMonthYearDown,
                Data.FormDate.listButtons, this.Size.Width, this.Size.Height);
        }

        private void FormDate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Data.FormDate.currentPage = "month";
        }
    }
}
