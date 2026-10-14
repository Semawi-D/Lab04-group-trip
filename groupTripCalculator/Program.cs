 const int slice_per_pizza = 8;
 const double tax_rate = 0.18;

// Part-1: The Trip.

Console.Write("How long is round trip in miles? ");
 double roundTripMiles = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the car's miles per gallon? ");
 double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.Write("How much is the price per gallon? ");
 double pricePerGallon = Convert.ToDouble(Console.ReadLine());
Console.Write("How many pizzas? ");
 double numberOfPizzas = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the price per pizza? ");
 double pricePerPizza = Convert.ToDouble(Console.ReadLine());

 double fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon);
 double pizzaCost = numberOfPizzas*pricePerPizza;
 double tripTotal = fuelCost + pizzaCost;

Console.WriteLine("        ");
Console.WriteLine($"Fuel cost: {fuelCost.ToString("C")}");
Console.WriteLine($"Pizza cost: {pizzaCost.ToString("C")}");
Console.WriteLine($"Trip total: {tripTotal.ToString("C")}");



//Part-2: The Group.
 string[] names = { "Ada", "Grace", "Alan", "Katherine" };
 double[] hoursWorked = { 22, 15, 30, 18 };
 double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };
 double costPerPerson = tripTotal/names.Length;

Console.WriteLine("  ");
Console.WriteLine($"People going: {names.Length}");
Console.WriteLine($"Slices each: {(numberOfPizzas*slice_per_pizza)/names.Length}");
Console.WriteLine($"Cost per person: {costPerPerson}");

/*Part-3: Paycheck.
 Console.WriteLine("        ");
 Console.Write("What are the hours worked this week? ");
  double weeklyHours = Convert.ToDouble(Console.ReadLine());

  //Console.Write("What is the hourly rate? ");
  double hourlyRate = Convert.ToDouble(Console.ReadLine());

  double grossPay = weeklyHours*hourlyRate;
  double taxWithheld = grossPay*tax_rate;
  double homePay = grossPay-taxWithheld;

  Console.WriteLine("        ");
  Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
  Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
  Console.WriteLine("Take home pay: " + homePay.ToString("C"));



//Part-4: The Whole Trip.
  
  double costPerPerson = tripTotal/numberOfPeople;
  double takeHomePayPerHour = homePay/weeklyHours;
  double requiredHours = costPerPerson/takeHomePayPerHour;

  Console.WriteLine("        ");
  Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
  Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
  Console.WriteLine("Hours you must work to cover your share: " + requiredHours.ToString("F2"));
  Console.WriteLine("        ");*/

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallonsNeeded = miles/milesPerGallon;
    double fuelCost = gallonsNeeded*pricePerGallon;
    return fuelCost;
}
//static double TakeHomePay(double hours, double hourlyRate, double taxRate)
//static double HoursToCover(double amountOwed, double takeHomePerHour)