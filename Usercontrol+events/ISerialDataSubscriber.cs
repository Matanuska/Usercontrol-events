using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usercontrol_events
{
    interface ISerialDataSubscriber
    {
        void serialDataReceived(string incr,string msg);
    }
}
