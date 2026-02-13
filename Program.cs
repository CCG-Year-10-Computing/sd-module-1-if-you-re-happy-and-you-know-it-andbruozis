// Program Name: Module 1
// Created on: 10/02/2026
// Author: andbru



static void food()
{
    Console.WriteLine("What food do you prefer? Pizza, hambrugers or pasta?");
    Console.Write("> ");
    string FavoriteFood = Console.ReadLine();
    Console.WriteLine($"You like {FavoriteFood}.");

    if (FavoriteFood.ToLower() == "pasta")
    {
        Console.WriteLine("Do you prefer napoli or pesto sauce?");
        Console.Write("> ");
        string sauce = Console.ReadLine();
        if (sauce.ToLower() != "napoli" || sauce.ToLower() != "pesto")
        {
            Console.WriteLine("That's not what I asked, but that's okay. Let's talk about colours now.");
            colours();
        }
        Console.WriteLine($"So your favourite sauce on pasta is {sauce}.");
    }
    
    
   
}

static void colours()
{
    
    Console.WriteLine("What is your favorite colour?");
    Console.Write("> ");
    string FavoriteColour = Console.ReadLine();
    Console.WriteLine($"You like {FavoriteColour}. Do you prefer light or dark {FavoriteColour}?");
    Console.Write("> ");
    string LightDark = Console.ReadLine();
    if (LightDark.ToLower() == "light" || LightDark.ToLower() == $"light {FavoriteColour.ToLower()}")
    {
        Console.WriteLine("Cool, I like light colours!");
    }
    else if (LightDark.ToLower() == "dark" || LightDark.ToLower() == $"dark {FavoriteColour.ToLower()}")
    {
        Console.WriteLine("Dark shades are cool"); 
    }
    else
    {
        Console.WriteLine("Sorry, I do not understand what you mean");
    }

}



Console.Write("Hello, welcome to the ChatBot, Ai Free edition.");
Thread.Sleep(1000);
Console.WriteLine("\nWhat is your name?");
Console.Write("> ");
string name = Console.ReadLine();
Console.WriteLine($"Hi,{name}.");


Console.WriteLine($"So,{name}, what do you want to talk about first, colours or food?");
Console.Write("> ");
string TopicDecision = Console.ReadLine();


if (TopicDecision.ToLower() == "colours" || TopicDecision.ToLower() == "colour")
{
    colours();

    Console.WriteLine("Do you want to talk about food now? Yes or no?");
    Console.Write("> ");
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


else if (TopicDecision.ToLower() == "food")
{
    food();
    Console.WriteLine("Do you want to talk about colours now? Yes or no?");
    Console.Write("> ");
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

else
{
    Console.WriteLine("Sorry, I can't help you today.");
}

