using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Extentions
{
    internal static class CheckName1
    {
        public static bool CheckName(this string sentence)
        {
            if (sentence == null) return false;
            if (sentence.Length < 3 || sentence.Length > 30) return false;

            return true;
        }
    }
}
