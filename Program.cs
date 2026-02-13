// Program Name: Module 1
// Created on: 10/02/2026
// Author: andbru test

// 11/02/2026 add in the avoid null input, example in onenote

static void food()
{
    Console.WriteLine("What food do you prefer? Pizza, hambrugers or pasta?");
    string FavoriteFood = Console.ReadLine();
    Console.WriteLine($"You like {FavoriteFood}.");

    if (FavoriteFood.ToLower() == "pasta")
    {
        Console.WriteLine("Do you prefer napoli or pesto sauce?");
    }
    string sauce = Console.ReadLine();
    Console.WriteLine($"So your favourite sauce on pasta is {sauce}.");
    
   
}

static void colours()
{
    
    Console.WriteLine("What is your favorite colour?");
    string FavoriteColour = Console.ReadLine();
    Console.WriteLine($"You like {FavoriteColour}. Do you prefer light or dark {FavoriteColour}?");
    string LightDark = Console.ReadLine();
    if (LightDark.ToLower() == "light" || LightDark.ToLower() == $"light {FavoriteColour.ToLower()}")
    {
        Console.WriteLine("Cool");
    }
    else if (LightDark.ToLower() == "dark" || LightDark.ToLower() == $"dark {FavoriteColour.ToLower()}")
    {
        Console.WriteLine("Great"); 
    }
    else
    {
        Console.WriteLine("Sorry, I do not understand what you mean");
    }

}

Console.Write("Hello, welcome to the ChatBot, Ai Free edition.");
Thread.Sleep(1000);
Console.WriteLine("\nWhat is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hi, {name}.");

Console.WriteLine($"So,{name}, what do you want to talk about first, colours or food?");
string TopicDecision = Console.ReadLine();


if (TopicDecision.ToLower() == "colours" || TopicDecision.ToLower() == "colour")
{
    colours();
      
    Console.WriteLine("Do you want to talk about food now? Yes or no?");
    string Decision2 = Console.ReadLine();
    if (Decision2.ToLower() == "yes")
    {
        food();
        Console.WriteLine("Thanks for chatting!");
    }
    
    else
    {
        Console.WriteLine("Thanks for chatting!");
    }

    

}


if (TopicDecision.ToLower() == "food")
{
    food();
    Console.WriteLine("Do you want to talk about colours now? Yes or no?");
    string Decision2 = Console.ReadLine();
    if (Decision2.ToLower() == "yes")
    {
        colours();
        Console.WriteLine("Thanks for chatting!");
    }

    else
    {
        Console.WriteLine("Thanks for chatting!");
    }
}