double squareFeet = double.Parse(Console.ReadLine());
double normalPrice = squareFeet * 7.61;
double discount = normalPrice * 0.18;
double total = normalPrice - discount;
Console.WriteLine($"The final price is: {total} lv.");
Console.WriteLine($"The discount is: {discount} lv.");