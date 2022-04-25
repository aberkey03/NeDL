using System;

namespace AbstractEmployee
{
  abstract class People
  {
    public string EyeColor
    {get;set;}

    protected People()
    {
        EyeColor = "";
    }
    protected People(string newEyeColor)
    {
        EyeColor = newEyeColor;
    }

    public override string ToString()
    {
        return $"Eye Color: {EyeColor}";
    }

  }
}