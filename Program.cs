using System;
using System.Collections.Generic;
using Wildlife.Models;

namespace Wildlife
{
  class Program
  {
      private static Animal lion = new Animal("Lion", 2, "Male", "Savanna");
      private static Animal elephant = new Animal("Indian elephant", 10, "Female", "India");
      private static Animal polarBear = new Animal("Polar bear", 5, "Male","Alaska");
      private static Animal rhino = new Animal("White rhinoceros", 8, "Female", "South Africa");

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
    public static void Main()
    {
      getAnimalInfo();
    }
  }
}