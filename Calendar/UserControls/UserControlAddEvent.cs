using System;
using System.IO;
using System.Windows.Forms;
using Calendar.ClassData;

namespace Calendar.UserControls
{
    public partial class UserControlAddEvent : UserControl
    {
        public UserControlAddEvent()
        {
            InitializeComponent();
        }

        private void UserControlAddEvent_Load(object sender, EventArgs e)
        {
            // language
            lblAddNewEvent.Text = Language.currentLanguage.Events.addNewEvent;

            // colors
            Colors.refreshColorAddEvent(this);
        }

        private void UserControlAddEvent_SizeChanged(object sender, EventArgs e)
        {
            Framework.refreshSizeAddEvent(lblAddNewEvent, this.Size.Width);
        }

        // MouseEnter
        private void UserControlAddEvent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
        }
        private void pctbxAddNewEvent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
        }
        private void lblAddNewEvent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.CurrentColors.front;
        }

        // MouseLeave
        private void UserControlAddEvent_MouseLeave(object sender, EventArgs e)
        {
            if (!Data.isFormAddEventOpen)
            {
                this.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void pctbxAddNewEvent_MouseLeave(object sender, EventArgs e)
        {
            if (!Data.isFormAddEventOpen)
            {
                this.BackColor = Colors.CurrentColors.mid;
            }
        }
        private void lblAddNewEvent_MouseLeave(object sender, EventArgs e)
        {
            if (!Data.isFormAddEventOpen)
            {
                this.BackColor = Colors.CurrentColors.mid;
            }
        }

        // Click
        private void UserControlAddEvent_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = false;
            Data.UserControlEvents.buttonEdit.Visible = false;
            Data.currentUCEventId = 0;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles - 1; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            Data.isFormAddEventOpen = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void pctbxAddNewEvent_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = false;
            Data.UserControlEvents.buttonEdit.Visible = false;
            Data.currentUCEventId = 0;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles - 1; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            Data.isFormAddEventOpen = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void lblAddNewEvent_Click(object sender, EventArgs e)
        {
            Data.UserControlEvents.buttonDelete.Visible = false;
            Data.UserControlEvents.buttonEdit.Visible = false;
            Data.currentUCEventId = 0;

            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length;

            Data.isUserControlEventColorChange = true;
            for (int i = 0; i < numberOfFiles - 1; i++)
            {
                Data.UserControlEvents.FLP.Controls[i].BackColor = Colors.CurrentColors.mid;
            }
            Data.isUserControlEventColorChange = false;

            Data.isFormAddEventOpen = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
    }
}
