using System;
using Calendar.ClassData;

//------------------------------------------CLASS DESCRIPTION------------------------------------------
// This class contains:
//      -dateValidation
//      -hourValidation
//      -this methods are checking for errors in writing

namespace Calendar.ClassFunctions
{
    public static class AddEvents
    {
        public static bool dateValidation(string dateInput, int whichTextBox /*1 = start, 2 = end*/)
        {
            bool isError = false; // true = correct, false = incorrect
            int error = 0;

            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;

            int iter = 1;

            // first number
            if (!Char.IsDigit(dateInput[0]))
            {
                error++;
            }

            for (int i = 0; i < dateInput.Length; i++)
            {
                if (Char.IsDigit(dateInput[i]))
                {
                    firstNumber *= 10;
                    firstNumber += dateInput[i] - '0';
                }
                else
                {
                    iter = i;
                    break;
                }
            }

            // first char between numbers
            if (!(dateInput[iter] == Data.legalSymbols[0] ||
                  dateInput[iter] == Data.legalSymbols[1] ||
                  dateInput[iter] == Data.legalSymbols[2] ||
                  dateInput[iter] == Data.legalSymbols[3] ||
                  dateInput[iter] == Data.legalSymbols[4] ||
                  dateInput[iter] == Data.legalSymbols[5] ||
                  dateInput[iter] == Data.legalSymbols[6] ||
                  dateInput[iter] == Data.legalSymbols[7] ||
                  dateInput[iter] == Data.legalSymbols[8] ||
                  dateInput[iter] == Data.legalSymbols[9] ||
                  dateInput[iter] == Data.legalSymbols[10] ||
                  dateInput[iter] == Data.legalSymbols[11] ||
                  dateInput[iter] == Data.legalSymbols[12] ||
                  dateInput[iter] == Data.legalSymbols[13] ||
                  dateInput[iter] == Data.legalSymbols[14] ||
                  dateInput[iter] == Data.legalSymbols[15]))
            {
                error++;
            }

            for (int i = iter; i < dateInput.Length; i++)
            {
                if (!(dateInput[i] == Data.legalSymbols[0] ||
                      dateInput[i] == Data.legalSymbols[1] ||
                      dateInput[i] == Data.legalSymbols[2] ||
                      dateInput[i] == Data.legalSymbols[3] ||
                      dateInput[i] == Data.legalSymbols[4] ||
                      dateInput[i] == Data.legalSymbols[5] ||
                      dateInput[i] == Data.legalSymbols[6] ||
                      dateInput[i] == Data.legalSymbols[7] ||
                      dateInput[i] == Data.legalSymbols[8] ||
                      dateInput[i] == Data.legalSymbols[9] ||
                      dateInput[i] == Data.legalSymbols[10] ||
                      dateInput[i] == Data.legalSymbols[11] ||
                      dateInput[i] == Data.legalSymbols[12] ||
                      dateInput[i] == Data.legalSymbols[13] ||
                      dateInput[i] == Data.legalSymbols[14] ||
                      dateInput[i] == Data.legalSymbols[15]))
                {
                    iter = i;
                    break;
                }
            }

            // second number
            if (!Char.IsDigit(dateInput[iter]))
            {
                error++;
            }

            for (int i = iter; i < dateInput.Length; i++)
            {
                if (Char.IsDigit(dateInput[i]))
                {
                    secondNumber *= 10;
                    secondNumber += dateInput[i] - '0';
                }
                else
                {
                    iter = i;
                    break;
                }
            }

            // second char between numbers
            if (!(dateInput[iter] == Data.legalSymbols[0] ||
                  dateInput[iter] == Data.legalSymbols[1] ||
                  dateInput[iter] == Data.legalSymbols[2] ||
                  dateInput[iter] == Data.legalSymbols[3] ||
                  dateInput[iter] == Data.legalSymbols[4] ||
                  dateInput[iter] == Data.legalSymbols[5] ||
                  dateInput[iter] == Data.legalSymbols[6] ||
                  dateInput[iter] == Data.legalSymbols[7] ||
                  dateInput[iter] == Data.legalSymbols[8] ||
                  dateInput[iter] == Data.legalSymbols[9] ||
                  dateInput[iter] == Data.legalSymbols[10] ||
                  dateInput[iter] == Data.legalSymbols[11] ||
                  dateInput[iter] == Data.legalSymbols[12] ||
                  dateInput[iter] == Data.legalSymbols[13] ||
                  dateInput[iter] == Data.legalSymbols[14] ||
                  dateInput[iter] == Data.legalSymbols[15]))
            {
                error++;
            }

            for (int i = iter; i < dateInput.Length; i++)
            {
                if (!(dateInput[i] == Data.legalSymbols[0] ||
                      dateInput[i] == Data.legalSymbols[1] ||
                      dateInput[i] == Data.legalSymbols[2] ||
                      dateInput[i] == Data.legalSymbols[3] ||
                      dateInput[i] == Data.legalSymbols[4] ||
                      dateInput[i] == Data.legalSymbols[5] ||
                      dateInput[i] == Data.legalSymbols[6] ||
                      dateInput[i] == Data.legalSymbols[7] ||
                      dateInput[i] == Data.legalSymbols[8] ||
                      dateInput[i] == Data.legalSymbols[9] ||
                      dateInput[i] == Data.legalSymbols[10] ||
                      dateInput[i] == Data.legalSymbols[11] ||
                      dateInput[i] == Data.legalSymbols[12] ||
                      dateInput[i] == Data.legalSymbols[13] ||
                      dateInput[i] == Data.legalSymbols[14] ||
                      dateInput[i] == Data.legalSymbols[15]))
                {
                    iter = i;
                    break;
                }
            }

            // third number
            if (!Char.IsDigit(dateInput[iter]))
            {
                error++;
            }

            for (int i = iter; i < dateInput.Length; i++)
            {
                if (Char.IsDigit(dateInput[i]))
                {
                    thirdNumber *= 10;
                    thirdNumber += dateInput[i] - '0';
                }
                else
                {
                    iter = i;
                    break;
                }
            }

            // Validation
            int day = 0;
            int month = 0;
            int year = 0;

            if (Data.currentWritingMethod == "DMY")
            {
                if (firstNumber < 1 || firstNumber > 31) { error++; }
                else { day = firstNumber; }

                if (secondNumber < 1 || secondNumber > 12) { error++; }
                else { month = secondNumber; }

                if (thirdNumber < 1 || thirdNumber > 9999) { error++; }
                else { year = thirdNumber; }
            }
            else if (Data.currentWritingMethod == "MDY")
            {
                if (secondNumber < 1 || secondNumber > 31) { error++; }
                else { day = secondNumber; }

                if (firstNumber < 1 || firstNumber > 12) { error++; }
                else { month = firstNumber; }

                if (thirdNumber < 1 || thirdNumber > 9999) { error++; }
                else { year = thirdNumber; ; }
            }
            else if (Data.currentWritingMethod == "YMD")
            {
                if (thirdNumber < 1 || thirdNumber > 31) { error++; }
                else { day = thirdNumber; }

                if (secondNumber < 1 || secondNumber > 12) { error++; }
                else { month = secondNumber; }

                if (firstNumber < 1 || firstNumber > 9999) { error++; }
                else { year = firstNumber; }
            }
            else if (Data.currentWritingMethod == "YDM")
            {
                if (secondNumber < 1 || secondNumber > 31) { error++; }
                else { day = secondNumber; }

                if (thirdNumber < 1 || thirdNumber > 12) { error++; }
                else { month = thirdNumber; }

                if (firstNumber < 1 || firstNumber > 9999) { error++; }
                else { year = firstNumber; }
            }
            else if (Data.currentWritingMethod == "MYD")
            {
                if (thirdNumber < 1 || thirdNumber > 31) { error++; }
                else { day = thirdNumber; }

                if (firstNumber < 1 || firstNumber > 12) { error++; }
                else { month = firstNumber; }

                if (secondNumber < 1 || secondNumber > 9999 ) { error++; }
                else { year = secondNumber; }
            }
            else if (Data.currentWritingMethod == "DYM")
            {
                if (firstNumber < 1 || firstNumber > 31) { error++; }
                else { day = firstNumber; }

                if (thirdNumber < 1 || thirdNumber > 12) { error++; }
                else { month = thirdNumber; }

                if (secondNumber < 1 || secondNumber > 9999 ) { error++; }
                else { year = secondNumber; }
            }

            if (error > 0)
            {
                isError = false;
            }
            else
            {
                isError = true;
                if (whichTextBox == 1) // start
                {
                    Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddYears(-(Date.FormAddEvent.startDateValid.Year - 1));
                    Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddYears(year - 1);

                    Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddMonths(-(Date.FormAddEvent.startDateValid.Month - 1));
                    Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddMonths(month - 1);

                    Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddDays(-(Date.FormAddEvent.startDateValid.Day - 1));
                    Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddDays(day - 1);
                }
                else if (whichTextBox == 2) // end
                {
                    Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddYears(-(Date.FormAddEvent.endDateValid.Year - 1));
                    Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddYears(year - 1);

                    Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddMonths(-(Date.FormAddEvent.endDateValid.Month - 1));
                    Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddMonths(month - 1);

                    Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddDays(-(Date.FormAddEvent.endDateValid.Day - 1));
                    Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddDays(day - 1);
                }
            }

            return isError;
        }

