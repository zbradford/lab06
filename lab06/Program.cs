/*
* Name: Z Bradford
* Course: CSCI 1250, Section 201
* Assignment: Lab 06, Three Short Problems
* Date: October 24, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

int choice = 0;
Random rng = new Random(4000);
//do while: they need to know the choices before they can make a desicion
do
{

//do while: the info has the print out before the person can choose an onption within the parameters
do
{
Console.WriteLine(" ");
Console.WriteLine("=== CSCI 1250 Lab 06 ===");
Console.WriteLine(" ");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");
Console.WriteLine(" ");

Console.Write("Choose 1 through 5: ");

choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
} while(choice < 1 && choice > 5);

if (choice == 1 || choice == 4) 
{
Console.WriteLine("=== Exercise 1: The Grade Checker ===");
Console.WriteLine(" ");

int score = -1;
//while: until the score is within the perameters, we need it to keep asking for a different response
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

Console.WriteLine("=== Exercise 2: The Dice Table ===");
Console.WriteLine(" ");


char answer = 'y';
int count = 0;
int countWin = 0;

//do while: we want the dice to roll before the person declares if they'd like to roll again
do
{
    
count++;
 int rollOne = rng.Next(1, 7);
 int rollTwo = rng.Next(1, 7);
 int total = rollOne + rollTwo;

if(rollOne == 1 && rollTwo == 1)
    {
        Console.WriteLine("Roll " + count + ": " + rollOne + " and " + rollTwo + ", total " + total + ". Snake eyes.");  
 Console.Write("Roll again? (y/n): ");
    }
    else if(rollOne == rollTwo)
    {
       Console.WriteLine("Roll " + count + ": " + rollOne + " and " + rollTwo + ", total " + total + ". Doubles!");  
 Console.Write("Roll again? (y/n): ");
    }
    else if(total == 7 || total == 11)
    {
        Console.WriteLine("Roll " + count + ": " + rollOne + " and " + rollTwo + ", total " + (rollOne + rollTwo) + ". A winner.");
        countWin++;  
 Console.Write("Roll again? (y/n): ");
    }
    else
    {
        Console.WriteLine("Roll " + count + ": " + rollOne + " and " + rollTwo + ", total " + (rollOne + rollTwo) + ".");  
 Console.Write("Roll again? (y/n): ");
    }
    
answer = Console.ReadLine().ToUpper()[0];
} while(answer != 'N');

Console.WriteLine("You rolled " + count + " times and won " + countWin + ".");
}

if (choice == 3 || choice == 4)
{
Console.WriteLine("=== Exercise 3: The Score Report ===");
Console.WriteLine(" ");
string input = "0";
int [] scores; 
scores = new int[5];

//for: we need to know the position of each value in the array, so we can determine the number of values
for(int i = 0; i < scores.Length; i++)
{
Console.Write("Score " + (i + 1) + ": ");
scores[i] = Convert.ToInt32(Console.ReadLine());
}


int total = 0;
int highest = 0;
int passing = 0;

//for each: we need to make an operation happen with every single value in the array
foreach(int value in scores)
{
    total += value;

    if(value > highest)
    {
        highest = value;
    }

    if (value >= 60)
    {
        passing++;
    }

}

//Calculations
double average = Convert.ToDouble(total) / scores.Length;

//Output
Console.WriteLine(" ");
Console.WriteLine("Scores entered: " + scores.Length);
Console.WriteLine("Total: " + total); 
Console.WriteLine("Average: " + average);
Console.WriteLine("Highest: " + highest);
Console.WriteLine("Passing: " + passing + " of " + scores.Length);
}

} while (choice != 5);
Console.WriteLine("Goodbye.");