using System;

namespace CollectionApp
{
  class Program
  {
    static void Main(string[] args)
    {
        //create array and 5 spaces
        Animal[] animalArray = new Animal[5];
        for (int i = 0; i < animalArray.Length; i++)
        {
            animalArray[i]=new Animal();
        }

        Bird cardinal = new Bird(3,10,1,"cardinal", "caw caw");
        animalArray[1] = cardinal;

        Mammal dog = new Mammal("brown",10,5,"dog", "woof");
        animalArray[2] = dog;

        Insects cricket = new Insects(true, 6, 1,"cricket", "chrip chirp");
        animalArray[3] = cricket;
        
        Console.WriteLine(animalArray[1]);
        animalArray[1].MakeSound();
        
        Console.WriteLine(animalArray[2]);
        animalArray[2].MakeSound();

        Console.WriteLine(animalArray[3]);
        animalArray[3].MakeSound();

    }
  }
}