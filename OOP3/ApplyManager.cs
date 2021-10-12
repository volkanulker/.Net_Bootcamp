using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplyManager
    {
        // method injection
        public void Apply(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void CheckCreditInfo(List<ICreditManager> creditManagers)
        {
            foreach (ICreditManager creditManager in creditManagers)
            {
                creditManager.Calculate();
            }
        }

    }
}
