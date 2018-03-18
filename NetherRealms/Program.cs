using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',', ' ').ToArray();

            SortedDictionary<string, string> demons = new SortedDictionary<string, string>();

            string healthPattern = @"[^0-9+\-\*\\\.]{1}";
            string damageNumberPattern = @"(?:-|)[\d]+(?:\,|)(?:\d+|)";
            string damageActionsPattern = @"([*\/])";
            Regex regex = new Regex(healthPattern);
            List<string> matchList = new List<string>();
            List<double> matchListNumbers = new List<double>();
            regex.Replace
            for (int i = 0; i < input.Length; i++)
            {
                var healthMatches = Regex.Matches(input[i], healthPattern);
                var damageNumberMatches = Regex.Matches(input[i], damageNumberPattern);
                var damageActionsMatches = Regex.Matches(input[i], damageActionsPattern);
                
                int demonHealth = 0;
                matchList = healthMatches.Cast<Match>().Select(match => match.Value).ToList();
                matchListNumbers = damageNumberMatches.Cast<Match>().Select(m => double.Parse(m.ToString())).ToList();

                foreach (var letter in matchList)
                {
                    demonHealth += Convert.ToChar(letter);
                }

                
                
                
            }
            
            
        }
    }
}
