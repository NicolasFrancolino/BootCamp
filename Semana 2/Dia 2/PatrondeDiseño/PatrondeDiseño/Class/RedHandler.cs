using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrondeDiseño.Class
{
   
        public class RedHandler : Handler
        {
            public override void ProcessRequest(Request request)
            {
                if (request.Color == "Red")
                    Console.WriteLine($"{this.GetType().Name} approved request {request.Code} as {request.Color}");
                else if (NextHandler != null)
                    NextHandler.ProcessRequest(request);
            }
        }
    }

