using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    internal class LittleHelpers
    {

        public static void ColoredText(string text, string color)
            // Accepts: A string to be colored and string naming a colour
            // Does:    Checks if the color string is in the ConsoleColor Enum. If so the
            //          text string and the color of type ConsoleColor are forwarded to
            //          the ColoredText() method that acceepts the appropriate arguments.
            // Returns: Nothing
        {
            if (Enum.TryParse<ConsoleColor>(color, out ConsoleColor setColor))
            {
               ColoredText(text, setColor);
            }
            else
            {
                ColoredText(
                    "\nProgrammerNeedsAHeadCheck_Error: Color not found in ConsoleColor Enum.\n",
                    ConsoleColor.Yellow);
            }
        }
        
        public static void ColoredText(string text, ConsoleColor color)
            // Accepts: A string and a colour of type ConsoleColor
            // Does:    Write the string in the colour
            //          via Console.Write();
            // Returns: Nothing
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }


        public static string? GetString(out bool exit)
        {
            return GetString(out exit, "exit");
        }

        public static string? GetString(out bool exit, string exitTerm)
            // Accepts: FIXME!
            // Does:    Read a string from the console
            //          and check it for validity
            // Returns: A string or "FAIL" when invalid
        {
            string input = Console.ReadLine();

            if (exitTerm.Trim().Split(' ').Length > 1)
            {
                ColoredText(
                    "ProgrammerNeedsAHeadCheck_Error: exitTerm needs to a a single word.\n",
                    ConsoleColor.Yellow
                    );
            }
            else if (input.Trim().ToLower() == exitTerm.Trim().ToLower())
            {
                exit = true;
                return null;
            }

            if (String.IsNullOrEmpty(input))
            {
                ColoredText(
                    "Empty values are not accepted.\n",
                    ConsoleColor.Red
                    );
                exit = false;
                return null;
            }
            else
            {
                exit = false;
                return input;
            }
        }


        public static int? GetInt(out bool exit)
        {
            return GetInt(out exit, "exit", 0, 0);
        }

        public static int? GetInt(out bool exit, string exitTerm)
        {
            return GetInt(out exit, exitTerm, 0, 0);
        }

        public static int? GetInt(out bool exit, string exitTerm, int min, int max)
            // Accepts: FIXME!
            // Does:    Read a string from the console and
            //          checks if it can be parsed to int?
            // Returns: An int? or null when invalid
        {
            string input = Console.ReadLine();
            int? result = null;

            if (exitTerm.Trim().Split(' ').Length > 1)
            {
                ColoredText(
                    "ProgrammerNeedsAHeadCheck_Error: exitTerm needs to a a single word.\n",
                    ConsoleColor.Yellow
                    );
            }
            else if (input.Trim().ToLower() == exitTerm.Trim().ToLower())
            {
                exit = true;
                return null;
            }

            if (min > max)
            {
                // This needs to become an exception error
                ColoredText(
                    "ProgrammerNeedsAHeadCheck_Error: 'min' needs to be smaller than 'max'\n",
                    ConsoleColor.Yellow
                    );
                exit = false;
                return null;
            }
  
            if (String.IsNullOrEmpty(input))
            {
                ColoredText(
                    "Empty values are not accepted.\n",
                    ConsoleColor.Red
                    );
                exit = false;
                return null;
            }
            else if (!int.TryParse(input, out int value))
            {
                ColoredText(
                    "Only integers are accepted!\n",
                    ConsoleColor.Red
                    );
                exit = false;
                return null;
            }
            else if ((result < min || result > max) !& (min == max))
            {
                ColoredText(
                    $"Value must be between {min} and {max} inclusive.\n",
                    ConsoleColor.Red
                    );
                exit = false;
                return null;
            }
            else
            {
                exit = false;
                result = value;
                return result;
            }

        }



        public static DateTime? GetDateTime(out bool exit)
        {
            return GetDateTime(out exit, "exit");
        }
        public static DateTime? GetDateTime(out bool exit, string exitTerm)
        {
            string input = Console.ReadLine();
            DateTime? result = null;

            if (exitTerm.Trim().Split(' ').Length > 1)
            {
                ColoredText(
                    "ProgrammerNeedsAHeadCheck_Error: exitTerm needs to a a single word.\n",
                    ConsoleColor.Yellow
                    );
            }
            else if (input.Trim().ToLower() == exitTerm.Trim().ToLower())
            {
                exit = true;
                return null;
            }

            if (String.IsNullOrEmpty(input))
            {
                ColoredText(
                    "Empty values are not accepted.\n",
                    ConsoleColor.Red
                    );
                exit = false;
                return null;
            }
            else if (!DateTime.TryParse(input, out DateTime value))
            {
                ColoredText(
                    "No legal input!\n" +
                    "(Format: yyyy-mm-dd)\n",
                    ConsoleColor.Red
                    );
                exit = false;
                return null;
            }
            else
            {
                exit = false;
                result = value;
                return value;
            }
        }


  


        public static void MakeHeading(string heading, char lineChar = '-')
        {
            Console.WriteLine(heading);
            Console.WriteLine(string.Concat(Enumerable.Repeat<char>(lineChar, heading.Length)));
        }

    }
}
