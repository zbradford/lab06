Console.WriteLine("=== CSCI 1250 Lab 06 ===");

int choice = 0;

//do while: they need to know the choices before they can make a desicion
do
{
//do while: the info has the print out before the person can choose an onption within the parameters
do
{
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");

Console.Write("Choose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());
} while(choice < 1 && choice > 5);

if (choice == 1 || choice == 4) 
{
Console.WriteLine("=== Exercise 1: The Grade Checker ===");

int score = -1;
while(score < 0 || score > 100)
{
    Console.WriteLine("A score must be between 0 and 100.");
    Console.Write("Score: ");
    score = Convert.ToInt32(Console.ReadLine());
}
if(score >= 90)
{
    Console.WriteLine(score.ToString() + " earns an A.");
}
else if(score >= 80)
{
    Console.WriteLine(score.ToString() + " earns a B.");
}
else if(score >= 70)
{
    Console.WriteLine(score.ToString() + " earns a C.");
}
else if(score >= 60)
{
    Console.WriteLine(score.ToString() + " earns a D");
}
else if(score < 60)
{
    Console.WriteLine(score.ToString() + " earns an F.");
}
}
if (choice == 2 || choice == 4)
{
// Exercise 2
}
if (choice == 3 || choice == 4)
{
// Exercise 3
}

} while (choice != 5);
Console.WriteLine("Goodbye.");
