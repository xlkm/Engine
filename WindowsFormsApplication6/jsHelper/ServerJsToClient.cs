using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Permissions;
using System.Windows.Forms;

namespace jsHelper
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class ServerJsToClient
    {
        
        public object SetCurrentMethod(string methodName,object[] methodValue)
        {
            Core.MethodName = methodName;
            Core.MethodProperty = methodValue;
            //Core.jsEvent();
            /*
            if (isStart)
            {
                Core.jsEvent.Invoke();
                isStart = false;
            }*/
            while (Core.MethodName != null)
            {
                System.Threading.Thread.Sleep(100);
            }
            return Core.returnValue;
        }
    }
}
