using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    /*
     
        The proxy acts as an interface for calling another object.
        In this example, the proxy is used to "lazy load" an object
        that is resource intensive.

        ------------
        |ISubject  | 
        ------------
        |request() |
        ------------
             |  
             |    
             | is-as
             |_________________________
             |                         |
             ^                         ^
             ^                         ^
        ------------             ------------
        | Subject  |    has-a    | Proxy    |
        ------------ <---------  ------------
        |request() |             |request() |
        ------------             ------------
 
         
         */

    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new Proxy("Pretend this is heavy data");
            proxy.request();

        }
    }
}
