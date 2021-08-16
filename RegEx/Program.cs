using System;
using System.Globalization;
using System.Text.RegularExpressions;
namespace RegEx {
    class Program {
        static void Main(string[] args) {

            var wsText = "ADTK BY 19AUG21 1434GRU 19AUG21 1434SAO PER 4PLUSTA";
            var match = Regex.Match(wsText, @"(?<date>[0-9]{1,2}[A-Z]{3}[0-9]{2}).*(?<hours>[0-9]{4})");
            var dateText = match.Groups["date"].Value;
            var hoursText = match.Groups["hours"].Value;
            Console.WriteLine(wsText);
            var date = DateTime.ParseExact($"{dateText} {hoursText}", "ddMMMyy HHmm", CultureInfo.InvariantCulture);
            Console.WriteLine(date.ToString());

        }
    }
}
