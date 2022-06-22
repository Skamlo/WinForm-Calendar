using System.Collections.Generic;
using System.Windows.Forms;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -current language structure
//      -english language structure
//      -polish language structure
//      -methods that change data in currentlanguage struct

namespace Calendar.ClassData
{
    public static class Language
    {
        public struct currentLanguage
        {
            public struct Date
            {
                public static string[] months = English.Date.months;
                public static string[] monthShortcuts = English.Date.monthShortcuts;
                public static string[] daysOfWeek = English.Date.daysOfWeek;
                public static string[] dayOfWeekShortcuts = English.Date.dayOfWeekShortcuts;
            }
            public struct Settings
            {
                public struct Labels
                {
                    public static string language = English.Settings.Labels.language;
                    public static string style = English.Settings.Labels.style;
                    public static string firstDay = English.Settings.Labels.firstDay;
                    public static string writingMethod = English.Settings.Labels.writingMethod;
                    public static string clockSystem = English.Settings.Labels.clockSystem;
                };
                public struct ComboBoxLanguage
                {
                    public static string english = English.Settings.ComboBoxLanguage.english;
                    public static string polish = English.Settings.ComboBoxLanguage.polish;
                };
                public struct radioButtonsStyle
                {
                    public static string red = English.Settings.radioButtonsStyle.red;
                    public static string green = English.Settings.radioButtonsStyle.green;
                    public static string blue = English.Settings.radioButtonsStyle.blue;
                    public static string custom = English.Settings.radioButtonsStyle.custom;
                };
                public struct radioButtonsFirstDay
                {
                    public static string monday = English.Settings.radioButtonsFirstDay.monday;
                    public static string sunday = English.Settings.radioButtonsFirstDay.sunday;
                };
                public struct radioButtonsWritingMethod
                {
                    public static string DMY = English.Settings.radioButtonsWritingMethod.DMY;
                    public static string MDY = English.Settings.radioButtonsWritingMethod.MDY;
                    public static string YMD = English.Settings.radioButtonsWritingMethod.YMD;
                    public static string YDM = English.Settings.radioButtonsWritingMethod.YDM;
                    public static string MYD = English.Settings.radioButtonsWritingMethod.MYD;
                    public static string DYM = English.Settings.radioButtonsWritingMethod.DYM;
                };
                public struct radioButtonsClockSystem
                {
                    public static string clockSystem12 = English.Settings.radioButtonsClockSystem.clockSystem12;
                    public static string clockSystem24 = English.Settings.radioButtonsClockSystem.clockSystem24;
                };
            };
            public struct Events
            {
                public static string title = English.Events.title;
                public static string description = English.Events.description;
                public static string addDate = English.Events.addDate;
                public static string editDate = English.Events.editDate;
                public static string save = English.Events.save;
                public static string cancle = English.Events.cancle;
                public static string addNewEvent = English.Events.addNewEvent;

                public struct TimeUnitsShortcuts
                {
                    public static string minutes = English.Events.TimeUnitsShortcuts.minutes;
                    public static string hours = English.Events.TimeUnitsShortcuts.hours;
                    public static string days = English.Events.TimeUnitsShortcuts.days;
                    public static string years = English.Events.TimeUnitsShortcuts.years;
                }
            }
            public struct FormsNames
            {
                public static string form1Calendar = English.FormsNames.form1Calendar;
                public static string form1Settings = English.FormsNames.form1Settings;
                public static string form1Events = English.FormsNames.form1Events;
                public static string formDate = English.FormsNames.formDate;
                public static string formAddEvent = English.FormsNames.formAddEvent;
            }
        }

        public struct English
        {
            public struct Date
            {
                public static string[] months =
                { 
                    "January", 
                    "Feruary",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July",
                    "August",
                    "September",
                    "October",
                    "November",
                    "December"
                };

                public static string[] monthShortcuts =
                {
                    "Jan.",
                    "Feb.",
                    "Mar.",
                    "Apr.",
                    "May",
                    "Jun.",
                    "Jul.",
                    "Aug.",
                    "Sep.",
                    "Oct.",
                    "Nov.",
                    "Dec."
                };

                public static string[] daysOfWeek =
                {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
                };

