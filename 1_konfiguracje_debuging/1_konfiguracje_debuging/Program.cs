using _1_konfiguracje_debuging.Interfaces;
using System;
using System.Collections.Generic;

namespace _1_konfiguracje_debuging
{
    class Program
    {
        private static ISelfIntroduction standard;

        static void Main(string[] args)
        {
            standard = new StandardFlow();
            standard.Introduce();
#if DEBUG
            standard = new OtherFlow();
            standard.Introduce();
 
#endif
        }
    }
}
