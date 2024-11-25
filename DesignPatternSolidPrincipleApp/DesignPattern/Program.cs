using DesignPattern.Abstraction;
using DesignPattern.Coupling.HighCoupling;
using DesignPattern.Coupling.LooseCoupling;
using DesignPattern.DependencyInversion.Bad;
using DesignPattern.DependencyInversion.Good;
using DesignPattern.Encapsulation;
using DesignPattern.Liskov.Bad;
using DesignPattern.OpenClose.Bad;
using DesignPattern.OpenClose.Good;
using DesignPattern.Polymorphism;
using DesignPattern.SingleResponsability.Bad;
using DesignPattern.SingleResponsability.Good;

namespace DesignPattern;

internal class Program
{
    static void Main(string[] args)
    {
        DependencyInversion();
        //Liskov();
        //OpenClose();
        //SingleResponsability();
        //Coupling();
        //Polymorphism();
        //Abstraction();
        //Encapsulation();
    }

    private static void DependencyInversion()
    {
        B_Car bad_car1 = new(new B_Engine());
        bad_car1.Start();

        B_Car bad_car2 = new(new B_Elec_Engine());
        bad_car2.Start();

        B_Car bad_car3 = new(new B_HybridEngine());
        bad_car3.Start();

        DependencyInversion.Good.Car car1 = new(new Engine());
        car1.Start();

        DependencyInversion.Good.Car car2 = new(new Elec_Engine());
        car2.Start();

        DependencyInversion.Good.Car car3 = new(new HybridEngine());
        car3.Start();
    }

    public static void Liskov()
    {
        L_BadSquare badSquare = new L_BadSquare() { Length = 2, Width = 3 };
        Console.WriteLine($"{badSquare.Length} - {badSquare.Width} - {badSquare.Area}");

        L_BadRectangle badRectangle = new L_BadRectangle() { Length = 2, Width = 3 };
        Console.WriteLine($"{badRectangle.Length} - {badRectangle.Width} - {badRectangle.Area}");
    }

    public static void OpenClose()
    {
        BadShape badShape = new () { ShapeType = ShapeType.Circle, Radius = 5 };
        BadShape badShape2 = new () { ShapeType = ShapeType.Rectangle, Width = 5, Length = 2 };
        BadShape badShape3 = new () { ShapeType = ShapeType.RectangleTriangle, Width = 5, Length = 2 };
        Console.WriteLine(badShape.CalculateArea());
        Console.WriteLine(badShape2.CalculateArea());
        Console.WriteLine(badShape3.CalculateArea());

        Shape rectangle = new Rectangle() { Width = 2, Length = 3};
        Shape circle = new Circle() { Radius = 2};
        Shape rectangleTriangle = new RectangleTriangle() { Width = 2, Length = 3};
        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(rectangleTriangle.CalculateArea());
    }

    public static void SingleResponsability()
    {
        BadUser badUser = new BadUser() { Name = "bob", Email = "bob@test.fr" };
        badUser.Register();

        User user = new () { Name = "bob", Email = "bob@test.fr" };
        UserService userService = new () { User = user};
        userService.Register();
    }

    public static void Coupling()
    {
        BadOrder badOrder = new ();
        badOrder.PlaceOrder();

        EmailSender emailSender = new ();
        SMSSender smsSender = new ();
        Order order = new Order() { Notify = emailSender.Send };
        order.PlaceOrder();
        order.Notify = smsSender.Send;
        order.PlaceOrder();
    }

    public static void Polymorphism()
    {
        List<Vehicle> vehicles = new()
        {
            new Polymorphism.Car() { Brand = "renaud", Year = 2000 },
            new Motorcycle() { Brand = "Guzzi", Year = 2010 },
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
        }

        foreach (var vehicle in vehicles)
        {
            vehicle.Stop();
        }
    }

    private static void Abstraction()
    {
        BadEmailService badEmailService = new();
        badEmailService.Connect();
        badEmailService.Authenticate();
        badEmailService.SendEmail();
        badEmailService.Disconnect();

        EmailService emailService = new();
        emailService.SendEmail();
    }

    private static void Encapsulation()
    {
        BadBankAccount badBankAccount = new() { Balance = 100 };
        badBankAccount.Balance = -50;
        Console.WriteLine(badBankAccount.Balance);

        BankAccount bankAccount = new(50);
        //bankAccount.Deposit(-50);
        bankAccount.Deposit(50);
        //bankAccount.Withdraw(-50);
        //bankAccount.Withdraw(150);
        //bankAccount.Withdraw(20);
        Console.WriteLine(bankAccount.Balance);
    }
}
