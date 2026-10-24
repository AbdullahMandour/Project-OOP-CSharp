using System;

namespace RestrantAPP.Classes
{
    public static class InputHelper
    {
        // بتقرأ رقم صحيح، ولو غلط بتعيد السؤال
        public static int ReadInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;

                Console.WriteLine("Invalid input! Numbers only. Try again:");
            }
        }

        // بتقرأ سعر (رقم أكبر من صفر)، ولو غلط بتعيد السؤال
        public static decimal ReadPrice()
        {
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal result)
                    && ValidationHelper.IsValidPrice(result))
                    return result;

                Console.WriteLine("Invalid price! Enter a number greater than 0. Try again:");
            }
        }

        // بتطبع السؤال وبتقرأ نص، ولو الـ Validation فشل بتعيد السؤال
        public static string ReadString(string message, Func<string, bool> isValid, string errorMessage)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (isValid(input))
                    return input;

                Console.WriteLine(errorMessage + " Try again.\n");
            }
        }
    }
}