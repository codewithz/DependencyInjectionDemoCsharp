using DependencyInjectionDemo.DI;
using DependencyInjectionDemo.Without_DI;
using Microsoft.Extensions.DependencyInjection;
using System;

public class Program
{
    public static void Main()
    {
        //Created ToyCar with RegularBattery
        IBattery regularBattery = new RegularBattery();
        IBattery rechargableBattery = new RechargableBattery();

        ToyCar toyCar = new ToyCar(regularBattery);
        toyCar.Run();
        Console.WriteLine("====================================="); 
        //Created ToyCar with RechargableBattery
        toyCar = new ToyCar(rechargableBattery);
        toyCar.Run();

        Console.WriteLine("=====================================");

        //IMessageService emailService = new EmailService();
        //Notification notification = new Notification(emailService);
        //notification.SendNotification("Hello World");

        //Set up the dependency injection container
        var serviceProvider=new ServiceCollection()
            .AddSingleton<IMessageService,EmailService>()    //Registering EmailService as IMessageService
            .BuildServiceProvider();

        //Resolve the dependency
        var notification = new Notification(serviceProvider.GetService<IMessageService>());

        notification.SendNotification("Hello World with Dependency Injection");
    }
}