using System;
using System.Collections.Generic;
using Wildlife.Models;

namespace Wildlife
{
  class Program
  {
    public static void Main()
    {
      Animal lion = new Animal("Lion", 2, "Male", "Savanna");
      Animal elephant = new Animal("Indian elephant", 10, "Female", "India");
      Animal polarBear = new Animal("Polar bear", 5, "Male","Alaska");
      Animal rhino = new Animal("White rhinoceros", 8, "Female", "South Africa");

      List<Animal> Animals = new List<Animal>() { lion, elephant, polarBear, rhino };

      Console.WriteLine("These are the list of the wildlife.");
      foreach(Animal animal in Animals)
      {
        Console.WriteLine("-----------------------");
        Console.WriteLine(animal.GetSpecies());
        Console.WriteLine(animal.GetAge());
        Console.WriteLine(animal.GetGender());
        Console.WriteLine(animal.GetPlaceOfBirth());
      }
    }
  }
}