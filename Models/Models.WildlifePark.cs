using System;

namespace Wildlife.Models
{
  class Animal
  {
    public string Species;
    public int Age;
    public string Gender;

    public string PlaceOfBirth;
    public string Condition;

    public Animal (string species, int age, string gender, string placeOfBirth, string condition)
    {
      Species = species;
      Age = age;
      Gender = gender;
      PlaceOfBirth = placeOfBirth;
      Condition = condition;
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
    public string GetCondition()
    {
      return Condition;
    }
    public void SetCondition(string newCondition)
    {
      Condition = newCondition;
    }
  }
}