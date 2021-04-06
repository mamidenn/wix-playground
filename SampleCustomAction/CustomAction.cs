using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SampleCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            session.Log("Begin CustomAction1");

            var installed = session.EvaluateCondition("Installed");
            if(!installed)
            {
                session.Message(InstallMessage.Info, new Record("Thank you for installing this product!"));
            }
            
            return ActionResult.Success;
        }
    }
}
