// See https://aka.ms/new-console-template for more information

int runTimes = 0;

do {
Console.WriteLine("Which rainbow color order would you like?");

int num = Convert.ToInt32(Console.ReadLine());

switch (num) {
    case 0:
        Console.WriteLine("Red");
        break;
    case 1:
        Console.WriteLine("Orange");
        break;
    case 2:
        Console.WriteLine("Yellow");
        break;
    case 3:
        Console.WriteLine("Green");
        break;
    case 4:
        Console.WriteLine("Blue");
        break;
    case 5:
        Console.WriteLine("Indigo");
        break;
    case 6:
        Console.WriteLine("Voilet");
        break;
    default:
        Console.WriteLine("ROYGBIV");
        break;
}
runTimes++;

} while(runTimes < 8);
