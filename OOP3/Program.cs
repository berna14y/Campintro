using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCreditManager = new ConsumerCreditManager(); //ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(new ArtisanCreditManager(), loggers);
                      

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager,vehicleCreditManager};

            //applicationManager.MakeCreditPreNotification(credits);
        }
    }
}
