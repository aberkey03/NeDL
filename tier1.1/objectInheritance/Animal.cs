using System;

namespace CollectionApp
{
  class Animal
  {
      public int weight;
      public string species;
      public string sound;

      public Animal(int aWeight, string aSpecies) 
      {
          weight = aWeight;
          species = aSpecies;
      }
      public Animal () //default constructor 
      {
          weight = -1;
          species = null;
      }
      public void MakeSound() //accessible by all sub classes
      {
          Console.WriteLine($"The {species} goes {sound}");
      }
      
  }
}