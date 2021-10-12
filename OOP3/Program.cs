using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggerServices = new List<ILoggerService>() {databaseLoggerService, fileLoggerService };
           
            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(vehicleCreditManager, loggerServices);

            List<ICreditManager> creditManagers = new List<ICreditManager>() {needCreditManager,vehicleCreditManager,houseCreditManager };
            //applyManager.CheckCreditInfo(creditManagers);
        
        }
    }
}