                public static string[] dayOfWeekShortcuts =
                {
                    "Mon.",
                    "Tue.",
                    "Wed.",
                    "Thu.",
                    "Fri.",
                    "Sat.",
                    "Sun."
                };
            }
            public struct Settings
            {
                public struct Labels
                {
                    public static string language = "Language";
                    public static string style = "Styles";
                    public static string firstDay = "First day of week";
                    public static string writingMethod = "Writing method";
                    public static string clockSystem = "Clock system";
                };
                public struct ComboBoxLanguage
                {
                    public static string english = "English";
                    public static string polish = "Polski (Polish)";
                };
                public struct radioButtonsStyle
                {
                    public static string red = "Red";
                    public static string green = "Green";
                    public static string blue = "Blue";
                    public static string custom = "Custom";
                };
                public struct radioButtonsFirstDay
                {
                    public static string monday = "Monday";
                    public static string sunday = "Sunday";
                };
                public struct radioButtonsWritingMethod
                {
                    public static string DMY = "day.month.year";
                    public static string MDY = "month.day.year";
                    public static string YMD = "year.month.day";
                    public static string YDM = "year.day.month";
                    public static string MYD = "month.year.day";
                    public static string DYM = "day.yaer.month";
                };
                public struct radioButtonsClockSystem
                {
                    public static string clockSystem12 = "12 hours";
                    public static string clockSystem24 = "24 hours";
                };
            };
            public struct Events
            {
                public static string title = "Title";
                public static string description = "Descrpion";
                public static string addDate = "Add date";
                public static string editDate = "Last edit date";
                public static string save = "Save";
                public static string cancle = "Cancle";
                public static string addNewEvent = "Add new event";

                public struct TimeUnitsShortcuts
                {
                    public static string minutes = "min.";
                    public static string hours = "hr.";
                    public static string days = "days";
                    public static string years = "yr.";
                }
            }
            public struct FormsNames
            {
                public static string form1Calendar = "Calendar";
                public static string form1Settings = "Settings";
                public static string form1Events = "Events";
                public static string formDate = "Change date";
                public static string formAddEvent = "Add event";
            }
        }

        public struct Polish
        {
            public struct Date
            {
                public static string[] months =
                {
                    "Styczen",
                    "Luty",
                    "Marzec",
                    "Kwiecień",
                    "Maj",
                    "Czerwiec",
                    "Lipiec",
                    "Sierpień",
                    "Werzesień",
                    "Październik",
                    "Listopad",
                    "Grudzień"
                };

                public static string[] monthShortcuts =
                {
                    "Sty.",
                    "Lut.",
                    "Mar.",
                    "Kwi.",
                    "Maj",
                    "Cze.",
                    "Lip.",
                    "Sie.",
                    "Wrz.",
                    "Paź.",
                    "Lis.",
                    "Gru."
                };

                public static string[] daysOfWeek =
                {
                    "Poniedziałek",
                    "Wtorek",
                    "Środa",
                    "Czwartek",
                    "Piątek",
                    "Sobota",
                    "Niedziela"
                };

                public static string[] dayOfWeekShortcuts =
                {
                    "Pon.",
                    "Wt.",
                    "Śr.",
                    "Czw.",
                    "Pi.",
                    "Sob.",
                    "Niedz."
                };
            }
            public struct Settings
            {
                public struct Labels
                {
                    public static string language = "Język";
                    public static string style = "Style";
                    public static string firstDay = "Pierwszy dzień tygodnia";
                    public static string writingMethod = "Sposób pisania daty";
                    public static string clockSystem = "System zegarowy";
                };
                public struct ComboBoxLanguage
                {
                    public static string english = "English (Angielski)";
                    public static string polish = "Polski";
                };
                public struct radioButtonsStyle
                {
                    public static string red = "Czerwony";
                    public static string green = "Zielony";
                    public static string blue = "Niebieski";
                    public static string custom = "Niestandardowy";
                };
                public struct radioButtonsFirstDay
                {
                    public static string monday = "Poniedziałek";
                    public static string sunday = "Niedziela";
                };
                public struct radioButtonsWritingMethod
                {
                    public static string DMY = "dzień.miesiąc.rok";
                    public static string MDY = "miesiąc.dzień.rok";
                    public static string YMD = "rok.miesiąc.dzień";
                    public static string YDM = "rok.dzień.miesiąc";
                    public static string MYD = "miesiąc.rok.dzień";
                    public static string DYM = "dzień.rok.miesiąc";
                };
                public struct radioButtonsClockSystem
                {
                    public static string clockSystem12 = "12 godzinny";
                    public static string clockSystem24 = "24 godzinny";
                };
            };
            public struct Events
            {
                public static string title = "Tytuł";
                public static string description = "Opis";
                public static string addDate = "Data dodania";
                public static string editDate = "Data ostatniej edycji";
                public static string save = "Zapisz";
                public static string cancle = "Anuluj";
                public static string addNewEvent = "Dodaj nowe wydarzenie";

