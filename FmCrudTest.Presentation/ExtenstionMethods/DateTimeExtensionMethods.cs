using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmCrudTest.Presentation.ExtenstionMethods
{
    public static class DateTimeExtensionMethods
    {

        public static DateTime ToDateTime(this string datetime)
        {
            var input = datetime.Split('/');
            return  new DateTime(Int32.Parse(input[2]) , Int32.Parse(input[1]) , Int32.Parse(input[0]));
        }

        public static string ToStringFormat(this DateTime dateTtime)
        {
            return $"{dateTtime.Day}/{dateTtime.Month}/{dateTtime.Year}";
        }
    }
}