        public static bool hourValidation(string hourInput, int whichTextBox /*1 = start, 2 = end*/)
        {
            bool isError = false; // true = correct, false = incorrect
            int error = 0;

            if (Data.currentClockSystem == "12")
            {
                int firstNumber = 0;
                int secondNumber = 0;

                int numberOfLetter = 1;
                bool whichClock = false; // false = am, true = pm
                char firstLetter = 'w';
                char secondLetter = 'w';

                int iter = 1;

                // first number
                if (!Char.IsDigit(hourInput[0]))
                {
                    error++;
                }

                for (int i = 0; i < hourInput.Length; i++)
                {
                    if (Char.IsDigit(hourInput[i]))
                    {
                        firstNumber *= 10;
                        firstNumber += hourInput[i] - '0';
                    }
                    else
                    {
                        iter = i;
                        break;
                    }
                }

                // char between numbers
                if (!(hourInput[iter] == Data.legalSymbols[0] ||
                      hourInput[iter] == Data.legalSymbols[1] ||
                      hourInput[iter] == Data.legalSymbols[2] ||
                      hourInput[iter] == Data.legalSymbols[3] ||
                      hourInput[iter] == Data.legalSymbols[4] ||
                      hourInput[iter] == Data.legalSymbols[5] ||
                      hourInput[iter] == Data.legalSymbols[6] ||
                      hourInput[iter] == Data.legalSymbols[7] ||
                      hourInput[iter] == Data.legalSymbols[8] ||
                      hourInput[iter] == Data.legalSymbols[9] ||
                      hourInput[iter] == Data.legalSymbols[10] ||
                      hourInput[iter] == Data.legalSymbols[11] ||
                      hourInput[iter] == Data.legalSymbols[12] ||
                      hourInput[iter] == Data.legalSymbols[13] ||
                      hourInput[iter] == Data.legalSymbols[14] ||
                      hourInput[iter] == Data.legalSymbols[15]))
                {
                    error++;
                }

                for (int i = iter; i < hourInput.Length; i++)
                {
                    if (!(hourInput[i] == Data.legalSymbols[0] ||
                          hourInput[i] == Data.legalSymbols[1] ||
                          hourInput[i] == Data.legalSymbols[2] ||
                          hourInput[i] == Data.legalSymbols[3] ||
                          hourInput[i] == Data.legalSymbols[4] ||
                          hourInput[i] == Data.legalSymbols[5] ||
                          hourInput[i] == Data.legalSymbols[6] ||
                          hourInput[i] == Data.legalSymbols[7] ||
                          hourInput[i] == Data.legalSymbols[8] ||
                          hourInput[i] == Data.legalSymbols[9] ||
                          hourInput[i] == Data.legalSymbols[10] ||
                          hourInput[i] == Data.legalSymbols[11] ||
                          hourInput[i] == Data.legalSymbols[12] ||
                          hourInput[i] == Data.legalSymbols[13] ||
                          hourInput[i] == Data.legalSymbols[14] ||
                          hourInput[i] == Data.legalSymbols[15]))
                    {
                        iter = i;
                        break;
                    }
                }

                // second number
                if (!Char.IsDigit(hourInput[iter]))
                {
                    error++;
                }

                for (int i = iter; i < hourInput.Length; i++)
                {
                    if (Char.IsDigit(hourInput[i]))
                    {
                        secondNumber *= 10;
                        secondNumber += hourInput[i] - '0';
                    }
                    else
                    {
                        iter = i;
                        break;
                    }
                }

                // am and pm
                if (!(hourInput[iter] == ' ' ||
                      hourInput[iter] == Data.legalLetters[0] ||
                      hourInput[iter] == Data.legalLetters[1] ||
                      hourInput[iter] == Data.legalLetters[2] ||
                      hourInput[iter] == Data.legalLetters[3] ||
                      hourInput[iter] == Data.legalLetters[4] ||
                      hourInput[iter] == Data.legalLetters[5]))
                {
                    error++;
                }

                for (int i = iter; i < hourInput.Length; i++)
                {
                    if (numberOfLetter > 2)
                    {
                        break;
                    }

                    if (hourInput[i] == ' ')
                    {

                    }
                    else if (hourInput[i] == Data.legalLetters[0] ||
                             hourInput[i] == Data.legalLetters[1] ||
                             hourInput[i] == Data.legalLetters[2] ||
                             hourInput[i] == Data.legalLetters[3] ||
                             hourInput[i] == Data.legalLetters[4] ||
                             hourInput[i] == Data.legalLetters[5])
                    {
                        if (numberOfLetter == 1)
                        {
                            firstLetter = hourInput[i];
                        }
                        else if (numberOfLetter == 2)
                        {
                            secondLetter = hourInput[i];
                        }
                        numberOfLetter++;
                    }
                    else
                    {
                        break;
                    }
                }

                // Validation
                if (!(firstNumber >= 0 && firstNumber <= 12))
                {
                    error++;
                }

                if (!(secondNumber >= 0 && secondNumber <= 60))
                {
                    error++;
                }

                if ((firstLetter == 'a' || firstLetter == 'A') && (secondLetter == 'm' || secondLetter == 'M'))
                {
                    whichClock = false;
                }
                else if ((firstLetter == 'p' || firstLetter == 'P') && (secondLetter == 'm' || secondLetter == 'M'))
                {
                    whichClock = true;
                }
                else
                {
                    error++;
                }

                if (error > 0)
                {
                    isError = false;
                }
                else
                {
                    isError = true;
                    if (whichTextBox == 1) // start
                    {
                        if (!whichClock) // am
                        {
                            Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddHours(-(Date.FormAddEvent.startDateValid.Hour - 1));
                            Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddHours(firstNumber - 1);
                        }
                        else // pm
                        {
                            Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddHours(-(Date.FormAddEvent.startDateValid.Hour - 1));
                            Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddHours(firstNumber + 12 - 1);
                        }

                        Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddMinutes(-(Date.FormAddEvent.startDateValid.Minute - 1));
                        Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddMinutes(secondNumber - 1);
                    }
                    else if (whichTextBox == 2) // end
                    {
                        if (!whichClock) // am
                        {
                            Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddHours(-(Date.FormAddEvent.endDateValid.Hour - 1));
                            Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddHours(firstNumber - 1);
                        }
                        else // pm
                        {
                            Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddHours(-(Date.FormAddEvent.endDateValid.Hour - 1));
                            Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddHours(firstNumber + 12 - 1);
                        }

                        Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddMinutes(-(Date.FormAddEvent.endDateValid.Minute - 1));
                        Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddMinutes(secondNumber - 1);
                    }
                }
            }
            else if (Data.currentClockSystem == "24")
            {
                int firstNumber = 0;
                int secondNumber = 0;

                int iter = 1;

                // first number
                if (!Char.IsDigit(hourInput[0]))
                {
                    error++;
                }

                for (int i = 0; i < hourInput.Length; i++)
                {
                    if (Char.IsDigit(hourInput[i]))
                    {
                        firstNumber *= 10;
                        firstNumber += hourInput[i] - '0';
                    }
                    else
                    {
                        iter = i;
                        break;
                    }
                }

                // char between numbers
                if (!(hourInput[iter] == Data.legalSymbols[0] ||
                      hourInput[iter] == Data.legalSymbols[1] ||
                      hourInput[iter] == Data.legalSymbols[2] ||
                      hourInput[iter] == Data.legalSymbols[3] ||
                      hourInput[iter] == Data.legalSymbols[4] ||
                      hourInput[iter] == Data.legalSymbols[5] ||
                      hourInput[iter] == Data.legalSymbols[6] ||
                      hourInput[iter] == Data.legalSymbols[7] ||
                      hourInput[iter] == Data.legalSymbols[8] ||
                      hourInput[iter] == Data.legalSymbols[9] ||
                      hourInput[iter] == Data.legalSymbols[10] ||
                      hourInput[iter] == Data.legalSymbols[11] ||
                      hourInput[iter] == Data.legalSymbols[12] ||                       
                      hourInput[iter] == Data.legalSymbols[13] ||
                      hourInput[iter] == Data.legalSymbols[14] ||
                      hourInput[iter] == Data.legalSymbols[15]))
                {
                    error++;
                }

                for (int i = iter; i < hourInput.Length; i++)
                {
                    if (!(hourInput[i] == Data.legalSymbols[0] ||
                          hourInput[i] == Data.legalSymbols[1] ||
                          hourInput[i] == Data.legalSymbols[2] ||
                          hourInput[i] == Data.legalSymbols[3] ||
                          hourInput[i] == Data.legalSymbols[4] ||
                          hourInput[i] == Data.legalSymbols[5] ||
                          hourInput[i] == Data.legalSymbols[6] ||
                          hourInput[i] == Data.legalSymbols[7] ||
                          hourInput[i] == Data.legalSymbols[8] ||
                          hourInput[i] == Data.legalSymbols[9] ||
                          hourInput[i] == Data.legalSymbols[10] ||
                          hourInput[i] == Data.legalSymbols[11] ||
                          hourInput[i] == Data.legalSymbols[12] ||
                          hourInput[i] == Data.legalSymbols[13] ||
                          hourInput[i] == Data.legalSymbols[14] ||
                          hourInput[i] == Data.legalSymbols[15]))
                    {
                        iter = i;
                        break;
                    }
                }

                // second number
                if (!Char.IsDigit(hourInput[iter]))
                {
                    error++;
                }

                for (int i = iter; i < hourInput.Length; i++)
                {
                    if (Char.IsDigit(hourInput[i]))
                    {
                        secondNumber *= 10;
                        secondNumber += hourInput[i] - '0';
                    }
                    else
                    {
                        break;
                    }
                }

                // Validation
                if (!(firstNumber >= 0 && firstNumber <= 24 ))
                {
                    error++;
                }

                if (!(secondNumber >= 0 && secondNumber <= 60))
                {
                    error++;
                }

                if (error > 0)
                {
                    isError = false;
                }
                else
                {
                    isError = true;
                    if (whichTextBox == 1) // start
                    {
                        Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddHours(-(Date.FormAddEvent.startDateValid.Hour - 1));
                        Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddHours(firstNumber - 1);

                        Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddMinutes(-(Date.FormAddEvent.startDateValid.Minute - 1));
                        Date.FormAddEvent.startDateValid = Date.FormAddEvent.startDateValid.AddMinutes(secondNumber - 1);
                    }
                    else if (whichTextBox == 2) // end
                    {
                        Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddHours(-(Date.FormAddEvent.endDateValid.Hour - 1));
                        Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddHours(firstNumber - 1);

                        Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddMinutes(-(Date.FormAddEvent.endDateValid.Minute - 1));
                        Date.FormAddEvent.endDateValid = Date.FormAddEvent.endDateValid.AddMinutes(secondNumber - 1);
                    }
                }
            }

            return isError;
        }
    }
}
