using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Calendar.ClassData;
using Calendar.ClassFunctions;

namespace Calendar
{
    public partial class FormAddEvent : Form
    {
        public FormAddEvent()
        {
            InitializeComponent();
        }

        private void FormAddEvent_Load(object sender, EventArgs e)
        {
            Data.FormAddEvent.listTextBoxes.Clear();
            Data.FormAddEvent.listTextBoxes.Add(txtbxTitle);
            Data.FormAddEvent.listTextBoxes.Add(txtbxStartDate);
            Data.FormAddEvent.listTextBoxes.Add(txtbxStartHour);
            Data.FormAddEvent.listTextBoxes.Add(txtbxEndDate);
            Data.FormAddEvent.listTextBoxes.Add(txtbxEndHour);

            // refresh start and end variables in date class
            if (!Data.isEdit) // not edit
            {
                if (!Data.isBtnCalendarClick) // not btnCalendarClick
                {
                    Date.FormAddEvent.startDate = DateTime.Now;
                    if (Date.FormAddEvent.startDate.Minute <= 30)
                    {
                        Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(-(Date.FormAddEvent.startDate.Minute - 1) + 29);
                    }
                    else if (Date.FormAddEvent.startDate.Minute > 30)
                    {
                        Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(-(Date.FormAddEvent.startDate.Minute - 1) + 59);
                    }
                    Date.FormAddEvent.endDate = Date.FormAddEvent.startDate.AddMinutes(30);
                }
                else // btnCalendarClick
                {
                    Date.FormAddEvent.startDate = Date.currentDateTime;
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddDays(-(Date.FormAddEvent.startDate.Day - 1));

                    // first day calculating
                    int firstDay = 0;
                    if (Data.currentFirstDay == "monday")
                    {
                        if (((int)Date.FormAddEvent.startDate.DayOfWeek) == 0)
                        {
                            firstDay = 7;
                        }
                        else
                        {
                            firstDay = ((int)Date.FormAddEvent.startDate.DayOfWeek);
                        }
                    }
                    else if (Data.currentFirstDay == "sunday")
                    {
                        firstDay = ((int)Date.FormAddEvent.startDate.DayOfWeek) + 1;
                    }

                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddDays(Data.numberOfClickButton - firstDay);

                    if (Date.FormAddEvent.startDate.Minute <= 30)
                    {
                        Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(-(Date.FormAddEvent.startDate.Minute - 1) + 29);
                    }
                    else if (Date.FormAddEvent.startDate.Minute > 30)
                    {
                        Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(-(Date.FormAddEvent.startDate.Minute - 1) + 59);
                    }

                    Date.FormAddEvent.endDate = Date.FormAddEvent.startDate.AddMinutes(30);
                }
            }
            else // edit
            {
                Date.FormAddEvent.startDate = Data.UserControlEvent.events[Data.currentUCEventId - 1].StartDate;
                Date.FormAddEvent.endDate = Data.UserControlEvent.events[Data.currentUCEventId - 1].EndDate;
            }

            // refresh start and end text boxes
            txtbxStartDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.startDate);
            txtbxStartHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.startDate);
            txtbxEndDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.endDate);
            txtbxEndHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.endDate);

            // refhresh timebetween
            lblTimeBetween.Text = EventsDisplay.timeBetween(Date.FormAddEvent.startDate, Date.FormAddEvent.endDate);

            // language
            if (!Data.isEdit) // not edit
            {
                txtbxTitle.Text = Language.currentLanguage.Events.title;
                txtbxDescription.Text = Language.currentLanguage.Events.description;
            }
            else // edit
            {
                txtbxTitle.Text = Data.UserControlEvent.events[Data.currentUCEventId - 1].Title;
                txtbxDescription.Text = Data.UserControlEvent.events[Data.currentUCEventId - 1].Description;
            }
            this.Text = Language.currentLanguage.FormsNames.formAddEvent;

            btnSave.Text = Language.currentLanguage.Events.save;
            btnCancle.Text = Language.currentLanguage.Events.cancle;

            // Framework
            Framework.refreshSizeFormAddEvent(Data.FormAddEvent.listTextBoxes, txtbxDescription, pctbxArrow,
                lblTimeBetween, btnSave, btnCancle,
                this.Size.Width, this.Size.Height);

            // Colors
            Colors.refreshColorFormAddEvent(this, Data.FormAddEvent.listTextBoxes, txtbxDescription, btnSave, btnCancle);
        }

        private void FormAddEvent_SizeChanged(object sender, EventArgs e)
        {
            Framework.refreshSizeFormAddEvent(Data.FormAddEvent.listTextBoxes, txtbxDescription, pctbxArrow,
                lblTimeBetween, btnSave, btnCancle,
                this.Size.Width, this.Size.Height);
        }

        private void txtbxStartDate_Leave(object sender, EventArgs e)
        {
            if (AddEvents.dateValidation(txtbxStartDate.Text, 1)) // correct
            {
                // years
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddYears(-(Date.FormAddEvent.startDate.Year - 1));
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddYears(Date.FormAddEvent.startDateValid.Year - 1);
                // months
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMonths(-(Date.FormAddEvent.startDate.Month - 1));
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMonths(Date.FormAddEvent.startDateValid.Month - 1);
                // days
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddDays(-(Date.FormAddEvent.startDate.Day - 1));
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddDays(Date.FormAddEvent.startDateValid.Day - 1);

                if ((Date.FormAddEvent.startDate.Year > Date.FormAddEvent.endDate.Year) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month > Date.FormAddEvent.endDate.Month) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month == Date.FormAddEvent.endDate.Month &&
                     Date.FormAddEvent.startDate.Day > Date.FormAddEvent.endDate.Day) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month == Date.FormAddEvent.endDate.Month &&
                     Date.FormAddEvent.startDate.Day == Date.FormAddEvent.endDate.Day &&
                     Date.FormAddEvent.startDate.Hour > Date.FormAddEvent.endDate.Hour) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month == Date.FormAddEvent.endDate.Month &&
                     Date.FormAddEvent.startDate.Day == Date.FormAddEvent.endDate.Day &&
                     Date.FormAddEvent.startDate.Hour == Date.FormAddEvent.endDate.Hour &&
                     Date.FormAddEvent.startDate.Minute > Date.FormAddEvent.endDate.Minute))
                {
                    Date.FormAddEvent.startDate = Date.FormAddEvent.endDate.AddMinutes(-30);
                    txtbxStartHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.startDate);
                }

                txtbxStartDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.startDate);
            }
            else // incorrect
            {
                if ((Date.FormAddEvent.startDate.Hour > Date.FormAddEvent.endDate.Hour) ||

                    (Date.FormAddEvent.startDate.Hour >= Date.FormAddEvent.endDate.Hour &&
                     Date.FormAddEvent.startDate.Minute > Date.FormAddEvent.endDate.Minute))
                {
                    Date.FormAddEvent.startDate = Date.FormAddEvent.endDate.AddMinutes(-30);
                    txtbxStartDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.startDate);
                    txtbxStartHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.startDate);
                }
                else
                {
                    // years
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddYears(-(Date.FormAddEvent.startDate.Year - 1));
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddYears(Date.FormAddEvent.endDate.Year - 1);
                    // months
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMonths(-(Date.FormAddEvent.startDate.Month - 1));
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMonths(Date.FormAddEvent.endDate.Month - 1);
                    // days
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddDays(-(Date.FormAddEvent.startDate.Day - 1));
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddDays(Date.FormAddEvent.endDate.Day - 1);

                    txtbxStartDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.startDate);
                }
            }

            lblTimeBetween.Text = EventsDisplay.timeBetween(Date.FormAddEvent.startDate, Date.FormAddEvent.endDate);
        }

        private void txtbxStartHour_Leave(object sender, EventArgs e)
        {
            if (AddEvents.hourValidation(txtbxStartHour.Text, 1)) // correct
            {
                if ((Date.FormAddEvent.startDateValid.Hour > Date.FormAddEvent.endDate.Hour) ||

                    (Date.FormAddEvent.startDateValid.Hour == Date.FormAddEvent.endDate.Hour &&
                     Date.FormAddEvent.startDateValid.Minute > Date.FormAddEvent.endDate.Minute))
                {
                    Date.FormAddEvent.startDate = Date.FormAddEvent.endDate.AddMinutes(-30);
                }
                else
                {
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddHours(-(Date.FormAddEvent.startDate.Hour - 1));
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddHours(Date.FormAddEvent.startDateValid.Hour - 1);

                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(-(Date.FormAddEvent.startDate.Minute - 1));
                    Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(Date.FormAddEvent.startDateValid.Minute - 1);
                }

                txtbxStartHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.startDate);
                txtbxStartDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.startDate);
            }
            else // incorrect
            {
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddHours(-(Date.FormAddEvent.startDate.Hour - 1));
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddHours(Date.FormAddEvent.endDate.Hour - 1);

                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(-(Date.FormAddEvent.startDate.Minute - 1));
                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(Date.FormAddEvent.endDate.Minute - 1);

                Date.FormAddEvent.startDate = Date.FormAddEvent.startDate.AddMinutes(-30);

                txtbxStartHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.startDate);
                txtbxStartDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.startDate);
            }

            lblTimeBetween.Text = EventsDisplay.timeBetween(Date.FormAddEvent.startDate, Date.FormAddEvent.endDate);
        }

        private void txtbxEndDate_Leave(object sender, EventArgs e)
        {
            if (AddEvents.dateValidation(txtbxEndDate.Text, 2)) // correct
            {
                // years
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddYears(-(Date.FormAddEvent.endDate.Year - 1));
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddYears(Date.FormAddEvent.endDateValid.Year - 1);
                // months
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMonths(-(Date.FormAddEvent.endDate.Month - 1));
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMonths(Date.FormAddEvent.endDateValid.Month - 1);
                // days
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddDays(-(Date.FormAddEvent.endDate.Day - 1));
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddDays(Date.FormAddEvent.endDateValid.Day - 1);

                if ((Date.FormAddEvent.startDate.Year > Date.FormAddEvent.endDate.Year) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month > Date.FormAddEvent.endDate.Month) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month == Date.FormAddEvent.endDate.Month &&
                     Date.FormAddEvent.startDate.Day > Date.FormAddEvent.endDate.Day) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month == Date.FormAddEvent.endDate.Month &&
                     Date.FormAddEvent.startDate.Day == Date.FormAddEvent.endDate.Day &&
                     Date.FormAddEvent.startDate.Hour > Date.FormAddEvent.endDate.Hour) ||

                    (Date.FormAddEvent.startDate.Year == Date.FormAddEvent.endDate.Year &&
                     Date.FormAddEvent.startDate.Month == Date.FormAddEvent.endDate.Month &&
                     Date.FormAddEvent.startDate.Day == Date.FormAddEvent.endDate.Day &&
                     Date.FormAddEvent.startDate.Hour == Date.FormAddEvent.endDate.Hour &&
                     Date.FormAddEvent.startDate.Minute > Date.FormAddEvent.endDate.Minute))
                {
                    Date.FormAddEvent.endDate = Date.FormAddEvent.startDate.AddMinutes(30);
                    txtbxEndHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.endDate);
                }

                txtbxEndDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.endDate);
            }
            else // incorrect
            {
                if ((Date.FormAddEvent.startDate.Hour > Date.FormAddEvent.endDate.Hour) ||

                    (Date.FormAddEvent.startDate.Hour >= Date.FormAddEvent.endDate.Hour &&
                     Date.FormAddEvent.startDate.Minute > Date.FormAddEvent.endDate.Minute))
                {
                    Date.FormAddEvent.endDate = Date.FormAddEvent.startDate.AddMinutes(30);
                    txtbxEndDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.endDate);
                    txtbxEndHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.endDate);
                }
                else
                {
                    // years
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddYears(-(Date.FormAddEvent.endDate.Year - 1));
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddYears(Date.FormAddEvent.startDate.Year - 1);
                    // months
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMonths(-(Date.FormAddEvent.endDate.Month - 1));
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMonths(Date.FormAddEvent.startDate.Month - 1);
                    // days
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddDays(-(Date.FormAddEvent.endDate.Day - 1));
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddDays(Date.FormAddEvent.startDate.Day - 1);

                    txtbxEndDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.endDate);
                }
            }

            lblTimeBetween.Text = EventsDisplay.timeBetween(Date.FormAddEvent.startDate, Date.FormAddEvent.endDate);
        }

        private void txtbxEndHour_Leave(object sender, EventArgs e)
        {
            if (AddEvents.hourValidation(txtbxEndHour.Text, 2)) // correct
            {
                if ((Date.FormAddEvent.endDateValid.Hour < Date.FormAddEvent.startDate.Hour) ||
                    
                    (Date.FormAddEvent.endDateValid.Hour == Date.FormAddEvent.startDate.Hour &&
                     Date.FormAddEvent.endDateValid.Minute < Date.FormAddEvent.startDate.Minute))
                {
                    Date.FormAddEvent.endDate = Date.FormAddEvent.startDate.AddMinutes(30);
                }
                else
                {
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddHours(-(Date.FormAddEvent.endDate.Hour - 1));
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddHours(Date.FormAddEvent.endDateValid.Hour - 1);

                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMinutes(-(Date.FormAddEvent.endDate.Minute - 1));
                    Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMinutes(Date.FormAddEvent.endDateValid.Minute - 1);
                }

                txtbxEndHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.endDate);
                txtbxEndDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.endDate);
            }
            else // incorrect
            {
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddHours(-(Date.FormAddEvent.endDate.Hour - 1));
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddHours(Date.FormAddEvent.startDate.Hour - 1);

                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMinutes(-(Date.FormAddEvent.endDate.Minute - 1));
                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMinutes(Date.FormAddEvent.startDate.Minute - 1);

                Date.FormAddEvent.endDate = Date.FormAddEvent.endDate.AddMinutes(-30);

                txtbxEndHour.Text = EventsDisplay.dateTimeToHourInStringValidation(Date.FormAddEvent.endDate);
                txtbxEndDate.Text = EventsDisplay.dateTimeToDateInStringValidation(Date.FormAddEvent.endDate);
            }

            lblTimeBetween.Text = EventsDisplay.timeBetween(Date.FormAddEvent.startDate, Date.FormAddEvent.endDate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Data.isEdit) // not edit
            {
                Event event_ = new Event();

                event_.Title = txtbxTitle.Text;
                event_.Description = txtbxDescription.Text;
                event_.StartDate = Date.FormAddEvent.startDate;
                event_.EndDate = Date.FormAddEvent.endDate;
                event_.AddDate = DateTime.Now;
                event_.EditDate = event_.AddDate;

                ClassFunctions.Events.saveEvent(event_);

                EventsDisplay.refreshFLPEvents(Data.UserControlEvents.FLP);
                this.Close();
            }
            else // edit
            {
                Event event_ = new Event();

                event_.Title = txtbxTitle.Text;
                event_.Description = txtbxDescription.Text;
                event_.StartDate = Date.FormAddEvent.startDate;
                event_.EndDate = Date.FormAddEvent.endDate;
                event_.AddDate = Data.UserControlEvent.events[Data.currentUCEventId - 1].AddDate;
                event_.EditDate = DateTime.Now;
                event_.Id = Data.currentUCEventId;

                ClassFunctions.Events.editEvent(event_, Data.currentUCEventId);

                EventsDisplay.refreshFLPEvents(Data.UserControlEvents.FLP);
                this.Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxTitle_TextChanged(object sender, EventArgs e)
        {
            txtbxTitle.ForeColor = Color.White;
        }

        private void txtbxDescription_TextChanged(object sender, EventArgs e)
        {
            txtbxDescription.ForeColor = Color.White;
        }

        private void FormAddEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isFormAddEventOpen = false;
            if (numberOfFiles > 0)
            {
                Data.UserControlEvents.FLP.Controls[numberOfFiles].BackColor = Colors.CurrentColors.mid;
            }

            Data.isEdit = false;
        }
    }
}
