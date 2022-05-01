using System;
using System.Windows.Forms;
using Calendar.ClassData;

namespace Calendar.UserControls
{
    public partial class UserControlCalendar : UserControl
    {
        public UserControlCalendar()
        {
            InitializeComponent();
        }

        private void UserControlCalendar_Load(object sender, EventArgs e)
        {
            Data.UserControlCalendar.listLabels.Clear();
            Data.UserControlCalendar.listButtons.Clear();

            // UserControl
            Data.UserControlCalendar.UC = this;

            // Labels
            Data.UserControlCalendar.listLabels.Add(lbl1);
            Data.UserControlCalendar.listLabels.Add(lbl2);
            Data.UserControlCalendar.listLabels.Add(lbl3);
            Data.UserControlCalendar.listLabels.Add(lbl4);
            Data.UserControlCalendar.listLabels.Add(lbl5);
            Data.UserControlCalendar.listLabels.Add(lbl6);
            Data.UserControlCalendar.listLabels.Add(lbl7);

            // Buttons
            // A
            Data.UserControlCalendar.listButtons.Add(btnA1);
            Data.UserControlCalendar.listButtons.Add(btnA2);
            Data.UserControlCalendar.listButtons.Add(btnA3);
            Data.UserControlCalendar.listButtons.Add(btnA4);
            Data.UserControlCalendar.listButtons.Add(btnA5);
            Data.UserControlCalendar.listButtons.Add(btnA6);
            Data.UserControlCalendar.listButtons.Add(btnA7);
            // B
            Data.UserControlCalendar.listButtons.Add(btnB1);
            Data.UserControlCalendar.listButtons.Add(btnB2);
            Data.UserControlCalendar.listButtons.Add(btnB3);
            Data.UserControlCalendar.listButtons.Add(btnB4);
            Data.UserControlCalendar.listButtons.Add(btnB5);
            Data.UserControlCalendar.listButtons.Add(btnB6);
            Data.UserControlCalendar.listButtons.Add(btnB7);
            // C
            Data.UserControlCalendar.listButtons.Add(btnC1);
            Data.UserControlCalendar.listButtons.Add(btnC2);
            Data.UserControlCalendar.listButtons.Add(btnC3);
            Data.UserControlCalendar.listButtons.Add(btnC4);
            Data.UserControlCalendar.listButtons.Add(btnC5);
            Data.UserControlCalendar.listButtons.Add(btnC6);
            Data.UserControlCalendar.listButtons.Add(btnC7);
            // D
            Data.UserControlCalendar.listButtons.Add(btnD1);
            Data.UserControlCalendar.listButtons.Add(btnD2);
            Data.UserControlCalendar.listButtons.Add(btnD3);
            Data.UserControlCalendar.listButtons.Add(btnD4);
            Data.UserControlCalendar.listButtons.Add(btnD5);
            Data.UserControlCalendar.listButtons.Add(btnD6);
            Data.UserControlCalendar.listButtons.Add(btnD7);
            // E
            Data.UserControlCalendar.listButtons.Add(btnE1);
            Data.UserControlCalendar.listButtons.Add(btnE2);
            Data.UserControlCalendar.listButtons.Add(btnE3);
            Data.UserControlCalendar.listButtons.Add(btnE4);
            Data.UserControlCalendar.listButtons.Add(btnE5);
            Data.UserControlCalendar.listButtons.Add(btnE6);
            Data.UserControlCalendar.listButtons.Add(btnE7);
            // F
            Data.UserControlCalendar.listButtons.Add(btnF1);
            Data.UserControlCalendar.listButtons.Add(btnF2);
            Data.UserControlCalendar.listButtons.Add(btnF3);
            Data.UserControlCalendar.listButtons.Add(btnF4);
            Data.UserControlCalendar.listButtons.Add(btnF5);
            Data.UserControlCalendar.listButtons.Add(btnF6);
            Data.UserControlCalendar.listButtons.Add(btnF7);
        }

