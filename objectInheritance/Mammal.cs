using System;

namespace CollectionApp
{
  class Mammal : Animal
  {
      public string furColor;

      public int runSpeed;

      public Mammal(string mFurColor, int mRunSpeed, int mWeight, string mSpecies, string mSound)
      {
          furColor = mFurColor;
          runSpeed = mRunSpeed;
          weight = mWeight;
          species = mSpecies;
          sound = mSound;

      }
      public Mammal()
      {
          furColor = null;
          runSpeed = -1;
          weight = -1;
          species = null;
      }

      public override string ToString()
      {
          return $"MAMMAL: Fur color: {furColor} Run speed: {runSpeed} Weight: {weight} Species: {species}";
      }
  }
}