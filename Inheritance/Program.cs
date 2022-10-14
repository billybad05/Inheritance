using Inheritance;

Console.WriteLine("Inheritance");

Chef chef = new Chef();
chef.MakeSpecialDish();

ItalianChef italianChef = new ItalianChef();
italianChef.MakeSpecialDish();