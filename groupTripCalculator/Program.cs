 /*
* Name: Semawi Deneke
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: October 14, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
*/
 
 
 // Constants
 const int slice_per_pizza = 8;
 const double tax_rate = 0.18;

// Part-1: The Trip

Console.Write("Round trip in miles: ");
 double roundTripMiles = Convert.ToDouble(Console.ReadLine());
Console.Write("Miles per gallon: ");
 double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.Write("Price per gallon: ");
 double pricePerGallon = Convert.ToDouble(Console.ReadLine());
Console.Write("How many pizzas: ");
 double numberOfPizzas = Convert.ToDouble(Console.ReadLine());
Console.Write("Price per pizza: ");
 double pricePerPizza = Convert.ToDouble(Console.ReadLine());

 double fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon);
 double pizzaCost = numberOfPizzas*pricePerPizza;
 double tripTotal = fuelCost + pizzaCost;

Console.WriteLine("        ");
Console.WriteLine($"Fuel cost: {fuelCost.ToString("C")}");
Console.WriteLine($"Pizza cost: {pizzaCost.ToString("C")}");
Console.WriteLine($"Trip total: {tripTotal.ToString("C")}");



// Part-2: The Group
 string[] names = { "Ada", "Grace", "Alan", "Katherine" };
 double[] hoursWorked = { 22, 15, 30, 18 };
 double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };
 double costPerPerson = tripTotal/names.Length;

Console.WriteLine("  ");
Console.WriteLine($"People going: {names.Length}");
Console.WriteLine($"Slices each: {((numberOfPizzas*slice_per_pizza)/names.Length).ToString("F1")}");
Console.WriteLine($"Cost per person: {costPerPerson.ToString("C")}");
Console.WriteLine("  ");

// Part-3: Who Works How Long
 double totalHours = 0;
 double totalTakeHome = 0;
 double longest = 0;
for (int i = 0; i<hourlyRates.Length; i++){ 
 double takeHomePay = TakeHomePay(hoursWorked[i], hourlyRates[i], tax_rate);
 double takeHomePerHour = takeHomePay/hoursWorked[i];
 double hoursToCover = HoursToCover(costPerPerson, takeHomePerHour);
Console.WriteLine($"{names[i]}: takes home {takeHomePay.ToString("C")} for {hoursWorked[i]} hours, {takeHomePerHour.ToString("C")} per hour, must work {hoursToCover.ToString("F2")} hours.");
 totalHours += hoursWorked[i];
 totalTakeHome += takeHomePay;
 longest = Math.Max(longest,hoursToCover);
}

Console.WriteLine("        ");
Console.WriteLine($"Total hours worked: {Convert.ToInt32(totalHours)}");
Console.WriteLine($"Total take home pay: {totalTakeHome.ToString("C")}");
Console.WriteLine($"Longest anyone must work: {longest.ToString("F2")}");


//Methods

// This method hands back the fuel cost
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallonsNeeded = miles/milesPerGallon;
    double fuelCost = gallonsNeeded*pricePerGallon;
    return fuelCost;
}

// This method hands back the take home pay
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double takeHomePay = (hours*hourlyRate)-(hours*hourlyRate)*taxRate;
    return takeHomePay;
}

// This method hands back the hours to cover(hours needed)
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    double hoursToCover = amountOwed/takeHomePerHour;
    return hoursToCover;
}