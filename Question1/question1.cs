Console.WriteLine("STUDENT NAME: SYEDA SUMBUL FAISAL  || STUDENT ID: 66552 || SUBMITTION DATE: 28/10/26");
            Console.Write("Enter a day number (1-7): ");
            string input = Console.ReadLine();

            // Check if input is a valid integer
            if (int.TryParse(input, out int day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
