using System.Collections.Generic;
using System.Windows.Forms;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -diffrent types of data in static variables
//      -references to WinForms objects in static variables

namespace Calendar.ClassData
{
    public static class Data
    {
        public static string currentPage = "calendar";
        public static string currentLanguage = "english";
        public static string currentStyle = "style1";
        public static string currentFirstDay = "monday";
        public static string currentWritingMethod = "DMY";
        public static string currentClockSystem = "24";

        public static char[] legalSymbols = { ':', ';', '.', ',', '/', '\\', '|', '#', '*', '^', '\"', '\'', '&', '~', '`', '@' };
        public static char[] legalLetters = { 'A', 'a', 'P', 'p', 'M', 'm' };

        public static bool isEdit = false;
        public static int currentUCEventId = 0;
        public static bool isFormAddEventOpen = false;
        public static bool isUserControlEventColorChange = false;

        public static bool isBtnCalendarClick = false;
        public static int numberOfClickButton = 0;

        public struct UserControlSettings
        {
            public static List<Label> listLabels = new List<Label>();
            public static ComboBox comboBoxLanguage = new ComboBox();
            public static PictureBox slider = new PictureBox();
            public static List<RadioButton> listRadioButtonStyle = new List<RadioButton>();
            public static List<RadioButton> listRadioButtonFirstDay = new List<RadioButton>();
            public static List<RadioButton> listRadioButtonWritingMethod = new List<RadioButton>();
            public static List<RadioButton> listRadioButtonClockSystem = new List<RadioButton>();
        }

        public struct UserControlCalendar
        {
            public static Control UC = new Control();
            public static List<Label> listLabels = new List<Label>();
            public static List<Button> listButtons = new List<Button>();
        }

        public struct UserControlEvents
        {
            public static FlowLayoutPanel FLP = new FlowLayoutPanel();
            public static Panel smallLeftTop = new Panel();
            public static Button buttonDelete = new Button();
            public static Button buttonEdit = new Button();
        }

        public struct Form1
        {
            public static Form form1 = new Form();
            public static Panel panelLeft = new Panel();
            public static Panel panelRight = new Panel();
            public static Panel panelContainer = new Panel();
            public static Button dateButton = new Button();
            public static Button addEventButton = new Button();
        }

        public struct FormDate
        {
            public static string currentPage = "month";
            public static List<Button> listButtons = new List<Button>();
        }

        public struct FormAddEvent
        {
            public static List<TextBox> listTextBoxes = new List<TextBox>();
        }

        public struct UserControlEvent
        {
            public static List<Event> events = new List<Event>();
        }
    }
}
