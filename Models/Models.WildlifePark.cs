using System;

namespace Wildlife.Models
{
  class Animal
  {
    public string Species;
    public int Age;
    public string Gender;

    public string PlaceOfBirth;

    public Animal (string species, int age, string gender, string placeOfBirth)
    {
      Species = species;
      Age = age;
      Gender = gender;
      PlaceOfBirth = placeOfBirth;
    }

    public string GetSpecies()
    {
      return Species;
    }
    public int GetAge()
    {
      return Age;
    }
    public string GetGender()
    {
      return Gender;
    }
    public string GetPlaceOfBirth()
    {
      return PlaceOfBirth;
    }
  }
}