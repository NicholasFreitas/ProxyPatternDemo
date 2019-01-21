using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    class Subject : ISubject
    {
        string _data;

        public Subject(string data)
        {
            _data = data;

        }


        public void request()
        {
            Console.WriteLine("Heavy Computational Process.");
        }
    }
}
