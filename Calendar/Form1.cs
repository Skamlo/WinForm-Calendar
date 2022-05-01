using System;
using System.Windows.Forms;
using Calendar.ClassData;
using Calendar.ClassFunctions;
using Calendar.UserControls;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.getAllProperites();

            Data.Form1.form1 = this;
            Data.Form1.panelLeft = panelLeftButtons;
            Data.Form1.panelRight = panelRightButtons;
            Data.Form1.panelContainer = panelContainer;
            Data.Form1.dateButton = btnDate;
            Data.Form1.addEventButton = btnAddEventTopRight;

            // Adding UserControlCalendar to panelContainer
            UserControlCalendar calendar = new UserControls.UserControlCalendar();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(calendar);
            btnAddEventTopRight.Visible = false;
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            CalendarFunctions.refreshDateButton(btnDate);

            // framework
            Framework.refreshSizeForm1(panelContainer, panelRightButtons, this.Size.Width, this.Size.Height);
            Framework.refreshSizeCalendar(panelContainer.Controls[0], Data.UserControlCalendar.listButtons,
                Data.UserControlCalendar.listLabels, this.Size.Width, this.Size.Height);

            // colors
            Colors.refreshColorForm1(this, panelLeftButtons, panelRightButtons, panelContainer, btnAddEventTopRight);

            // language
            Language.refreshDaysOfWeekLabels(Data.UserControlCalendar.listLabels);
            this.Text = Language.currentLanguage.FormsNames.form1Calendar;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // general:
            Data.currentPage = "settings";
            UserControlSettings settings = new UserControls.UserControlSettings();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(settings);
            panelContainer.AutoScroll = true;

            // buttons visible:
            btnDate.Visible = false;
            btnMonthUp.Visible = false;
            btnMonthDown.Visible = false;
            btnAddEventTopRight.Visible = false;

            // set size
            Framework.refreshSizeSettings(panelContainer.Controls[0], Data.UserControlSettings.slider, this.Size.Width);

            // language
            this.Text = Language.currentLanguage.FormsNames.form1Settings;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            // general:
            Data.currentPage = "calendar";
            UserControlCalendar calendar = new UserControls.UserControlCalendar();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(calendar);
            panelContainer.AutoScroll = false;
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            CalendarFunctions.refreshDateButton(btnDate);
            Language.refreshDaysOfWeekLabels(Data.UserControlCalendar.listLabels);

            // buttons visible:
            btnDate.Visible = true;
            btnMonthUp.Visible = true;
            btnMonthDown.Visible = true;
            btnAddEventTopRight.Visible = false;

            // set sizes:
            Framework.refreshSizeCalendar(panelContainer.Controls[0],
                    Data.UserControlCalendar.listButtons, Data.UserControlCalendar.listLabels,
                    this.Size.Width, this.Size.Height);

            // language
            this.Text = Language.currentLanguage.FormsNames.form1Calendar;
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            // general:
            Data.currentPage = "events";
            UserControlEvents events = new UserControls.UserControlEvents();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(events);
            panelContainer.AutoScroll = false;

            // buttons visible:
            btnDate.Visible = false;
            btnMonthUp.Visible = false;
            btnMonthDown.Visible = false;
            btnAddEventTopRight.Visible = true;

            // set sizes:
            EventsDisplay.refreshFLPEvents(Data.UserControlEvents.FLP);
            Framework.refreshSizeEvents(panelContainer.Controls[0], Data.UserControlEvents.FLP, Data.UserControlEvents.smallLeftTop,
                    this.Size.Width, this.Size.Height);

            // colors
            btnAddEventTopRight.BackColor = Colors.CurrentColors.front;

            // language
            this.Text = Language.currentLanguage.FormsNames.form1Events;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            FormDate fdate = new FormDate();
            fdate.ShowDialog();
        }

        private void btnMonthUp_Click(object sender, EventArgs e)
        {
            Date.currentDateTime = Date.currentDateTime.AddMonths(-1);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            CalendarFunctions.refreshDateButton(btnDate);
            Language.refreshDaysOfWeekLabels(Data.UserControlCalendar.listLabels);
        }

        private void btnMonthDown_Click(object sender, EventArgs e)
        {
            Date.currentDateTime = Date.currentDateTime.AddMonths(1);
            CalendarFunctions.refreshCalendar(Data.UserControlCalendar.listButtons, Date.currentDateTime);
            CalendarFunctions.refreshDateButton(btnDate);
            Language.refreshDaysOfWeekLabels(Data.UserControlCalendar.listLabels);
        }

        private void btnAddEventTopRight_Click(object sender, EventArgs e)
        {
            FormAddEvent fAddDate = new FormAddEvent();
            fAddDate.ShowDialog();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Framework.refreshSizeForm1(panelContainer, panelRightButtons, this.Size.Width, this.Size.Height);

            if (Data.currentPage == "calendar")
            {
                Framework.refreshSizeCalendar(panelContainer.Controls[0],
                    Data.UserControlCalendar.listButtons, Data.UserControlCalendar.listLabels,
                    this.Size.Width, this.Size.Height);
            }
            else if (Data.currentPage == "settings")
            {
                Framework.refreshSizeSettings(panelContainer.Controls[0], Data.UserControlSettings.slider, this.Size.Width);
            }
            else if (Data.currentPage == "events")
            {
                Framework.refreshSizeEvents(panelContainer.Controls[0], Data.UserControlEvents.FLP,
                    Data.UserControlEvents.smallLeftTop,
                    this.Size.Width, this.Size.Height);
            }
        }
    }
}
