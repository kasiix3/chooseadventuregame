using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our your next adventure.");
      Console.WriteLine();

      //First question - which path will they choose?
      Console.WriteLine("It's a typical summer day, and a group of friends join you for a trail walk. You come across a beaten path. Do you take it?");
      Console.Write("YES or NO?: ");
      string pathChoice = Console.ReadLine();
      string pathChoiceUpper = pathChoice.ToUpper();
if (pathChoice == "NO"){
  Console.WriteLine("Bummer, there could have been lost treasure! Guess you'll never know. The end.");
}
else if (pathChoice == "YES"){
  Console.WriteLine("You proceed down the beaten path. You and your friends find this awesome cliff! Your best friend decides to climb the cliff to take photos, so you join her while your other two friends stay at the bottom. When you reach the top, you find a hidden treasure chest. Do you open it?");}

  //Second question - will they open the chest?
  Console.Write("YES or NO?  ");
  string chestChoice = Console.ReadLine();
  string chestChoiceUpper = chestChoice.ToUpper();
  if (chestChoice == "YES"){
    Console.WriteLine("You quickly yell for your other friends to come check out what you've found. You noticed the chest is completely seal, with no seams. Suddenly, you hear a voice. It says \"Answer the riddle to open the chest: What is always in front of you, but you can't see it?");
  }
  else if (chestChoice == "NO"){
    Console.WriteLine("You respectfully the the chest untouched and proceed to explore the trail with your friends. You will always wonder if there was lost treasure in the chest!");
  }

  //Riddle - will they solve the riddle?
  Console.Write("Type your answer: The ______ (hint:lowercase letters only)  ");
  string riddleAnswer = Console.ReadLine();
  if (riddleAnswer == "The future") {
    Console.WriteLine("Correct! The future. The chest unlocks a seam allowing you to pry it open, only to find another obstacle. There is another compartment that needs unlocked! Your friend spots text on the inside of the chest along with three buttons that reads \"Choose wisely.");
  }
  else {
    Console.WriteLine("Before you get a chance, the chest quickly closes, and whispers in a voice \"Those who try again will be cursed!","You and your friends drop the box and take off running! You will never know what is in the box, but cannot take the risk of a curse! THE END!");
  }
  //Which button will they choose?
  Console.Write("Which button do your choose? 1, 2, or 3?  ");
  string button = Console.ReadLine();

  switch (button) {
    case "1":
    Console.WriteLine(" HOORAY!! You have unlocked the treasure chest! Inside you find pirates gold coins, necklaces, and rings for days! This will surely be enough to pay for your college tuition!");
    break;
    case "2":
    Console.WriteLine("Before you get a chance, the chest quickly closes, and whispers in a voice \"Those who try again will be cursed!","You and your friends drop the box and take off running! You will never know what is in the box, but cannot take the risk of a curse! THE END!");
    break;
     case "3":
    Console.WriteLine("Before you get a chance, the chest quickly closes, and whispers in a voice \"Those who try again will be cursed!","You and your friends drop the box and take off running! You will never know what is in the box, but cannot take the risk of a curse! THE END!");
    break;
    default:
    Console.WriteLine("Before you get a chance, the chest quickly closes, and whispers in a voice \"Those who try again will be cursed!","You and your friends drop the box and take off running! You will never know what is in the box, but cannot take the risk of a curse! THE END!");
    break;
  }
     
    }
  }
}