                public struct TimeUnitsShortcuts
                {
                    public static string minutes = "min.";
                    public static string hours = "godz.";
                    public static string days = "dni";
                    public static string years = "lat";
                }
            }
            public struct FormsNames
            {
                public static string form1Calendar = "Kalendarz";
                public static string form1Settings = "Ustawienia";
                public static string form1Events = "Wydarzenia";
                public static string formDate = "Zmień datę";
                public static string formAddEvent = "Dodaj wydarzenie";
            }
        }

        public static void currentLanguageToEngilsh()
        {
            // Date
            currentLanguage.Date.months             = English.Date.months;
            currentLanguage.Date.monthShortcuts     = English.Date.monthShortcuts;
            currentLanguage.Date.daysOfWeek         = English.Date.daysOfWeek;
            currentLanguage.Date.dayOfWeekShortcuts = English.Date.dayOfWeekShortcuts;

            // Settings
            currentLanguage.Settings.Labels.language                       = English.Settings.Labels.language;
            currentLanguage.Settings.Labels.style                          = English.Settings.Labels.style;
            currentLanguage.Settings.Labels.firstDay                       = English.Settings.Labels.firstDay;
            currentLanguage.Settings.Labels.writingMethod                  = English.Settings.Labels.writingMethod;
            currentLanguage.Settings.Labels.clockSystem                    = English.Settings.Labels.clockSystem;
            currentLanguage.Settings.ComboBoxLanguage.english              = English.Settings.ComboBoxLanguage.english;
            currentLanguage.Settings.ComboBoxLanguage.polish               = English.Settings.ComboBoxLanguage.polish;
            currentLanguage.Settings.radioButtonsStyle.red                 = English.Settings.radioButtonsStyle.red;
            currentLanguage.Settings.radioButtonsStyle.green               = English.Settings.radioButtonsStyle.green;
            currentLanguage.Settings.radioButtonsStyle.blue                = English.Settings.radioButtonsStyle.blue;
            currentLanguage.Settings.radioButtonsStyle.custom              = English.Settings.radioButtonsStyle.custom;
            currentLanguage.Settings.radioButtonsFirstDay.monday           = English.Settings.radioButtonsFirstDay.monday;
            currentLanguage.Settings.radioButtonsFirstDay.sunday           = English.Settings.radioButtonsFirstDay.sunday;
            currentLanguage.Settings.radioButtonsWritingMethod.DMY         = English.Settings.radioButtonsWritingMethod.DMY;
            currentLanguage.Settings.radioButtonsWritingMethod.MDY         = English.Settings.radioButtonsWritingMethod.MDY;
            currentLanguage.Settings.radioButtonsWritingMethod.YMD         = English.Settings.radioButtonsWritingMethod.YMD;
            currentLanguage.Settings.radioButtonsWritingMethod.YDM         = English.Settings.radioButtonsWritingMethod.YDM;
            currentLanguage.Settings.radioButtonsWritingMethod.MYD         = English.Settings.radioButtonsWritingMethod.MYD;
            currentLanguage.Settings.radioButtonsWritingMethod.DYM         = English.Settings.radioButtonsWritingMethod.DYM;
            currentLanguage.Settings.radioButtonsClockSystem.clockSystem12 = English.Settings.radioButtonsClockSystem.clockSystem12;
            currentLanguage.Settings.radioButtonsClockSystem.clockSystem24 = English.Settings.radioButtonsClockSystem.clockSystem24;

            // Events
            currentLanguage.Events.title                      = English.Events.title;
            currentLanguage.Events.description                = English.Events.description;
            currentLanguage.Events.addDate                    = English.Events.addDate;
            currentLanguage.Events.editDate                   = English.Events.editDate;
            currentLanguage.Events.save                       = English.Events.save;
            currentLanguage.Events.cancle                     = English.Events.cancle;
            currentLanguage.Events.addNewEvent                = English.Events.addNewEvent;
            currentLanguage.Events.TimeUnitsShortcuts.minutes = English.Events.TimeUnitsShortcuts.minutes;
            currentLanguage.Events.TimeUnitsShortcuts.hours   = English.Events.TimeUnitsShortcuts.hours;
            currentLanguage.Events.TimeUnitsShortcuts.days    = English.Events.TimeUnitsShortcuts.days;
            currentLanguage.Events.TimeUnitsShortcuts.years   = English.Events.TimeUnitsShortcuts.years;

            // FormsNames
            currentLanguage.FormsNames.form1Calendar          = English.FormsNames.form1Calendar;
            currentLanguage.FormsNames.form1Settings          = English.FormsNames.form1Settings;
            currentLanguage.FormsNames.form1Events            = English.FormsNames.form1Events;
            currentLanguage.FormsNames.formDate               = English.FormsNames.formDate;
            currentLanguage.FormsNames.formAddEvent           = English.FormsNames.formAddEvent;
        }

