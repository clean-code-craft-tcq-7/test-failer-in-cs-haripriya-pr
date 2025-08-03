using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace MisalignedSpace {
    class Misaligned {
        private static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        private static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

        static int ColorIndexToPair(int majorIndex, int minorIndex)
        {
            return majorIndex * 5 + minorIndex + 1;
        }

        static string GetMajorColors(int index)
        {
            return majorColors[index];
        }

        static string GetMinorColors(int index)
        {
            return minorColors[index];
        }

        static int PrintColorMap() {
            int i = 0, j = 0;
            List<string> index = new List<int>(Enumerable.Range(1, 5 * 5)).ConvertAll<string>(x => x.ToString());
            int maxIndex = ColumnLength(index);
            int maxMajorColor = ColumnLength(majorColors.ToList());
            int maxMinorColor = ColumnLength(minorColors.ToList());
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    Console.WriteLine("{0} | {1} | {2}", AddExtraSpace(ColorIndexToPair(i,j).ToString(),maxIndex), AddExtraSpace(GetMajorColors(i),maxMajorColor), AddExtraSpace(GetMinorColors(j),maxMinorColor));
                }
            }
            return i * j;
        }

        static string AddExtraSpace(string value, int maxLength)
        {
            string valueWithSpace = value;
            for (int i = 0; i < maxLength - value.Length; i++)
            {
                valueWithSpace = valueWithSpace + " ";                         
            }
            return valueWithSpace;
        }

        static int ColumnLength(List<string> values)
        {
            int max = 0;
            values.ForEach(x => max = x.Length > max ? x.Length : max);
            return max;
        }

        static void Main(string[] args) {
            int result = PrintColorMap();
            Debug.Assert(result == 25);
            Debug.Assert(ColorIndexToPair(0, 0) == 1);
            Debug.Assert(ColorIndexToPair(0, 1) == 2);
            Debug.Assert(ColorIndexToPair(1, 0) == 6);
            Debug.Assert(ColorIndexToPair(4, 4) == 25);
            Debug.Assert(ColumnLength(new List<int>(Enumerable.Range(1, 5 * 5)).ConvertAll<string>(x => x.ToString())) == 2);
            Debug.Assert(ColumnLength(majorColors.ToList()) == 6);
            Debug.Assert(ColumnLength(minorColors.ToList()) == 6);
            Debug.Assert(AddExtraSpace("25", 2) == "25");
            Debug.Assert(AddExtraSpace("Blue", 7) == "Blue  ");
            Debug.Assert(GetMajorColors(2).Length == ColumnLength(majorColors.ToList()));
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
