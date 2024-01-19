using _19012024;

Car car = new Car();    
Bicycle bicycle= new Bicycle();

string brand = "";
string opt;

do
{
    Console.WriteLine("\n1. Masina ve velosipede bax");
    Console.WriteLine("2. Yeni masin elave et");
    Console.WriteLine("3. Yeni velosiped elave et");
    Console.WriteLine("4. Masin sur");
    Console.WriteLine("5. Velosiped sur");
    Console.WriteLine("6. Refuel");
    Console.WriteLine("0. Proqrami bitir");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            ShowVehicle(car,bicycle);
            break;
            
        case "2":
            CreateCar(car);
            Console.WriteLine("Masin yaradildi !");
            break;

        case "3":
            CreateBicycle(bicycle);
            Console.WriteLine("Velosiped yaradildi !");
            break;

        case "4":
            string surusStr;
            decimal surus;
            Console.WriteLine("Surus mesafesi daxil edin");
            do
            {
                surusStr = Console.ReadLine();

            } while (!decimal.TryParse(surusStr, out surus) || surus < 0);
            car.Drive(surus);
            break; 

        case "5":
            string kmStr;
            decimal km;
            Console.WriteLine("Surus mesafesi daxil edin");
            do
            {
                kmStr = Console.ReadLine();

            } while (!decimal.TryParse(kmStr, out km) || km < 0);
            bicycle.Drive(km);
            break;

        case "6":
            string walletStr;
            decimal wallet;
            Console.WriteLine("Budcenizi daxil edin : ");
            do
            {
                walletStr = Console.ReadLine();

            } while (!decimal.TryParse(walletStr, out wallet) || wallet < 0);
            car.Refuel(wallet);
            break;

        default:
            Console.WriteLine("Duzgun operator daxil edin!");
            break;

    }


} while (opt != "0");

static void ShowVehicle(Car car,Bicycle bicycle)
{
    Console.WriteLine("===== Masin =====");
    Console.WriteLine($"Brend  - {car.Brand} , Model - {car.Model} , Milleage - {car.Milleage} km , Fuel - {car.CurrentFuel}/{car.FuelCapacity} ");

    Console.WriteLine("===== Velosiped =====");
    Console.WriteLine($"Brend - {bicycle.Brand} , Model - {bicycle.Model} , Milleage - {bicycle.Milleage} km ");
}


static void CreateCar(Car car)
{
    string brand;
    string model;
    string FuelCapacityStr;
    int FuelCapacity;
    string CurrentFuelStr;
    decimal CurrentFuel;
    string FuelFor1KMStr;
    decimal FuelFor1KM;
    do
    {
        Console.WriteLine("\nBrandi daxil edin ");
        brand = Console.ReadLine();

    } while (string.IsNullOrEmpty(brand));

    do
    {
        Console.WriteLine("Modeli daxil edin ");
        model = Console.ReadLine();

    } while (string.IsNullOrEmpty(model));

    do
    {
        Console.WriteLine("Fuel capacity daxil edin ");
        FuelCapacityStr = Console.ReadLine();

    } while(!int.TryParse(FuelCapacityStr, out FuelCapacity) || FuelCapacity < 0);

    do
    {
        Console.WriteLine("Current fuel daxil edin ");
        CurrentFuelStr = Console.ReadLine();

    } while (!decimal.TryParse(CurrentFuelStr, out CurrentFuel) || CurrentFuel < 0 || CurrentFuel>FuelCapacity);

    do
    {
        Console.WriteLine("Fuel for 1 km daxil edin ");
        FuelFor1KMStr = Console.ReadLine();

    } while (!decimal.TryParse(FuelFor1KMStr, out FuelFor1KM) || FuelFor1KM < 0 || FuelFor1KM > FuelCapacity);



    car.Brand = brand;
    car.Model = model;
    car.FuelCapacity = FuelCapacity;
    car.CurrentFuel = CurrentFuel;
    car.FuelFor1KM= FuelFor1KM;
    
}

static void CreateBicycle(Bicycle bicycle)
{
    string brand;
    string model;
    
    do
    {
        Console.WriteLine("\nBrandi daxil edin ");
        brand = Console.ReadLine();

    } while (string.IsNullOrEmpty(brand));

    do
    {
        Console.WriteLine("Modeli daxil edin ");
        model = Console.ReadLine();

    } while (string.IsNullOrEmpty(model));

    
    bicycle.Brand = brand;
    bicycle.Model = model;
   
}