        public static void currentLanguageToPolish()
        {
            // Date
            currentLanguage.Date.months             = Polish.Date.months;
            currentLanguage.Date.monthShortcuts     = Polish.Date.monthShortcuts;
            currentLanguage.Date.daysOfWeek         = Polish.Date.daysOfWeek;
            currentLanguage.Date.dayOfWeekShortcuts = Polish.Date.dayOfWeekShortcuts;

            // Settings
            currentLanguage.Settings.Labels.language                       = Polish.Settings.Labels.language;
            currentLanguage.Settings.Labels.style                          = Polish.Settings.Labels.style;
            currentLanguage.Settings.Labels.firstDay                       = Polish.Settings.Labels.firstDay;
            currentLanguage.Settings.Labels.writingMethod                  = Polish.Settings.Labels.writingMethod;
            currentLanguage.Settings.Labels.clockSystem                    = Polish.Settings.Labels.clockSystem;
            currentLanguage.Settings.ComboBoxLanguage.english              = Polish.Settings.ComboBoxLanguage.english;
            currentLanguage.Settings.ComboBoxLanguage.polish               = Polish.Settings.ComboBoxLanguage.polish;
            currentLanguage.Settings.radioButtonsStyle.red                 = Polish.Settings.radioButtonsStyle.red;
            currentLanguage.Settings.radioButtonsStyle.green               = Polish.Settings.radioButtonsStyle.green;
            currentLanguage.Settings.radioButtonsStyle.blue                = Polish.Settings.radioButtonsStyle.blue;
            currentLanguage.Settings.radioButtonsStyle.custom              = Polish.Settings.radioButtonsStyle.custom;
            currentLanguage.Settings.radioButtonsFirstDay.monday           = Polish.Settings.radioButtonsFirstDay.monday;
            currentLanguage.Settings.radioButtonsFirstDay.sunday           = Polish.Settings.radioButtonsFirstDay.sunday;
            currentLanguage.Settings.radioButtonsWritingMethod.DMY         = Polish.Settings.radioButtonsWritingMethod.DMY;
            currentLanguage.Settings.radioButtonsWritingMethod.MDY         = Polish.Settings.radioButtonsWritingMethod.MDY;
            currentLanguage.Settings.radioButtonsWritingMethod.YMD         = Polish.Settings.radioButtonsWritingMethod.YMD;
            currentLanguage.Settings.radioButtonsWritingMethod.YDM         = Polish.Settings.radioButtonsWritingMethod.YDM;
            currentLanguage.Settings.radioButtonsWritingMethod.MYD         = Polish.Settings.radioButtonsWritingMethod.MYD;
            currentLanguage.Settings.radioButtonsWritingMethod.DYM         = Polish.Settings.radioButtonsWritingMethod.DYM;
            currentLanguage.Settings.radioButtonsClockSystem.clockSystem12 = Polish.Settings.radioButtonsClockSystem.clockSystem12;
            currentLanguage.Settings.radioButtonsClockSystem.clockSystem24 = Polish.Settings.radioButtonsClockSystem.clockSystem24;

            // Events
            currentLanguage.Events.title                      = Polish.Events.title;
            currentLanguage.Events.description                = Polish.Events.description;
            currentLanguage.Events.addDate                    = Polish.Events.addDate;
            currentLanguage.Events.editDate                   = Polish.Events.editDate;
            currentLanguage.Events.save                       = Polish.Events.save;
            currentLanguage.Events.cancle                     = Polish.Events.cancle;
            currentLanguage.Events.addNewEvent                = Polish.Events.addNewEvent;
            currentLanguage.Events.TimeUnitsShortcuts.minutes = Polish.Events.TimeUnitsShortcuts.minutes;
            currentLanguage.Events.TimeUnitsShortcuts.hours   = Polish.Events.TimeUnitsShortcuts.hours;
            currentLanguage.Events.TimeUnitsShortcuts.days    = Polish.Events.TimeUnitsShortcuts.days;
            currentLanguage.Events.TimeUnitsShortcuts.years   = Polish.Events.TimeUnitsShortcuts.years;

            // FormsNames
            currentLanguage.FormsNames.form1Calendar          = Polish.FormsNames.form1Calendar;
            currentLanguage.FormsNames.form1Settings          = Polish.FormsNames.form1Settings;
            currentLanguage.FormsNames.form1Events            = Polish.FormsNames.form1Events;
            currentLanguage.FormsNames.formDate               = Polish.FormsNames.formDate;
            currentLanguage.FormsNames.formAddEvent           = Polish.FormsNames.formAddEvent;
        }

