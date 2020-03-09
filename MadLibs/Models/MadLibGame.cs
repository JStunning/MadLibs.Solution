using System;

namespace MadLibs.Models
{
  public class MadLibGame
  {
    public string Noun { get; set; }
    public string Verb { get; set; }
    public string Adjective { get; set; }
    public string Noun2 { get; set; }
    public string Verb2 { get; set; }
    public string Exclamation { get; set; }

    public MadLibGame(string noun, string verb, string adjective, string noun2, string verb2, string exclamation)
    {
      Noun = noun;
      Verb = verb;
      Adjective = adjective;
      Noun2 = noun2;
      Verb2 = verb2;
      Exclamation = exclamation;
    }
  }
}