using System;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine($"Number {first} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine($"Number {second} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
        }

        public static void WriteLargestWithNestedIfElse(int first, int second, int third, int largest)
        {
            if (first > second && first > third && first > largest)
            {
                Console.Write($"Number {first} is the largest");
            }
            else if (second > first && second > third && second > largest)
            {
                Console.Write($"Number {second} is the largest");
            }
            else if (third > first && third > second && third > largest)
            {
                Console.Write($"Number {second} is the largest");
            }
            else
            {
                Console.Write($"Number {largest} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.Write($"Number {first} is the largest");
            }
            else
            {
                Console.Write(second > third ? $"Number {second} is the largest" : $"Number {third} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.Write($"Number {first} is the largest");
            }
            else if (second > first && second > third)
            {
                Console.Write($"Number {second} is the largest");
            }
            else
            {
                Console.Write($"Number {third} is the largest");
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.Write("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.Write("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.Write("You're old enough to drive.");
            }
            else
            {
                Console.Write("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else if (countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads < 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads < 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if ((int)dayOfWeek == 0 || (int)dayOfWeek == 6)
            {
                Console.WriteLine("The weekend.");
            }
            else if ((int)dayOfWeek == 5)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else if ((int)dayOfWeek > 1)
            {
                Console.WriteLine("The middle of the work week.");
            }
            else
            {
                Console.WriteLine("The first day of the work week.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch ((int)dayOfWeek)
            {
                case 0:
                case 6:
                    Console.WriteLine("The weekend.");
                    break;
                case 5:
                    Console.WriteLine("The last day of the work week.");
                    break;
                case 3:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case 2:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case 1:
                    Console.WriteLine("The first day of the work week.");
                    break;
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is sbyte)
            {
                return $"{arg} is sbyte.";
            }
            else if (arg is byte)
            {
                return $"{arg} is byte.";
            }
            else if (arg is short)
            {
                return $"{arg} is short.";
            }
            else if (arg is int)
            {
                return $"{arg} is int.";
            }
            else if (arg is long)
            {
                return $"{arg} is long.";
            }
            else if (arg is ushort)
            {
                return $"{arg} is ushort.";
            }
            else if (arg is uint)
            {
                return $"{arg} is uint.";
            }
            else if (arg is ulong)
            {
                return $"{arg} is ulong.";
            }
            else
            {
                return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            switch (arg)
            {
                case sbyte x:
                    return $"{arg} is sbyte.";
                case byte x:
                    return $"{arg} is byte.";
                case short x:
                    return $"{arg} is short.";
                case int x:
                    return $"{arg} is int.";
                case long x:
                    return $"{arg} is long.";
                case ushort x:
                    return $"{arg} is ushort.";
                case uint x:
                    return $"{arg} is uint.";
                case ulong x:
                    return $"{arg} is ulong.";
                default:
                    return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            var result = arg switch
            {
                sbyte x => $"{arg} is sbyte.",
                byte x => $"{arg} is byte.",
                short x => $"{arg} is short.",
                int x => $"{arg} is int.",
                long x => $"{arg} is long.",
                ushort x => $"{arg} is ushort.",
                uint x => $"{arg} is uint.",
                ulong x => $"{arg} is ulong.",
                _ => $"{arg} is not integer."
            };

            return result;
        }

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number == int.MinValue)
            {
                return 10;
            }

            if (Math.Abs(number) < 10)
            {
                return 1;
            }

            if (Math.Abs(number) < 100)
            {
                return 2;
            }

            if (Math.Abs(number) < 1000)
            {
                return 3;
            }

            if (Math.Abs(number) < 10000)
            {
                return 4;
            }

            if (Math.Abs(number) < 100000)
            {
                return 5;
            }

            if (Math.Abs(number) < 1000000)
            {
                return 6;
            }

            if (Math.Abs(number) < 10000000)
            {
                return 7;
            }

            if (Math.Abs(number) < 100000000)
            {
                return 8;
            }

            if (Math.Abs(number) < 1000000000)
            {
                return 9;
            }

            return 10;
        }

        public static byte GetLengthWithSwitchExpression(int number)
        {
            byte result = number switch
            {
                var _ when number == int.MinValue => 10,
                var _ when Math.Abs(number) < 10 => 1,
                var _ when Math.Abs(number) < 100 => 2,
                var _ when Math.Abs(number) < 1000 => 3,
                var _ when Math.Abs(number) < 10000 => 4,
                var _ when Math.Abs(number) < 100000 => 5,
                var _ when Math.Abs(number) < 1000000 => 6,
                var _ when Math.Abs(number) < 10000000 => 7,
                var _ when Math.Abs(number) < 100000000 => 8,
                var _ when Math.Abs(number) < 1000000000 => 9,
                _ => 10

            };

            return result;
        }

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }
            else
            {
                if (month == 2)
                {
                    return Month.February;
                }
                else
                {
                    if (month == 3)
                    {
                        return Month.March;
                    }
                    else
                    {
                        if (month == 4)
                        {
                            return Month.April;
                        }
                        else
                        {
                            if (month == 5)
                            {
                                return Month.May;
                            }
                            else
                            {
                                if (month == 6)
                                {
                                    return Month.June;
                                }
                                else
                                {
                                    if (month == 7)
                                    {
                                        return Month.July;
                                    }
                                    else
                                    {
                                        if (month == 8)
                                        {
                                            return Month.August;
                                        }
                                        else
                                        {
                                            if (month == 9)
                                            {
                                                return Month.September;
                                            }
                                            else
                                            {
                                                if (month == 10)
                                                {
                                                    return Month.October;
                                                }
                                                else
                                                {
                                                    if (month == 11)
                                                    {
                                                        return Month.November;
                                                    }
                                                    else
                                                    {
                                                        if (month == 12)
                                                        {
                                                            return Month.December;
                                                        }
                                                        else
                                                        {
                                                            return null;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;
                default:
                    return null;
            }
        }

        public static Month? GetMonthWithSwitchExpression(int month)
        {            
            Month? result = month switch
            {
                1 => Month.January,
                2 => Month.February,
                3 => Month.March,
                4 => Month.April,
                5 => Month.May,
                6 => Month.June,
                7 => Month.July,
                8 => Month.August,
                9 => Month.September,
                10 => Month.October,
                11 => Month.November,
                12 => Month.December,
                _ => null
            };

            return result;
        }
    }
}
