using System;

namespace CollectionApp
{
  class Bird : Animal
  {
      public int wingSpan
      {get;set;}

      public int flightSpeed
      {get;set;}

      public Bird (int bWingSpan, int bFlightSpeed, int bWieght, string bSpecies, string bSound)
      {
          wingSpan = bWingSpan;
          flightSpeed = bFlightSpeed;
          weight = bWieght;
          species = bSpecies;
          sound = bSound;
      }
      public Bird()
      {
          wingSpan = -1;
          flightSpeed = -1;
          weight = -1;
          species = null;
      }

      public override string ToString()
      {
          return $"BIRD: Wingspan: {wingSpan} Flightspeed: {flightSpeed} Weight: {weight} Species: {species}";
      }

  }
}