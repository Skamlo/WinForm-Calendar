using System;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -static DateTime variables

namespace Calendar.ClassData
{
    public static class Date
    {
        public static DateTime currentDateTime = DateTime.Now;
        public static DateTime currentFormDateTime = DateTime.Now;

        // for FormAddEvent
        public struct FormAddEvent
        {
            public static DateTime startDate = DateTime.Now;
            public static DateTime endDate = DateTime.Now;

            public static DateTime startDateValid = DateTime.Now;
            public static DateTime endDateValid = DateTime.Now;
        }
    }
}