        public static void refreshDaysOfWeekLabels(List<Label> labels)
        {
            if (Data.currentFirstDay == "monday")
            {
                for (int i = 0; i < 7; i++)
                {
                    labels[i].Text = currentLanguage.Date.dayOfWeekShortcuts[i];
                }
            }
            else if (Data.currentFirstDay == "sunday")
            {
                labels[0].Text = currentLanguage.Date.dayOfWeekShortcuts[6];
                for (int i = 0; i < 6; i++)
                {
                    labels[i + 1].Text = currentLanguage.Date.dayOfWeekShortcuts[i];
                }
            }
        }

        public static void refreshSettingsNames(List<Label> listLabels,
                                                ComboBox comboBoxLanguage,
                                                List<RadioButton> listRadioButtonStyle,
                                                List<RadioButton> listRadioButtonFirstDay,
                                                List<RadioButton> listRadioButtonWritingMethod,
                                                List<RadioButton> listRadioButtonClockSystem)
        {
            listLabels[0].Text = currentLanguage.Settings.Labels.language;
            listLabels[1].Text = currentLanguage.Settings.Labels.style;
            listLabels[2].Text = currentLanguage.Settings.Labels.firstDay;
            listLabels[3].Text = currentLanguage.Settings.Labels.writingMethod;
            listLabels[4].Text = currentLanguage.Settings.Labels.clockSystem;

            comboBoxLanguage.Items.Clear();
            if (Data.currentLanguage == "english")
            {
                comboBoxLanguage.Items.Add(currentLanguage.Settings.ComboBoxLanguage.english);
                comboBoxLanguage.Items.Add(currentLanguage.Settings.ComboBoxLanguage.polish);
            }
            else
            {
                comboBoxLanguage.Items.Add(currentLanguage.Settings.ComboBoxLanguage.polish);
                comboBoxLanguage.Items.Add(currentLanguage.Settings.ComboBoxLanguage.english);
            }

            listRadioButtonStyle[0].Text = currentLanguage.Settings.radioButtonsStyle.red;
            listRadioButtonStyle[1].Text = currentLanguage.Settings.radioButtonsStyle.green;
            listRadioButtonStyle[2].Text = currentLanguage.Settings.radioButtonsStyle.blue;
            listRadioButtonStyle[3].Text = currentLanguage.Settings.radioButtonsStyle.custom;

            listRadioButtonFirstDay[0].Text = currentLanguage.Settings.radioButtonsFirstDay.monday;
            listRadioButtonFirstDay[1].Text = currentLanguage.Settings.radioButtonsFirstDay.sunday;

            listRadioButtonWritingMethod[0].Text = currentLanguage.Settings.radioButtonsWritingMethod.DMY;
            listRadioButtonWritingMethod[1].Text = currentLanguage.Settings.radioButtonsWritingMethod.MDY;
            listRadioButtonWritingMethod[2].Text = currentLanguage.Settings.radioButtonsWritingMethod.YMD;
            listRadioButtonWritingMethod[3].Text = currentLanguage.Settings.radioButtonsWritingMethod.YDM;
            listRadioButtonWritingMethod[4].Text = currentLanguage.Settings.radioButtonsWritingMethod.MYD;
            listRadioButtonWritingMethod[5].Text = currentLanguage.Settings.radioButtonsWritingMethod.DYM;

            listRadioButtonClockSystem[0].Text = currentLanguage.Settings.radioButtonsClockSystem.clockSystem12;
            listRadioButtonClockSystem[1].Text = currentLanguage.Settings.radioButtonsClockSystem.clockSystem24;
        }
    }
}
