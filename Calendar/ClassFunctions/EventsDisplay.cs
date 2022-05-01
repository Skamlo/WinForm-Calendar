using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using Calendar.UserControls;
using Calendar.ClassData;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -methods that are related with displaying datas in FLPEvents (FlowLauoutpanel) in Events UserControl
//       and in AddEventForm

namespace Calendar.ClassFunctions
{
    public partial class EventsDisplay
    {
        public static void refreshFLPEvents(FlowLayoutPanel FLP)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length - 1;

            UserControlEvent[] events = new UserControlEvent[numberOfFiles];

            FLP.Controls.Clear();
            Data.UserControlEvent.events.Clear();

            for (int i = 0; i < numberOfFiles; i++)
            {
                string eventInString = File.ReadAllText(projectPath + @"\Data\Events\event" + (i + 1).ToString() + ".json");
                Event event_ = JsonConvert.DeserializeObject<Event>(eventInString);

                Data.UserControlEvent.events.Add(event_);

                events[i] = new UserControlEvent();
                events[i].Title = event_.Title;
                events[i].Description = event_.Description;
                events[i].StartDate = event_.StartDate;
                events[i].EndDate = event_.EndDate;
                events[i].AddDate = event_.AddDate;
                events[i].EditDate = event_.EditDate;
                events[i].ID = event_.Id;
                events[i].setAddDateLabel();
                events[i].setTimeBetweenLabel();
                events[i].Size = new Size(FLP.Width - 20, 150);

                FLP.Controls.Add(events[i]);
            }

            UserControlAddEvent addEvent = new UserControlAddEvent();
            addEvent.Size = new Size(FLP.Width - 20, 150);
            FLP.Controls.Add(addEvent);
        }

        public static string dateTimeToStringValidation(DateTime time)
        {
            string dateInSting = "";

            if (Data.currentClockSystem == "12")
            {
                if (Data.currentWritingMethod == "DMY")
                {
                    dateInSting = time.Day.ToString() + "." +
                                  zeroZero(time.Month) + "." +
                                  time.Year.ToString() + "   ";
                    if (time.Hour > 12)
                    {
                        dateInSting += (time.Hour % 12).ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "pm";
                    }
                    else
                    {
                        dateInSting += time.Hour.ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "am";
                    }
                }
                else if (Data.currentWritingMethod == "MDY")
                {
                    dateInSting = zeroZero(time.Month) + "." +
                                  time.Day.ToString() + "." +
                                  time.Year.ToString() + "   ";
                    if (time.Hour > 12)
                    {
                        dateInSting += (time.Hour % 12).ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "pm";
                    }
                    else
                    {
                        dateInSting += time.Hour.ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "am";
                    }
                }
                else if (Data.currentWritingMethod == "YMD")
                {
                    dateInSting = time.Year.ToString() + "." +
                                  zeroZero(time.Month) + "." +
                                  time.Day.ToString() + "   ";
                    if (time.Hour > 12)
                    {
                        dateInSting += (time.Hour % 12).ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "pm";
                    }
                    else
                    {
                        dateInSting += time.Hour.ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "am";
                    }
                }
                else if (Data.currentWritingMethod == "YDM")
                {
                    dateInSting = time.Year.ToString() + "." +
                                  time.Day.ToString() + "." +
                                  zeroZero(time.Month) + "   ";
                    if (time.Hour > 12)
                    {
                        dateInSting += (time.Hour % 12).ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "pm";
                    }
                    else
                    {
                        dateInSting += time.Hour.ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "am";
                    }
                }
                else if (Data.currentWritingMethod == "MYD")
                {
                    dateInSting = zeroZero(time.Month) + "." +
                                  time.Year.ToString() + "." +
                                  time.Day.ToString() + "   ";
                    if (time.Hour > 12)
                    {
                        dateInSting += (time.Hour % 12).ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "pm";
                    }
                    else
                    {
                        dateInSting += time.Hour.ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "am";
                    }
                }
                else if (Data.currentWritingMethod == "DYM")
                {
                    dateInSting = time.Day.ToString() + "." +
                                  time.Year.ToString() + "." +
                                  zeroZero(time.Month) + "   ";
                    if (time.Hour > 12)
                    {
                        dateInSting += (time.Hour % 12).ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "pm";
                    }
                    else
                    {
                        dateInSting += time.Hour.ToString() + ":";
                        dateInSting += zeroZero(time.Minute) + " " + "am";
                    }
                }
            }
            else if (Data.currentClockSystem == "24")
            {
                if (Data.currentWritingMethod == "DMY")
                {
                    dateInSting = time.Day.ToString() + "." +
                                  zeroZero(time.Month) + "." +
                                  time.Year.ToString() + "   " +
                                  time.Hour.ToString() + ":" +
                                  zeroZero(time.Minute);
                }
                else if (Data.currentWritingMethod == "MDY")
                {
                    dateInSting = zeroZero(time.Month) + "." +
                                  time.Day.ToString() + "." +
                                  time.Year.ToString() + "   " +
                                  time.Hour.ToString() + ":" +
                                  zeroZero(time.Minute);
                }
                else if (Data.currentWritingMethod == "YMD")
                {
                    dateInSting = time.Year.ToString() + "." +
                                  zeroZero(time.Month) + "." +
                                  time.Day.ToString() + "   " +
                                  time.Hour.ToString() + ":" +
                                  zeroZero(time.Minute);
                }
                else if (Data.currentWritingMethod == "YDM")
                {
                    dateInSting = time.Year.ToString() + "." +
                                  time.Day.ToString() + "." +
                                  zeroZero(time.Month) + "   " +
                                  time.Hour.ToString() + ":" +
                                  zeroZero(time.Minute);
                }
                else if (Data.currentWritingMethod == "MYD")
                {
                    dateInSting = zeroZero(time.Month) + "." +
                                  time.Year.ToString() + "." +
                                  time.Day.ToString() + "   " +
                                  time.Hour.ToString() + ":" +
                                  zeroZero(time.Minute);
                }
                else if (Data.currentWritingMethod == "DYM")
                {
                    dateInSting = time.Day.ToString() + "." +
                                  time.Year.ToString() + "." +
                                  zeroZero(time.Month) + "   " +
                                  time.Hour.ToString() + ":" +
                                  zeroZero(time.Minute);
                }

            }

            return dateInSting;
        }

