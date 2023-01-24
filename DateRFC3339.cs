using System; 

namespace DateExtensions
{
    public static class DateRFC3339
    {
        public static string DateFormat(this DateTime date)
        {
            return TimeZoneInfo.ConvertTimeToUtc(date).ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"); 

        }

        public static void Main (string[] args){
            DateTime dateNow = DateTime.Now; 
            DateFormat(dateNow); 

            //Input: 24/01/2023 19:28:52
            //Return: 2023-01-24T22:28:52Z
        }
    }
}
