using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Calendar.ClassData;
using Calendar.ClassFunctions;

namespace Calendar.UserControls
{
    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {
            // clear
            Data.UserControlSettings.listRadioButtonClockSystem.Clear();
            Data.UserControlSettings.listRadioButtonStyle.Clear();
            Data.UserControlSettings.listRadioButtonWritingMethod.Clear();
            Data.UserControlSettings.listLabels.Clear();
            Data.UserControlSettings.listRadioButtonFirstDay.Clear();

            // labels
            Data.UserControlSettings.listLabels.Add(lblLanguage);
            Data.UserControlSettings.listLabels.Add(lblStyles);
            Data.UserControlSettings.listLabels.Add(lblFirstDay);
            Data.UserControlSettings.listLabels.Add(lblWritingMethod);
            Data.UserControlSettings.listLabels.Add(lblClockSystem);

            // radio button first day
            Data.UserControlSettings.listRadioButtonFirstDay.Add(rbtnMonday);
            Data.UserControlSettings.listRadioButtonFirstDay.Add(rbtnSunday);

            // comboBoxLangage
            Data.UserControlSettings.comboBoxLanguage = cbxLanguage;

            // slider
            Data.UserControlSettings.slider = pctbxSlider;

            // radio button writing method
            Data.UserControlSettings.listRadioButtonWritingMethod.Add(rbtnDMY);
            Data.UserControlSettings.listRadioButtonWritingMethod.Add(rbtnMDY);
            Data.UserControlSettings.listRadioButtonWritingMethod.Add(rbtnYMD);
            Data.UserControlSettings.listRadioButtonWritingMethod.Add(rbtnYDM);
            Data.UserControlSettings.listRadioButtonWritingMethod.Add(rbtnMYD);
            Data.UserControlSettings.listRadioButtonWritingMethod.Add(rbtnDYM);

            // radio button style
            Data.UserControlSettings.listRadioButtonStyle.Add(rbtnRed);
            Data.UserControlSettings.listRadioButtonStyle.Add(rbtnGreen);
            Data.UserControlSettings.listRadioButtonStyle.Add(rbtnBlue);
            Data.UserControlSettings.listRadioButtonStyle.Add(rbtnCustom);

            // radio button clock system
            Data.UserControlSettings.listRadioButtonClockSystem.Add(rbtnClockSystem12);
            Data.UserControlSettings.listRadioButtonClockSystem.Add(rbtnClockSystem24);

            //-------------------------------------------------------------------------

            // colors
            Colors.refreshColorSettings(this, panelStyles, panelFirstDay, panelWritingMethod, panelClockSystem);
            pctbxSlider.Refresh();

            // refresh checks in radio buttons
            if (Data.currentStyle == "red")
            {
                rbtnRed.Checked = true;

                pctbxSlider.Visible = false;
                lblFirstDay.Location = new Point(lblFirstDay.Location.X, lblFirstDay.Location.Y - 44);
                panelFirstDay.Location = new Point(panelFirstDay.Location.X, panelFirstDay.Location.Y - 44);
                lblWritingMethod.Location = new Point(lblWritingMethod.Location.X, lblWritingMethod.Location.Y - 44);
                panelWritingMethod.Location = new Point(panelWritingMethod.Location.X, panelWritingMethod.Location.Y - 44);
                lblClockSystem.Location = new Point(lblClockSystem.Location.X, lblClockSystem.Location.Y - 44);
                panelClockSystem.Location = new Point(panelClockSystem.Location.X, panelClockSystem.Location.Y - 44);
            }
            else if (Data.currentStyle == "green")
            {
                rbtnGreen.Checked = true;

                pctbxSlider.Visible = false;
                lblFirstDay.Location = new Point(lblFirstDay.Location.X, lblFirstDay.Location.Y - 44);
                panelFirstDay.Location = new Point(panelFirstDay.Location.X, panelFirstDay.Location.Y - 44);
                lblWritingMethod.Location = new Point(lblWritingMethod.Location.X, lblWritingMethod.Location.Y - 44);
                panelWritingMethod.Location = new Point(panelWritingMethod.Location.X, panelWritingMethod.Location.Y - 44);
                lblClockSystem.Location = new Point(lblClockSystem.Location.X, lblClockSystem.Location.Y - 44);
                panelClockSystem.Location = new Point(panelClockSystem.Location.X, panelClockSystem.Location.Y - 44);
            }
            else if (Data.currentStyle == "blue")
            {
                rbtnBlue.Checked = true;

                pctbxSlider.Visible = false;
                lblFirstDay.Location = new Point(lblFirstDay.Location.X, lblFirstDay.Location.Y - 44);
                panelFirstDay.Location = new Point(panelFirstDay.Location.X, panelFirstDay.Location.Y - 44);
                lblWritingMethod.Location = new Point(lblWritingMethod.Location.X, lblWritingMethod.Location.Y - 44);
                panelWritingMethod.Location = new Point(panelWritingMethod.Location.X, panelWritingMethod.Location.Y - 44);
                lblClockSystem.Location = new Point(lblClockSystem.Location.X, lblClockSystem.Location.Y - 44);
                panelClockSystem.Location = new Point(panelClockSystem.Location.X, panelClockSystem.Location.Y - 44);
            }
            else if (Data.currentStyle == "custom")
            {
                rbtnCustom.Checked = true;
            }

            if (Data.currentFirstDay == "monday") { rbtnMonday.Checked = true; }
            else if (Data.currentFirstDay == "sunday") { rbtnSunday.Checked = true; }

            if (Data.currentWritingMethod == "DMY") { rbtnDMY.Checked = true; }
            else if (Data.currentWritingMethod == "MDY") { rbtnMDY.Checked = true; }
            else if (Data.currentWritingMethod == "YMD") { rbtnYMD.Checked = true; }
            else if (Data.currentWritingMethod == "YDM") { rbtnYDM.Checked = true; }
            else if (Data.currentWritingMethod == "MYD") { rbtnMYD.Checked = true; }
            else if (Data.currentWritingMethod == "DYM") { rbtnDYM.Checked = true; }

            if (Data.currentClockSystem == "12") { rbtnClockSystem12.Checked = true; }
            else if (Data.currentClockSystem == "24") { rbtnClockSystem24.Checked = true; }

            // language
            Language.refreshSettingsNames(Data.UserControlSettings.listLabels,
                                          Data.UserControlSettings.comboBoxLanguage,
                                          Data.UserControlSettings.listRadioButtonStyle,
                                          Data.UserControlSettings.listRadioButtonFirstDay,
                                          Data.UserControlSettings.listRadioButtonWritingMethod,
                                          Data.UserControlSettings.listRadioButtonClockSystem);
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLanguage.Text == Language.English.Settings.ComboBoxLanguage.english ||
                cbxLanguage.Text == Language.Polish.Settings.ComboBoxLanguage.english)
            {
                Data.currentLanguage = "english";
                Language.currentLanguageToEngilsh();
                Settings.setLanguage("english");
            }
            else if (cbxLanguage.Text == Language.English.Settings.ComboBoxLanguage.polish ||
                     cbxLanguage.Text == Language.Polish.Settings.ComboBoxLanguage.polish)
            {
                Data.currentLanguage = "polish";
                Language.currentLanguageToPolish();
                Settings.setLanguage("polish");
            }
            Language.refreshSettingsNames(Data.UserControlSettings.listLabels,
                                          Data.UserControlSettings.comboBoxLanguage,
                                          Data.UserControlSettings.listRadioButtonStyle,
                                          Data.UserControlSettings.listRadioButtonFirstDay,
                                          Data.UserControlSettings.listRadioButtonWritingMethod,
                                          Data.UserControlSettings.listRadioButtonClockSystem);

