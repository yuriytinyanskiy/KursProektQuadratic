using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    public struct ResponseOutput
    {

        public string Message {get;set;}
        
        public ResponseOutput (Solver b)
        {
            Message = b.Message;
        }

    }
}
