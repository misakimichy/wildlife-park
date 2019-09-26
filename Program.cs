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
      Animal elephant = new Animal("Elephant", 10, "Female", "India");
      Animal polarBear = new Animal("Polar Bear", 5, "Male","Alaska");
      Animal rhino = new Animal("White Rhinoceros", 8, "Female", "South Africa");
    }
  }
}