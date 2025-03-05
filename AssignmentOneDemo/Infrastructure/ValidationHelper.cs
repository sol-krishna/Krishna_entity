using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ValidationHelper
    {
        public static string CheckForEmpty(string message)
        {
            var isValid = false;
            do
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) == false)
                {
                    isValid = true;
                    return input;
                }
            }
            while (isValid == false);

            return string.Empty;
        }

        public static string CheckForMaxLength(string message, int maxLength)
        {
            var isValid = false;
            do
            {
                var input = CheckForEmpty(message);
                if (input.Count() <= maxLength)
                {
                    isValid = true;
                    return input;
                }
            }
            while (isValid == false);

            return string.Empty;
        }

        public static Guid CheckForGuidType(string message)
        {
            var isValid = false;
            do
            {
                var enteredGuid = CheckForEmpty(message);
                if (Guid.TryParse(enteredGuid, out var parsedGuid))
                {
                    return parsedGuid;
                }
            }
            while (isValid == false);

            return Guid.Empty;
        }
    }
}
