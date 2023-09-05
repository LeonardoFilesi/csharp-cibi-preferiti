// See https://aka.ms/new-console-template for more information

var colorName = "Blallo";

Console.WriteLine("Ciao, sono una persona molto indecisa, infatti il mio cibo preferito è" + colorName );

Console.WriteLine("Ma riguardo il cibo???");

string[] favFood = {"Pizza", "Carbonara", "Tiramisù", "Parmigiana", "Lasagna", "Pallotte Cacio e Ova", "Sushi" };

int foodQuantity = favFood.Length;

var firstFavFood = favFood[0];
var leastFavFood = favFood[6];

Console.WriteLine("Ecco il mio cibo preferito:");
 foreach (string food in favFood)
{
    Console.WriteLine(food);
}

Console.WriteLine("mi piace veramente tanto cibo, per l'appunto mi piacciono ben" +  foodQuantity + "cibi diversi");

Console.WriteLine("Ma per quanto tanto cibo mi piaccia, il mio più preferito di tutti più più, è" +  firstFavFood);

Console.WriteLine("Anche se tutti i miei cibi preferiti sono eccezionali, quello che, pur facendomi impazzire, gradisco meno è il" + leastFavFood + "il cibo italiano è sempre meglio");

if(favFood.Length%2 == 1)
{
    int middleFood = favFood.Length/2;
    Console.WriteLine("A metà della mia classifica di cibo c'è" + middleFood);
}
else
{
    int middleFood1 = favFood.Length/2;
    int middleFood2 = middleFood1 + 1;

    Console.WriteLine("A metà della mia classifica di cibo ci sono" + middleFood1 + "e" + middleFood2);
}