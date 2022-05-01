using System;
using System.Windows.Forms;
using Calendar.ClassData;
using Calendar.ClassFunctions;

namespace Calendar.UserControls
{
    public partial class UserControlEvents : UserControl
    {
        public UserControlEvents()
        {
            InitializeComponent();
        }

        private void UserControlEvents_Load(object sender, EventArgs e)
        {
            Data.UserControlEvents.FLP = FLPEvents;
            Data.UserControlEvents.smallLeftTop = panelSmallLeftTop;
            Data.UserControlEvents.buttonEdit = btnEdit;
            Data.UserControlEvents.buttonDelete = btnDelete;

            btnDelete.Visible = false;
            btnEdit.Visible = false;

            // colors
            Colors.refreshColorEvents(this, FLPEvents, panelSmallLeftTop);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Data.isEdit = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClassFunctions.Events.deleteEvent(Data.currentUCEventId);
            EventsDisplay.refreshFLPEvents(Data.UserControlEvents.FLP);
        }
    }
}
