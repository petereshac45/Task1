Console.WriteLine("welcome to in my landry");
Console.Write("Number of small carpets :");
int smallCarpet = Convert.ToInt32(Console.ReadLine())*25;
Console.Write("Number of large carpets :");
int largeCarpet = Convert.ToInt32(Console.ReadLine())*35;
double taxes = 6.6;
Console.WriteLine("Price of small carpets : 25$");
Console.WriteLine("Price of large carpets : 35$");
int res = smallCarpet + largeCarpet;
Console.WriteLine($"Cost {res}$");
Console.WriteLine($"tax : {taxes}$");
Console.WriteLine("===================================");
Console.WriteLine($"Total estitmante {res + taxes}$");
Console.WriteLine("This estimate is valid for 30 days");

