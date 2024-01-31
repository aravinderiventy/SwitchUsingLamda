using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CompleActionExecute : IActions
    {
        public void Execute()
        {
            Console.WriteLine("Complete Action executed");
        }
    }
}