        private void btnA1_Click(object sender, EventArgs e) // 1
        {
            Data.numberOfClickButton = 1;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnA2_Click(object sender, EventArgs e) // 2
        {
            Data.numberOfClickButton = 2;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnA3_Click(object sender, EventArgs e) // 3
        {
            Data.numberOfClickButton = 3;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnA4_Click(object sender, EventArgs e) // 4
        {
            Data.numberOfClickButton = 4;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnA5_Click(object sender, EventArgs e) // 5
        {
            Data.numberOfClickButton = 5;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnA6_Click(object sender, EventArgs e) // 6
        {
            Data.numberOfClickButton = 6;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnA7_Click(object sender, EventArgs e) // 7
        {
            Data.numberOfClickButton = 7;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnB1_Click(object sender, EventArgs e) // 8
        {
            Data.numberOfClickButton = 8;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnB2_Click(object sender, EventArgs e) // 9
        {
            Data.numberOfClickButton = 9;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnB3_Click(object sender, EventArgs e) // 10
        {
            Data.numberOfClickButton = 10;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnB4_Click(object sender, EventArgs e) // 11
        {
            Data.numberOfClickButton = 11;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnB5_Click(object sender, EventArgs e) // 12
        {
            Data.numberOfClickButton = 12;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnB6_Click(object sender, EventArgs e) // 13
        {
            Data.numberOfClickButton = 13;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnB7_Click(object sender, EventArgs e) // 14
        {
            Data.numberOfClickButton = 14;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnC1_Click(object sender, EventArgs e) // 15
        {
            Data.numberOfClickButton = 15;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnC2_Click(object sender, EventArgs e) // 16
        {
            Data.numberOfClickButton = 16;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnC3_Click(object sender, EventArgs e) // 17
        {
            Data.numberOfClickButton = 17;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnC4_Click(object sender, EventArgs e) // 18
        {
            Data.numberOfClickButton = 18;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnC5_Click(object sender, EventArgs e) // 19
        {
            Data.numberOfClickButton = 19;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnC6_Click(object sender, EventArgs e) // 20
        {
            Data.numberOfClickButton = 20;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnC7_Click(object sender, EventArgs e) // 21
        {
            Data.numberOfClickButton = 21;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnD1_Click(object sender, EventArgs e) // 22
        {
            Data.numberOfClickButton = 22;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnD2_Click(object sender, EventArgs e) // 23
        {
            Data.numberOfClickButton = 23;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnD3_Click(object sender, EventArgs e) // 24
        {
            Data.numberOfClickButton = 24;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnD4_Click(object sender, EventArgs e) // 25
        {
            Data.numberOfClickButton = 25;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnD5_Click(object sender, EventArgs e) // 26
        {
            Data.numberOfClickButton = 26;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnD6_Click(object sender, EventArgs e) // 27
        {
            Data.numberOfClickButton = 27;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnD7_Click(object sender, EventArgs e) // 28
        {
            Data.numberOfClickButton = 28;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnE1_Click(object sender, EventArgs e) // 29
        {
            Data.numberOfClickButton = 29;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnE2_Click(object sender, EventArgs e) // 30
        {
            Data.numberOfClickButton = 30;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnE3_Click(object sender, EventArgs e) // 31
        {
            Data.numberOfClickButton = 31;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnE4_Click(object sender, EventArgs e) // 32
        {
            Data.numberOfClickButton = 32;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnE5_Click(object sender, EventArgs e) // 33
        {
            Data.numberOfClickButton = 33;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnE6_Click(object sender, EventArgs e) // 34
        {
            Data.numberOfClickButton = 34;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnE7_Click(object sender, EventArgs e) // 35
        {
            Data.numberOfClickButton = 35;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnF1_Click(object sender, EventArgs e) // 36
        {
            Data.numberOfClickButton = 36;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnF2_Click(object sender, EventArgs e) // 37
        {
            Data.numberOfClickButton = 37;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnF3_Click(object sender, EventArgs e) // 38
        {
            Data.numberOfClickButton = 38;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnF4_Click(object sender, EventArgs e) // 39
        {
            Data.numberOfClickButton = 39;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnF5_Click(object sender, EventArgs e) // 40
        {
            Data.numberOfClickButton = 40;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnF6_Click(object sender, EventArgs e) // 41
        {
            Data.numberOfClickButton = 41;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
        private void btnF7_Click(object sender, EventArgs e) // 42
        {
            Data.numberOfClickButton = 42;
            Data.isBtnCalendarClick = true;
            FormAddEvent formadd = new FormAddEvent();
            formadd.ShowDialog();
        }
    }
}
