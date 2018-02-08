//using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace barD
{ 
    class Test
    {
        [DllExport]
//        [DllExport("add", CallingConvention = CallingConvention.Cdecl)]
        public static int Add(int left, int right)
        {
            return left + right;
        }
    }
}
