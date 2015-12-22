using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenceyInjectionDemo.Services
{
    public class GreetingService:IGreetingService
    {

        public string GetGreeting()
        {

            return "Wales are at the euro's !!!" + " " + GetHashCode();
        }
    }
}
