using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -current back, middle and front colors of user interface which contains RGB value
//      -3 styles structures (red, green, blue) which contains RGB values
//      -methods about colors (refreshing color for all forms and user controls)

namespace Calendar.ClassData
{
    public static class Colors
    {
        public struct CurrentColors
        {
            public static Color back = Style3.back;
            public static Color mid = Style3.mid;
            public static Color front = Style3.front;
        }

        public struct Style1 // Red
        {
            public static Color back = Color.FromArgb(28, 23, 23);   // 0°, 10%, 10% in HSL
            public static Color mid = Color.FromArgb(61, 41, 41);    // 0°, 20%, 20% in HSL
            public static Color front = Color.FromArgb(191, 64, 64); // 0°, 50%, 50% in HSL
        }

        public struct Style2 // Green
        {
            public static Color back = Color.FromArgb(23, 28, 23);   // 120°, 10%, 10% in HSL
            public static Color mid = Color.FromArgb(41, 61, 41);    // 120°, 20%, 20% in HSL
            public static Color front = Color.FromArgb(64, 191, 64); // 120°, 50%, 50% in HSL
        }

        public struct Style3 // Blue
        {
            public static Color back = Color.FromArgb(23, 23, 28);   // 240°, 10%, 10% in HSL
            public static Color mid = Color.FromArgb(41, 41, 61);    // 240°, 20%, 20% in HSL
            public static Color front = Color.FromArgb(64, 64, 191); // 240°, 50%, 50% in HSL
        }

        public struct CurrentCustomColor
        {
            public static Color back = Style1.back;
            public static Color mid = Style1.mid;
            public static Color front = Style1.front;
        }

        // Form1
        public static void refreshColorForm1(Form form, Panel leftTop, Panel rightTop, Panel container, Button btnAddEvent)
        {
            form.BackColor = CurrentColors.back;
            leftTop.BackColor = CurrentColors.back;
            rightTop.BackColor = CurrentColors.back;
            container.BackColor = CurrentColors.back;
            btnAddEvent.BackColor = CurrentColors.front;
        }

        // UserControlSettings
        public static void refreshColorSettings(Control UC, Panel styles, Panel firstDay, Panel writingMethod, Panel clockSystem)
        {
            UC.BackColor = CurrentColors.back;
            styles.BackColor = CurrentColors.back;
            firstDay.BackColor = CurrentColors.back;
            writingMethod.BackColor = CurrentColors.back;
            clockSystem.BackColor = CurrentColors.back;
        }

        // UserControlCalendar
        public static void refreshColorCalendar(Control UC, List<Label> listLabels,
                                                List<Button> listButtons, int firstDay, int lastDay)
        {
            UC.BackColor = CurrentColors.back;

            foreach (Label label in listLabels)
            {
                label.BackColor = CurrentColors.back;
            }

            for (int i = 0; i < firstDay - 1; i++)
            {
                listButtons[i].BackColor = CurrentColors.back;
            }

            for (int i = firstDay - 1; i < lastDay; i++)
            {
                listButtons[i].BackColor = CurrentColors.mid;

                if (Date.currentDateTime.Year == DateTime.Now.Year &&
                    Date.currentDateTime.Month == DateTime.Now.Month)
                {
                    if (Date.currentDateTime.Day == i - firstDay + 2)
                    {
                        listButtons[i].BackColor = CurrentColors.front;
                    }
                }
            }

            for (int i = lastDay; i < 42; i++)
            {
                listButtons[i].BackColor = CurrentColors.back;
            }
        }

        // UserControlEvents
        public static void refreshColorEvents(Control UC, FlowLayoutPanel FLPEvents, Panel smallLeftTop)
        {
            UC.BackColor = CurrentColors.mid;
            smallLeftTop.BackColor = CurrentColors.back;
            FLPEvents.BackColor = CurrentColors.back;
        }

        // FormDate
        public static void refreshColorFormDateButtons(List<Button> listButtons, DateTime time)
        {

            if (Data.FormDate.currentPage == "year")
            {
                int iter = 0;
                for (int i = time.Year - 5; i < time.Year + 7; i++)
                {
                    listButtons[iter].BackColor = Colors.CurrentColors.mid;
                    if (i == DateTime.Now.Year)
                    {
                        listButtons[iter].BackColor = Colors.CurrentColors.front;
                    }
                    iter++;
                }
            }
            else if (Data.FormDate.currentPage == "month")
            {
                for (int i = 0; i < 12; i++)
                {
                    listButtons[i].BackColor = Colors.CurrentColors.mid;
                    if (i + 1 == DateTime.Now.Month)
                    {
                        listButtons[i].BackColor = Colors.CurrentColors.front;
                    }
                }
            }
        }

        // FormAddEvent
        public static void refreshColorFormAddEvent(Control UC, List<TextBox> listTextBox, RichTextBox richTextBox,
                                                    Button btnSave, Button btnCancle)
        {
            UC.BackColor = CurrentColors.back;
            foreach (TextBox textBox in listTextBox)
            {
                textBox.BackColor = CurrentColors.mid;
            }
            richTextBox.BackColor = CurrentColors.mid;
            btnSave.BackColor = CurrentColors.front;
            btnCancle.BackColor = CurrentColors.mid;
        }

        // UserControlEvent
        public static void refreshColorEvent(Control UC, Panel panelDate)
        {
            UC.BackColor = CurrentColors.mid;
            panelDate.BackColor = CurrentColors.mid;
        }

        // UserControlAddEvent
        public static void refreshColorAddEvent(Control UC)
        {
            UC.BackColor = CurrentColors.mid;
        }
    }
}
