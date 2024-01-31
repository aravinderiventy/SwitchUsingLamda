using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class ActionFactory 
    {
        static public IActions? GetActionType(string actionName)
        {
            IActions? actionObj = actionName switch
            {
                "Close" => new CloseActionExecute(),
                "Complete" => new CompleActionExecute(),
                _ => null
            } ;

            //IActions actionObj;

            //if (actionName == "Close")
            //{
            //    actionObj=new CloseActionExecute();
            //}
            //else if (actionName == "Complete")
            //{
            //    actionObj=new CompleActionExecute();
            //}
            //else
            //{
            //    actionObj = null;
            //}

            return actionObj;
        }
    }
}
