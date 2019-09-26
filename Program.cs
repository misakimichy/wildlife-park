using System;
using System.Collections.Generic;
using Wildlife.Models;

namespace Wildlife
{
  class Program
  {
    private static Animal lion = new Animal("Lion", 2, "M", "Savanna", "Is sick");
    private static Animal elephant = new Animal("Indian elephant", 10, "F", "India", "Pregnant");
    private static Animal polarBear = new Animal("Polar bear", 5, "M","Alaska", "Agressive");
    private static Animal rhino = new Animal("White rhinoceros", 8, "F", "South Africa", "Good");

    public static List<Animal> Animals = new List<Animal>() { lion, elephant, polarBear, rhino };

    public static void getAnimalInfo()
    {
      Console.WriteLine("These are the list of the wildlife.");
      foreach(Animal animal in Animals)
      {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Species: " + animal.GetSpecies());
        Console.WriteLine("Age: " + animal.GetAge());
        Console.WriteLine("Gender: " + animal.GetGender());
        Console.WriteLine("They are from: " + animal.GetPlaceOfBirth());
      }
    }

    public static void addNewAnimal()
    {
      Console.WriteLine("Would you like to add another animal? (Y/N)");
      string answer = Console.ReadLine().ToUpper();
      if (answer == "Y")
      {
        Console.WriteLine("Please enter the species of the new animal.");
        string species = Console.ReadLine();
        Console.WriteLine("Please enter the age.");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the gender.(M/F)");
        string gender = Console.ReadLine().ToUpper();
        Console.WriteLine("Please enter where they are from.");
        string placeOfBirth = Console.ReadLine();
        Console.WriteLine("Please enter the current condition.");
        string condition = Console.ReadLine();
        Animal newAnimal = new Animal (species, age, gender, placeOfBirth, condition);
        Animals.Add(newAnimal);
        Main();
      }
      else if (answer == "N")
      {
        Console.WriteLine("Would you like to update the registered animals information? (Y/N)");
        answer = Console.ReadLine().ToUpper();
        if (answer == "Y")
        {
          Console.WriteLine("Enter the number that you'd like to update: ");
          // loop through the Animal list and update the current property
          for (int i = 0; i < Animals.Count; i++)
          {
            Console.WriteLine(i + ": " + Animals[i].GetSpecies());
          }
          int id = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter its new condition.");
          string condition = Console.ReadLine();
          Animals[id].SetCondition(condition);
        }
      }
      else
      {
        Console.WriteLine("Please answer with 'Y' or 'N'");
      }
    }
    public static void Main()
    {
      getAnimalInfo();
      addNewAnimal();
    }
  }
}