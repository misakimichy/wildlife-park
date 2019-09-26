using System;

namespace Wildlife.Models
{
  class Animal
  {
    public string Name;
    public int Age;
    public string Gender;

    public string PlaceOfBirth;

    public Animal (string name, int age, string gender, string placeOfBirth)
    {
      Name = name;
      Age = age;
      Gender = gender;
      PlaceOfBirth = placeOfBirth;
    }
  }
}