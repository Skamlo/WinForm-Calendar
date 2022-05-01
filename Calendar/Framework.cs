using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Calendar.ClassData;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// -This class contains funtions that are used for refreshing sizes and locations of panels, buttons, labels etc.
// -This class are using when size of any form are changing

namespace Calendar
{
    public static class Framework
    {
        // Form1
        public static void refreshSizeForm1(Panel panelContainer, Panel panelRightButtons,
                                            int width, int height)
        {
            int widthInside = width - 20;
            int heightInside = height - 50;
            panelContainer.Size = new Size(widthInside, heightInside - 50);
            panelRightButtons.Location = new Point(widthInside - 270, panelRightButtons.Location.Y);
        }

        // UserControlSettings
        public static void refreshSizeSettings(Control UC, PictureBox slider, int width)
        {
            int widthInside = width - 20;

            UC.Size = new Size(widthInside - 22, UC.Size.Height);

            if (widthInside - 20 < 665 && widthInside - 20 > 605)
            {
                slider.Location = new Point((widthInside - 20 - 605) / 2, slider.Location.Y);
            }
            else if (widthInside - 20 >= 655)
            {
                slider.Location = new Point(30, slider.Location.Y);
            }
        }

        // UserControlCalendar
        public static void refreshSizeCalendar(Control UC, List<Button> listButtons, List<Label> listLabels,
                                               int width, int height)
        {
            int widthInside = width - 20; // min=606
            int heightInside = height - 100; //min=460

            int xLabelSize = (widthInside - 80) / 7;
            int yLabelSize = (int)((double)(heightInside - 75) * 5 / 77);

            int xButtonSize = (widthInside - 80) / 7;
            int yButtonSize = (int)((double)(heightInside - 75) * 12 / 77);

            UC.Size = new Size(widthInside, heightInside);

            // LABELS SIZE AND FONT SIZE
            foreach (Label label in listLabels)
            {
                label.Size = new Size(xLabelSize, yLabelSize);
                if (yLabelSize >= 2.5)
                {
                    label.Font = new Font("Segoe UI", (int)(yLabelSize / 2.5), FontStyle.Regular);
                }
                else
                {
                    label.Font = new Font("Segoe UI", 1, FontStyle.Regular);
                }
            }

            // LABELS LOCATION
            for (int i = 0; i < 7; i++)
            {
                listLabels[i].Location = new Point(10 + (i * (xLabelSize + 10)), 10);
            }

            // BUTTONS SIZE AND FONT SIZE
            foreach (Button button in listButtons)
            {
                button.Size = new Size(xButtonSize, yButtonSize);
                if (yButtonSize >= 4)
                {
                    if (xButtonSize > yButtonSize)
                    {
                        button.Font = new Font("Segoe UI", yButtonSize / 4, FontStyle.Regular);
                    }
                    else
                    {
                        button.Font = new Font("Segoe UI", xButtonSize / 4, FontStyle.Regular);
                    }
                }
                else
                {
                    button.Font = new Font("Segoe UI", 1, FontStyle.Regular);
                }
            }

            // BUTTONS LOCATION
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    listButtons[7 * y + x].Location = new Point(10 + ((xButtonSize + 10) * x),
                                                                15 + yLabelSize + ((yButtonSize + 10) * y));
                }
            }
        }

        // UserControlEvents
        public static void refreshSizeEvents(Control UC, FlowLayoutPanel FLP, Panel panelLeftTop,
                                             int width, int height)
        {
            int widthInside = width - 20; // min=606
            int heightInside = height - 100; //min=460

            UC.Size = new Size(widthInside, heightInside);

            FLP.Size = new Size(widthInside - 70, heightInside - 10);

            panelLeftTop.Size = new Size(widthInside, 10);

            int numberOfUC = FLP.Controls.Count;

            if (numberOfUC > 0)
            {
                for (int i = 0; i < numberOfUC; i++)
                {
                    if ((numberOfUC * 160) + 10 > heightInside)
                    {
                        FLP.Controls[i].Size = new Size(widthInside - 110 - 2, 150);
                    }
                    else
                    {
                        FLP.Controls[i].Size = new Size(widthInside - 90 - 2, 150);
                    }
                }
            }
        }

        // FormDate
        public static void refreshSizeFormDate(Button btnMonthYear, Button btnUp, Button btnDown,
                                               List<Button> listButtons,
                                               int width, int height)
        {
            int widthInside = width - 20;
            int heightInside = height - 50;

            int xButtonSize = (int)((double)(width) - 70) / 4;
            int yButtonSize = (int)((double)(heightInside) - 100) / 3;

            // set buttons size and font size
            foreach (Button button in listButtons)
            {
                button.Size = new Size(xButtonSize, yButtonSize);
                if (xButtonSize >= 5)
                {
                    if (Data.FormDate.currentPage == "year")
                    {
                        if (xButtonSize > 2 * yButtonSize)
                        {
                            button.Font = new Font("Segoe UI", yButtonSize / 3, FontStyle.Regular);
                        }
                        else
                        {
                            button.Font = new Font("Segoe UI", xButtonSize / 6, FontStyle.Regular);
                        }
                    }
                    else if (Data.FormDate.currentPage == "month")
                    {
                        if (xButtonSize > yButtonSize)
                        {
                            button.Font = new Font("Segoe UI", yButtonSize / 5, FontStyle.Regular);
                        }
                        else
                        {
                            button.Font = new Font("Segoe UI", ((int)(xButtonSize / 5.1)), FontStyle.Regular);
                        }
                    }
                }
                else
                {
                    button.Font = new Font("Segoe UI", 1, FontStyle.Regular);
                }
            }

            // set buttons location
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    listButtons[y * 4 + x].Location = new Point(10 + ((10 + xButtonSize) * x),
                                                                70 + ((10 + yButtonSize) * y));
                }
            }

            // set btnMonthYear size and location
            if (xButtonSize + 20 < 110)
            {
                btnMonthYear.Size = new Size((2 * xButtonSize + 10) - (110 - (xButtonSize + 20)), 50);
            }
            else
            {
                btnMonthYear.Size = new Size(2 * xButtonSize + 10, 50);
            }
            btnMonthYear.Location = new Point(20 + xButtonSize, 10);

            // set right buttons

            btnUp.Location = new Point(widthInside - 100, 10);
            btnDown.Location = new Point(widthInside - 50, 10);
        }

        // FormAddEvent
        public static void refreshSizeFormAddEvent(List<TextBox> listTextBoxes, RichTextBox richTextBox,
                                                   PictureBox pctbxArrow, Label labelBetween,
                                                   Button btnSave, Button btnCancle,
                                                   int width, int height)
        {
            int widthInside = width - 20;
            int heightInside = height - 50;

            // Title
            listTextBoxes[0].Size = new Size(widthInside - 59, 30);

            // Date
            int xTextBoxDateSize = (widthInside - 202) / 4;

            //      startDate
            listTextBoxes[1].Size = new Size(xTextBoxDateSize, 30);

            //      startHour
            listTextBoxes[2].Size = new Size(xTextBoxDateSize, 30);
            listTextBoxes[2].Location = new Point(52 + xTextBoxDateSize, 48);

            pctbxArrow.Location = new Point(57 + (2 * xTextBoxDateSize), 48);

            //      endDate
            listTextBoxes[3].Size = new Size(xTextBoxDateSize, 30);
            listTextBoxes[3].Location = new Point(92 + (2 * xTextBoxDateSize), 48);

            //      endHour
            listTextBoxes[4].Size = new Size(xTextBoxDateSize, 30);
            listTextBoxes[4].Location = new Point(97 + (3 * xTextBoxDateSize), 48);

            labelBetween.Location = new Point(102 + (4 * xTextBoxDateSize), 48);

            // Description
            richTextBox.Size = new Size(widthInside - 59, heightInside - 131);

            // Buttons
            btnSave.Location = new Point(widthInside - 206, heightInside - 41);
            btnCancle.Location = new Point(widthInside - 106, heightInside - 41);
        }

        // UserControlEvent
        public static void refreshSizeEvent(Label title, Label description, Label addDate, Panel panel, int width)
        {
            // Title
            title.Size = new Size(width - 457, 35);

            // Date (panel)
            panel.Location = new Point(20 + (width - 457), 10);

            // Description
            description.Size = new Size(width - 20, 48);

            // AddDate
            addDate.Size = new Size(width - 20, 20);
        }

        // UserControlAddEvent
        public static void refreshSizeAddEvent(Label label, int width)
        {
            label.Size = new Size(width - 160, 67);
        }
    }
}
