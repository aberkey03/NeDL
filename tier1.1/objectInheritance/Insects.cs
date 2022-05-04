using System;

namespace CollectionApp
{
  class Insects : Animal
  {
      public bool canFly;
      public int numEyes;

      public Insects(bool iCanFly, int iNumEyes, int iWeight, string iSpecies, string iSound)
      {
        canFly = iCanFly;
        numEyes =iNumEyes;
        weight = iWeight;
        species = iSpecies;
        sound = iSound;
      }

      public override string ToString()
      {
          return $"INSECT: Can fly?: {canFly} Number of eyes: {numEyes} Weight: {weight} Species: {species}";
      }
  }
}