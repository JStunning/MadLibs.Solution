using System;

namespace MadLibs.Models
{
  public class MadLibGame
  {
    public string Name { get; set; }
    public string City { get; set; }

    public MadLibGame(string name)
    {
      Name = name;
      City = "Seattle";
    }

    public bool MethodName()
    {
      return true;
    }
  }
}