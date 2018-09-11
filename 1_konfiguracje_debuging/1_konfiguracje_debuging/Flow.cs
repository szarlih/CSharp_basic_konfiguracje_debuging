using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_konfiguracje_debuging
{
    public abstract class Flow
    {
        protected string _name;

        virtual public void Introduce()
        {
            Console.WriteLine(_name);
            Console.ReadLine();
        }
    }
}
