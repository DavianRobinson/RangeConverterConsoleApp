using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeConverterConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> testnumbers = new int[] { 1 };
            IEnumerable<int> testnumbers2 = new int[] { 1, 2 };
            IEnumerable<int> testnumbers3 = new int[] { 1, 2, 3, 5 };


            var result = ConvertSequenceToRanges(testnumbers);
            var result2 = ConvertSequenceToRanges(testnumbers2);
            var result3 = ConvertSequenceToRanges(testnumbers3);


            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            //reverse operation for testnumers3
            Console.WriteLine(String.Join(",", ConvertRangesToSequence(result3)));

            Console.ReadLine();


        }



        public static IEnumerable<int> ConvertRangesToSequence(string ranges)
        {
            var numbers = ranges.Split(',').ToList<string>();
            var output = new List<int>();
            foreach (var item in numbers)
            {
                var split = item.Split(':');
                if (split.Count() == 1)
                {
                    output.Add(Convert.ToInt32(item));
                    continue;
                }

                for (int i = int.Parse(split[0]); i <= int.Parse(split[1]); i++)
                {
                    output.Add(i);
                }

            }

            return output as IEnumerable<int>;
        }

        public static string ConvertSequenceToRanges(IEnumerable<int> range)
        {
            var sorted = range.OrderBy(x => x);
            var output = new StringBuilder();

            using (var enumerator = sorted.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                    return "";

                var current = enumerator.Current;
                var count = 1;

                output.Append(current);

                while (enumerator.MoveNext())
                {
                    var previous = current;
                    current = enumerator.Current;

                    if (current - previous == 1)
                    {
                        count++;
                    }
                    else
                    {
                        var format = count >= 3 ? ":{0}, {1}" : ", {0}, {1}, ";
                        output.AppendFormat(format, previous, current);
                        count = 1;
                    }
                }

                if (count > 1)
                {
                    output.Append(":");
                    output.Append(current);
                }
            }

            return output.ToString();
        }

    }
}