            Data.Form1.form1.Text = Language.currentLanguage.FormsNames.form1Settings;
        }

        // Styles
        private void rbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (Data.currentStyle == "custom")
            {
                Settings.turnOffSlider(this, pctbxSlider, Data.UserControlSettings.listLabels,
                                   panelFirstDay, panelWritingMethod, panelClockSystem);
            }
            Data.currentStyle = "red";
            Colors.CurrentColors.back = Colors.Style1.back;
            Colors.CurrentColors.mid = Colors.Style1.mid;
            Colors.CurrentColors.front = Colors.Style1.front;

            // save color in json
            Settings.setStyle(Colors.CurrentColors.back, Colors.CurrentColors.mid, Colors.CurrentColors.front);

            // refresh colors
            Colors.refreshColorForm1(Data.Form1.form1, Data.Form1.panelLeft, Data.Form1.panelRight,
                                     Data.Form1.panelContainer, Data.Form1.addEventButton);
            Colors.refreshColorSettings(this, panelStyles, panelFirstDay, panelWritingMethod, panelClockSystem);
        }
        private void rbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (Data.currentStyle == "custom")
            {
                Settings.turnOffSlider(this, pctbxSlider, Data.UserControlSettings.listLabels,
                                   panelFirstDay, panelWritingMethod, panelClockSystem);
            }
            Data.currentStyle = "green";
            Colors.CurrentColors.back = Colors.Style2.back;
            Colors.CurrentColors.mid = Colors.Style2.mid;
            Colors.CurrentColors.front = Colors.Style2.front;

            // save color in json
            Settings.setStyle(Colors.CurrentColors.back, Colors.CurrentColors.mid, Colors.CurrentColors.front);

            // refresh colors
            Colors.refreshColorForm1(Data.Form1.form1, Data.Form1.panelLeft, Data.Form1.panelRight,
                                     Data.Form1.panelContainer, Data.Form1.addEventButton);
            Colors.refreshColorSettings(this, panelStyles, panelFirstDay, panelWritingMethod, panelClockSystem);
        }
        private void rbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (Data.currentStyle == "custom")
            {
                Settings.turnOffSlider(this, pctbxSlider, Data.UserControlSettings.listLabels,
                                   panelFirstDay, panelWritingMethod, panelClockSystem);
            }
            Data.currentStyle = "blue";
            Colors.CurrentColors.back = Colors.Style3.back;
            Colors.CurrentColors.mid = Colors.Style3.mid;
            Colors.CurrentColors.front = Colors.Style3.front;

            // save color in json
            Settings.setStyle(Colors.CurrentColors.back, Colors.CurrentColors.mid, Colors.CurrentColors.front);

            // refresh colors
            Colors.refreshColorForm1(Data.Form1.form1, Data.Form1.panelLeft, Data.Form1.panelRight,
                                     Data.Form1.panelContainer, Data.Form1.addEventButton);
            Colors.refreshColorSettings(this, panelStyles, panelFirstDay, panelWritingMethod, panelClockSystem);
        }
        private void rbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentStyle = "custom";
            pctbxSlider.Refresh();
            Settings.turnOnSlider(this, pctbxSlider, Data.UserControlSettings.listLabels,
                                   panelFirstDay, panelWritingMethod, panelClockSystem);
        }

        // First day
        private void rbtnMonday_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentFirstDay = "monday";
            Settings.setFirstDay("monday");
        }
        private void rbtnSunday_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentFirstDay = "sunday";
            Settings.setFirstDay("sunday");
        }

        // Writing method
        private void rbtnDMY_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentWritingMethod = "DMY";
            Settings.setWritingMethod("DMY");
        }
        private void rbtnMDY_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentWritingMethod = "MDY";
            Settings.setWritingMethod("MDY");
        }
        private void rbtnYMD_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentWritingMethod = "YMD";
            Settings.setWritingMethod("YMD");
        }
        private void rbtnYDM_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentWritingMethod = "YDM";
            Settings.setWritingMethod("YDM");
        }
        private void rbtnMYD_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentWritingMethod = "MYD";
            Settings.setWritingMethod("MYD");
        }
        private void rbtnDYM_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentWritingMethod = "DYM";
            Settings.setWritingMethod("DYM");
        }

        // Clock system
        private void rbtnClockSystem12_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentClockSystem = "12";
            Settings.setClockSystem("12");
        }
        private void rbtnClockSystem24_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentClockSystem = "24";
            Settings.setClockSystem("24");
        }

        // Slider
        Pen penWhite = new Pen(Color.White);
        int XPosition = 14; // przedział [14; 592]
        bool mouse = false;
        bool firstTime = true;

        private void pctbxSlider_Paint(object sender, PaintEventArgs e)
        {
            if (firstTime)
            {
                if (Settings.colorToHue(Colors.CurrentColors.front) < 0)
                {
                    XPosition = (int)((6 + Settings.colorToHue(Colors.CurrentColors.front)) / 6 * 578) + 14;
                }
                else
                {
                    XPosition = (int)(Settings.colorToHue(Colors.CurrentColors.front) / 6 * 578) + 14;
                }

                double XPosInDouble = XPosition;

                SolidBrush zipColor = new SolidBrush(Settings.hueToColor((XPosInDouble - 14) / 578 * 6, 1, 0.5));

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(penWhite, XPosition - 13, 4, 26, 26);
                e.Graphics.FillEllipse(zipColor, XPosition - 13, 4, 26, 26);

                firstTime = false;
            }
            else
            {
                double XPosInDouble = XPosition;
                Colors.CurrentColors.back = Settings.hueToColor((XPosInDouble - 14) / 578 * 6, 0.1, 0.1);
                Colors.CurrentColors.mid = Settings.hueToColor((XPosInDouble - 14) / 578 * 6, 0.2, 0.2);
                Colors.CurrentColors.front = Settings.hueToColor((XPosInDouble - 14) / 578 * 6, 0.5, 0.5);

                SolidBrush zipColor = new SolidBrush(Settings.hueToColor((XPosInDouble - 14) / 578 * 6, 1, 0.5));

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(penWhite, XPosition - 13, 4, 26, 26);
                e.Graphics.FillEllipse(zipColor, XPosition - 13, 4, 26, 26);
            }
        }

        private void pctbxSlider_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            XPosition = Settings.XPositionValidation(e.X);
            pctbxSlider.Refresh();
        }

        private void pctbxSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                XPosition = Settings.XPositionValidation(e.X);
                pctbxSlider.Refresh();
            }
        }

        private void pctbxSlider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
            Settings.setStyle(Colors.CurrentColors.back, Colors.CurrentColors.mid, Colors.CurrentColors.front);
        }
    }
}
