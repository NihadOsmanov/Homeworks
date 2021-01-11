using System;
using System.Collections.Generic;
using System.Text;

namespace _28._12._2020_Task1
{
    class Month

    {
        public static Month January { get; internal set; }
        public static Month Febuary { get; internal set; }
        public static Month March { get; internal set; }
        public static Month April { get; internal set; }
        public static Month May { get; internal set; }
        public static Month June { get; internal set; }
        public static Month July { get; internal set; }
        public static Month August { get; internal set; }
        public static Month September { get; internal set; }
        public static Month October { get; internal set; }
        public static Month November { get; internal set; }
        public static Month Decemeber { get; internal set; }

        public enum Months
        {
            January = 1,
            Febuary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            November,
            December

        }
        public class Monthss
        {
            public Months months;

        }
    }
}
