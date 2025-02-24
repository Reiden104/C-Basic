double grass = double.Parse(Console.ReadLine());
double price = grass * 7.61;
double discount = 0.18 * price;
double priceDiscount = price - discount;
Console.WriteLine($"The final price is: {priceDiscount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");