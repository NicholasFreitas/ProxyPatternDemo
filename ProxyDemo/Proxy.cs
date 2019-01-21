using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    class Proxy : ISubject
    {
        Subject _subject = null;
        string _data = null;

        public Proxy(string data)
        {
            _data = data;
        }

        public void request()
        {
            if (_subject == null)
            {
                Console.WriteLine("Lazy Loaded Process.");
                _subject = new Subject(_data);
            }

            _subject.request();
            
        }
    }
}
