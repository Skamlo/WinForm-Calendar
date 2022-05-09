using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;
using Calendar.ClassData;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -methods that they save and get settings
//      -methods around color slider in settings

namespace Calendar.ClassFunctions
{
    public static class Settings
    {
        public static void getAllProperites()
        {
            getLanguage();
            getStyle();
            getFirstDay();
            getWritingMethod();
            getClockSystem();
        }

        public static void getLanguage()
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string fileName = "language";

            string languageInString = File.ReadAllText(projectPath + @"\Data\Settings\" + fileName + ".json");

            string language = JsonConvert.DeserializeObject<string>(languageInString);

            Data.currentLanguage = language;

            if (Data.currentLanguage == "english")
            {
                Language.currentLanguageToEngilsh();
            }
            else if (Data.currentLanguage == "polish")
            {
                Language.currentLanguageToPolish();
            }
        }

        public static void getStyle()
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string fileName = "style";

            string styleInString = File.ReadAllText(projectPath + @"\Data\Settings\" + fileName + ".json");

            SetStyle style = JsonConvert.DeserializeObject<SetStyle>(styleInString);

            Colors.CurrentColors.back = style.back;
            Colors.CurrentColors.mid = style.mid;
            Colors.CurrentColors.front = style.front;

            if (style.back == Colors.Style1.back &&
                style.mid == Colors.Style1.mid &&
                style.front == Colors.Style1.front)
            {
                Data.currentStyle = "red";
            }
            else if (style.back == Colors.Style2.back &&
                     style.mid == Colors.Style2.mid &&
                     style.front == Colors.Style2.front)
            {
                Data.currentStyle = "green";
            }
            else if (style.back == Colors.Style3.back &&
                     style.mid == Colors.Style3.mid &&
                     style.front == Colors.Style3.front)
            {
                Data.currentStyle = "blue";
            }
            else
            {
                Data.currentStyle = "custom";
            }
        }

        public static void getFirstDay()
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string fileName = "firstDay";

            string firstDayInString = File.ReadAllText(projectPath + @"\Data\Settings\" + fileName + ".json");

            string firstDay = JsonConvert.DeserializeObject<string>(firstDayInString);

            Data.currentFirstDay = firstDay;
        }

        public static void getWritingMethod()
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string fileName = "writingMethod";

            string writingMethodInString = File.ReadAllText(projectPath + @"\Data\Settings\" + fileName + ".json");

            string writingMethod = JsonConvert.DeserializeObject<string>(writingMethodInString);

            Data.currentWritingMethod = writingMethod;
        }

        public static void getClockSystem()
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string fileName = "clockSystem";

            string clockSystemInString = File.ReadAllText(projectPath + @"\Data\Settings\" + fileName + ".json");

            string clockSystem = JsonConvert.DeserializeObject<string>(clockSystemInString);

            Data.currentClockSystem = clockSystem;
        }

        public static void setLanguage(string newLanguage)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string newLanguageInString = JsonConvert.SerializeObject(newLanguage);

            string fileName = "language";

            File.WriteAllText(projectPath + @"\Data\Settings\" + fileName + ".json", newLanguageInString);
        }

        public static void setStyle(Color newBackColor, Color newMidColor, Color newFontColor)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            SetStyle newStyle = new SetStyle();
            newStyle.back = newBackColor;
            newStyle.mid = newMidColor;
            newStyle.front = newFontColor;

            string newStyleInString = JsonConvert.SerializeObject(newStyle);

            string fileName = "style";

            File.WriteAllText(projectPath + @"\Data\Settings\" + fileName + ".json", newStyleInString);
        }

        public static void setFirstDay(string newFirstDay)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string newFirstDayInString = JsonConvert.SerializeObject(newFirstDay);

            string fileName = "firstDay";

            File.WriteAllText(projectPath + @"\Data\Settings\" + fileName + ".json", newFirstDayInString);
        }

        public static void setWritingMethod(string newWritingMethod)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string newWritingMethodInString = JsonConvert.SerializeObject(newWritingMethod);

            string fileName = "writingMethod";

            File.WriteAllText(projectPath + @"\Data\Settings\" + fileName + ".json", newWritingMethodInString);
        }

        public static void setClockSystem(string newClockSystem)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string newClockSystemInString = JsonConvert.SerializeObject(newClockSystem);

            string fileName = "clockSystem";

            File.WriteAllText(projectPath + @"\Data\Settings\" + fileName + ".json", newClockSystemInString);
        }

        //----------------------------------------------------------------------------------------
        // Slider

