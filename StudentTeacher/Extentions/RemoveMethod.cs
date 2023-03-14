using StudentTeacher.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Extentions
{
    internal static class RemoveMethod
    {
        public static Array[] Remove<Array>(this Array[] arr, int index, int newSize)
        {
            Array[] newArray = new Array[newSize];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    newArray[j] = arr[i];
                    j++;
                }
            }        
            return newArray;
        }
    }
}
