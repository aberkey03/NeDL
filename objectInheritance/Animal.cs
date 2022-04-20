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
      public Animal ()
      {
          weight = -1;
          species = null;
      }
      public void MakeSound()
      {
          Console.WriteLine($"The {species} goes {sound}");
      }
      
  }
}