        public static void turnOffSlider(Control UC, PictureBox slider, List<Label> listlabels,
                                         Panel panel1, Panel panel2, Panel panel3)
        {
            slider.Visible = false;

            UC.Size = new Size(UC.Size.Width, UC.Size.Height - 88);
            listlabels[2].Location = new Point(listlabels[2].Location.X, listlabels[2].Location.Y - 88);
            listlabels[3].Location = new Point(listlabels[3].Location.X, listlabels[3].Location.Y - 88);
            listlabels[4].Location = new Point(listlabels[4].Location.X, listlabels[4].Location.Y - 88);
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 88);
            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y - 88);
            panel3.Location = new Point(panel3.Location.X, panel3.Location.Y - 88);
        }

        public static void turnOnSlider(Control UC, PictureBox slider, List<Label> listlabels,
                                        Panel panel1, Panel panel2, Panel panel3)
        {
            slider.Visible = true;

            UC.Size = new Size(UC.Size.Width, UC.Size.Height + 44);
            listlabels[2].Location = new Point(listlabels[2].Location.X, listlabels[2].Location.Y + 44);
            listlabels[3].Location = new Point(listlabels[3].Location.X, listlabels[3].Location.Y + 44);
            listlabels[4].Location = new Point(listlabels[4].Location.X, listlabels[4].Location.Y + 44);
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 44);
            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + 44);
            panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + 44);
        }

        /// <param name="color"></param>
        /// <returns>hue in interval [0, 6]</returns>
        public static double colorToHue(Color color)
        {
            // the math behind this calcualtions: https://www.rapidtables.com/convert/color/rgb-to-hsl.html

            double Red = color.R;
            Red = Red / 255;
            double Green = color.G;
            Green = Green / 255;
            double Blue = color.B;
            Blue = Blue / 255;

            double min = 0.5;
            double max = 0.5;
            int whichColor = 1;

            double hue = 1;

            // min
            if (Red <= Green && Red <= Blue)
            {
                min = Red;
            }
            else if (Green <= Red && Green <= Blue)
            {
                min = Green;
            }
            else if (Blue <= Red && Blue <= Green)
            {
                min = Blue;
            }

            // max
            if (Red >= Green && Red >= Blue)
            {
                max = Red;
                whichColor = 1;
            }
            else if (Green >= Red && Green >= Blue)
            {
                max = Green;
                whichColor = 2;
            }
            else if (Blue >= Red && Blue >= Green)
            {
                max = Blue;
                whichColor = 3;
            }

            // hue
            if (whichColor == 1)
            {
                hue = (Green - Blue) / (max - min);
            }
            else if (whichColor == 2)
            {
                hue = 2 + (Blue - Red) / (max - min);
            }
            else if (whichColor == 3)
            {
                hue = 4 + (Red - Green) / (max - min);
            }

            return hue;
        }

        /// <param name="hue">hue in interval [0, 6]</param>
        /// <param name="lightness">lightness in interval [0, 1]</param>
        /// <param name="saturate">saturate in interval [0, 1]</param>
        /// <returns></returns>
        public static Color hueToColor(double hue, double saturate, double lightness)
        {
            // the math behind this calcualtions: https://www.rapidtables.com/convert/color/hsl-to-rgb.html

            double C = (1 - Math.Abs(2 * lightness - 1)) * saturate;
            double X = C * (1 - Math.Abs((hue % 2) - 1));
            double m = lightness - (C / 2);

            Color color = Color.FromArgb(0, 0, 0);

            double Red = 0.5;
            double Green = 0.5;
            double Blue = 0.5;

            if (hue * 60 < 60)
            {
                Red = (C + m) * 255;
                Green = (X + m) * 255;
                Blue = (0 + m) * 255;
            }
            else if (hue * 60 >= 60 && hue * 60 < 120)
            {
                Red = (X + m) * 255;
                Green = (C + m) * 255;
                Blue = (0 + m) * 255;
            }
            else if (hue * 60 >= 120 && hue * 60 < 180)
            {
                Red = (0 + m) * 255;
                Green = (C + m) * 255;
                Blue = (X + m) * 255;
            }
            else if (hue * 60 >= 180 && hue * 60 < 240)
            {
                Red = (0 + m) * 255;
                Green = (X + m) * 255;
                Blue = (C + m) * 255;
            }
            else if (hue * 60 >= 240 && hue * 60 < 300)
            {
                Red = (X + m) * 255;
                Green = (0 + m) * 255;
                Blue = (C + m) * 255;
            }
            else if (hue * 60 >= 300)
            {
                Red = (C + m) * 255;
                Green = (0 + m) * 255;
                Blue = (X + m) * 255;
            }

            color = Color.FromArgb(((int)Red), ((int)Green), ((int)Blue));

            return color;
        }

        public static int XPositionValidation(int XPosition)
        {
            // przedział [14; 592]
            if (XPosition < 14)
            {
                return 14;
            }
            else if (XPosition >= 14 && XPosition <= 592)
            {
                return XPosition;
            }
            else if (XPosition > 592)
            {
                return 592;
            }
            else
            {
                // this is to prevent errors
                return 289; // any value
            }
        }
    }

    public class SetStyle
    {
        public Color back;
        public Color mid;
        public Color front;
    }
}
