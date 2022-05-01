using System.IO;
using Newtonsoft.Json;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -saveEvent method
//      -deleteEvent method
//      -editEvent method
//      -all of this classes are working in Calendar\Data\Events folder

namespace Calendar.ClassFunctions
{
    public static class Events
    {
        public static void saveEvent(Event newEvent)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length - 1;

            newEvent.Id = numberOfFiles + 1;

            string newEventInString = JsonConvert.SerializeObject(newEvent);

            File.WriteAllText(projectPath + @"\Data\Events\event" + (numberOfFiles + 1).ToString() + ".json", newEventInString);
        }

        public static void deleteEvent(int id)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            string[] files = Directory.GetFiles(projectPath + @"\Data\Events");
            int numberOfFiles = files.Length - 1;

            File.Delete(projectPath + @"\Data\Events\event" + id + ".json");

            for (int i = id; i < numberOfFiles; i++)
            {
                string eventTemporaryInString1 = File.ReadAllText(projectPath + @"\Data\Events\event" + (i + 1).ToString() + ".json");

                File.Delete(projectPath + @"\Data\Events\event" + (i + 1).ToString() + ".json");

                Event event_ = new Event();

                event_ = JsonConvert.DeserializeObject<Event>(eventTemporaryInString1);

                event_.Id--;

                string eventTemporaryInString2 = JsonConvert.SerializeObject(event_);

                File.WriteAllText(projectPath + @"\Data\Events\event" + i + ".json", eventTemporaryInString2);
            }
        }

        public static void editEvent(Event newEditEvent, int id)
        {
            string workPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(workPath).Parent.Parent.FullName;

            File.Delete(projectPath + @"\Data\Events\event" + id + ".json");

            string newEditEventInString = JsonConvert.SerializeObject(newEditEvent);

            File.WriteAllText(projectPath + @"\Data\Events\event" + id + ".json", newEditEventInString);
        }
    }
}
