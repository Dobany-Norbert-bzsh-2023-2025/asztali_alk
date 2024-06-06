using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryWpf.Models
{
    public class Sorsolas
    {
        public int Id { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }
        public int Num5 { get; set; }

        public Sorsolas() { }

        public Sorsolas(HashSet<int> set)
        {
            var t = set.ToArray();
            Num1 = t[0];
            Num2 = t[1];
            Num3 = t[2];
            Num4 = t[3];
            Num5 = t[4];
        }
    }
}
