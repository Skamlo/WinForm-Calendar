using System;
using System.IO;
using System.Windows.Forms;
using Calendar.ClassData;
using Calendar.ClassFunctions;

namespace Calendar.UserControls
{
    public partial class UserControlEvent : UserControl
    {
        public UserControlEvent()
        {
            InitializeComponent();
        }

        private void UserControlEvent_Load(object sender, EventArgs e)
        {
            // colors
            Colors.refreshColorEvent(this, panelDate);
        }

        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime addDate;
        private DateTime editDate;
        private int id;

        public string Title
        {
            get { return title; }
            set { title = value; lblTitle.Text = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; lblDesription.Text = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; lblStartDate.Text = EventsDisplay.dateTimeToStringValidation(value); }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; lblEndDate.Text = EventsDisplay.dateTimeToStringValidation(value); }
        }
        public DateTime AddDate
        {
            get { return addDate; }
            set { addDate = value; }
        }
        public DateTime EditDate
        {
            get { return editDate; }
            set { editDate = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void setAddDateLabel()
        {
            if (addDate.Year   == editDate.Year   &&
                addDate.Month  == editDate.Month  &&
                addDate.Day    == editDate.Day    &&
                addDate.Minute == editDate.Minute &&
                addDate.Second == editDate.Second)
            {
                lblAddDate.Text = Language.currentLanguage.Events.addDate + ": " +
                              EventsDisplay.dateTimeToStringValidation(addDate);
            }
            else
            {
                lblAddDate.Text = Language.currentLanguage.Events.addDate + ": " +
                              EventsDisplay.dateTimeToStringValidation(addDate) + "     " +
                              Language.currentLanguage.Events.editDate + ": " +
                              EventsDisplay.dateTimeToStringValidation(editDate);
            }
        }

        public void setTimeBetweenLabel()
        {
            lblTimeBetween.Text = EventsDisplay.timeBetween(startDate, endDate);
        }

        private void UserControlEvent_SizeChanged(object sender, EventArgs e)
        {
            Framework.refreshSizeEvent(lblTitle, lblDesription, lblAddDate, panelDate, this.Size.Width);
        }

        private void UserControlEvent_BackColorChanged(object sender, EventArgs e)
        {
            if (Data.isUserControlEventColorChange)
            {
                Colors.refreshColorEvent(this, panelDate);
            }
        }

        // MouseEnter
        private void UserControlEvent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblTitle_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblStartDate_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblEndDate_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void panelDate_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblTimeBetween_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblDesription_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblAddDate_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }

        // MouseLeave
        private void UserControlEvent_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void lblTitle_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void lblStartDate_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void lblEndDate_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void panelDate_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void lblTimeBetween_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void lblDesription_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void lblAddDate_MouseLeave(object sender, EventArgs e)
        {
            if (Data.currentUCEventId != id)
            {
                this.BackColor = Colors.CurrentColors.mid;
                panelDate.BackColor = Colors.CurrentColors.mid;
            }
        }

        // Click
        private void UserControlEvent_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblStartDate_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblEndDate_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void panelDate_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblTimeBetween_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblDesription_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
        private void lblAddDate_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = true;
            Data.UserControlEvents.buttonEdit.Visible = true;
            Data.currentUCEventId = id;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            this.BackColor = Colors.CurrentColors.front;
            panelDate.BackColor = Colors.CurrentColors.front;
        }
    }
}
