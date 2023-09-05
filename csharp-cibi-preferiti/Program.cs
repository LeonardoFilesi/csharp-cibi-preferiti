// See https://aka.ms/new-console-template for more information

var colorName = "Blallo";

Console.WriteLine("Ciao, sono una persona molto indecisa, infatti il mio cibo preferito è" + colorName );

Console.WriteLine("Ma riguardo il cibo???");

string[] favFood = {"Pizza", "Carbonara", "Tiramisù", "Sushi", "Parmigiana", "Lasagna", "Pallotte Cacio e Ova" };

int foodQuantity = favFood.Length;

Console.WriteLine("Il mio cibo preferito");
 foreach (string food in favFood)
{
    Console.WriteLine(food);
}

 Console.WriteLine("mi piace veramente tanto cibo, per l'appunto mi piacciono ben" +  foodQuantity + "cibi diversi");