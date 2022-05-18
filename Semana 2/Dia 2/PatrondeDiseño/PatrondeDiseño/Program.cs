using PatrondeDiseño.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrondeDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler redHandler = new RedHandler();
            Handler greenHandler = new GreenHandler();
            Handler blueHandler = new BlueHandler();

            redHandler.SetNextHandler(greenHandler);
            greenHandler.SetNextHandler(blueHandler);


            Request request = null;

            request = new Request("001", "Red");
            redHandler.ProcessRequest(request);

            request = new Request("002", "Green");
            redHandler.ProcessRequest(request);

            request = new Request("003", "Blue");
            redHandler.ProcessRequest(request);

            request = new Request("999", "White");
            redHandler.ProcessRequest(request);

            Console.ReadKey();
        }
    }
}