        public static string dateTimeToDateInStringValidation(DateTime time)
        {
            string dateInString = "";

            if (Data.currentWritingMethod == "DMY")
            {
                dateInString = time.Day.ToString() + "." +
                              zeroZero(time.Month) + "." +
                              time.Year.ToString();

            }
            else if (Data.currentWritingMethod == "MDY")
            {
                dateInString = zeroZero(time.Month) + "." +
                              time.Day.ToString() + "." +
                              time.Year.ToString();
            }
            else if (Data.currentWritingMethod == "YMD")
            {
                dateInString = time.Year.ToString() + "." +
                              zeroZero(time.Month) + "." +
                              time.Day.ToString();
            }
            else if (Data.currentWritingMethod == "YDM")
            {
                dateInString = time.Year.ToString() + "." +
                              time.Day.ToString() + "." +
                              zeroZero(time.Month);
            }
            else if (Data.currentWritingMethod == "MYD")
            {
                dateInString = zeroZero(time.Month) + "." +
                              time.Year.ToString() + "." +
                              time.Day.ToString();
            }
            else if (Data.currentWritingMethod == "DYM")
            {
                dateInString = time.Day.ToString() + "." +
                              time.Year.ToString() + "." +
                              zeroZero(time.Month);
            }

            return dateInString;
        }

        public static string dateTimeToHourInStringValidation(DateTime time)
        {
            string hourInString = "";

            if (Data.currentClockSystem == "12")
            {
                if (time.Hour > 12)
                {
                    hourInString = (time.Hour - 12).ToString() + ":" + zeroZero(time.Minute) + " pm";
                }
                else
                {
                    hourInString = time.Hour.ToString() + ":" + zeroZero(time.Minute) + " am";
                }
            }
            else if (Data.currentClockSystem == "24")
            {
                hourInString = time.Hour.ToString() + ":" + zeroZero(time.Minute);
            }

            return hourInString;
        }

        public static string timeBetween(DateTime startDate, DateTime endDate)
        {
            string timeBetween = "";

            int days = ((int)(endDate - startDate).TotalDays);
            int hours = ((int)(endDate - startDate).TotalHours);
            int minutes = ((int)(endDate - startDate).TotalMinutes);

            if (minutes < 59) // minutes
            {
                timeBetween = minutes + " " + Language.currentLanguage.Events.TimeUnitsShortcuts.minutes;
            }
            else if (hours < 23) // hours
            {
                timeBetween = hours + " " + Language.currentLanguage.Events.TimeUnitsShortcuts.hours;
            }
            else if (days < 364) // days
            {
                timeBetween = days + " " + Language.currentLanguage.Events.TimeUnitsShortcuts.days;
            }
            else // years
            {
                timeBetween = (days / 365).ToString() + " " + Language.currentLanguage.Events.TimeUnitsShortcuts.years;
            }

            return timeBetween;
        }

        public static string zeroZero(int value)
        {
            if (value < 10)
            {
                return "0" + value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
