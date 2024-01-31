using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CloseActionExecute : IActions
    {
        public void Execute()
        {
            Console.WriteLine("Close Action is executed");
        }
    }
}
