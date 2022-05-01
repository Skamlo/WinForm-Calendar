using System;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This is non-static class that is used to create objects of the "Event" type

namespace Calendar
{
    public class Event
    {
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime addDate;
        private DateTime editDate;
        private int id;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public DateTime AddDate
        {
            get { return addDate; }
            set { addDate = value; }
        }
        public DateTime EditDate
        {
            get { return editDate; }
            set { editDate = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
