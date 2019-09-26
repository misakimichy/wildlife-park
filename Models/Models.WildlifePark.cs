using System;

namespace Wildlife.Models
{
  class Animal
  {
    private string _species;
    private int _age;
    private string _gender;

    private string _placeOfBirth;
    private string _condition;

    public Animal (string species, int age, string gender, string placeOfBirth, string condition)
    {
      _species = species;
      _age = age;
      _gender = gender;
      _placeOfBirth = placeOfBirth;
      _condition = condition;
    }

    public string GetSpecies()
    {
      return _species;
    }
    public int GetAge()
    {
      return _age;
    }
    public string GetGender()
    {
      return _gender;
    }
    public string GetPlaceOfBirth()
    {
      return _placeOfBirth;
    }
    public string GetCondition()
    {
      return _condition;
    }
    public void SetCondition(string newCondition)
    {
      Condition = newCondition;
    }
  }
}