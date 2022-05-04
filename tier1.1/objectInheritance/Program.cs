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

        //use Bird constructor to create cardinal object and store in animalArray
        Bird cardinal = new Bird(3,10,1,"cardinal", "caw caw");
        animalArray[1] = cardinal;

        Mammal dog = new Mammal("brown",10,5,"dog", "woof");
        animalArray[2] = dog;

        Insects cricket = new Insects(true, 6, 1,"cricket", "chrip chirp");
        animalArray[3] = cricket;

        Animal basic = new Animal ();
        animalArray[4] = basic;
        
        //write Bird ToString
        Console.WriteLine(animalArray[1]);
        //call Animal MakeSound Method, pulls cardinal sound
        animalArray[1].MakeSound();
        
        Console.WriteLine(animalArray[2]);
        animalArray[2].MakeSound();

        Console.WriteLine(animalArray[3]);
        animalArray[3].MakeSound();

        Console.WriteLine(animalArray[4]); // no ToString
        animalArray[4].MakeSound(); //used defualt constructorm has no species or sound

    }
  }
}