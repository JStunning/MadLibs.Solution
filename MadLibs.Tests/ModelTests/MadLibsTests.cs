using MadLibs.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MadLibs.Tests
{
  [TestClass]
  public class MadLibGameTests
  {
    [TestMethod]
    public void MadLibGameConstructor_CreateMadLibGame_MadLibGame()
    {
      MadLibGame madLib = new MadLibGame("hat", "run", "happy", "tool", "smack", "OOF");
      Assert.AreEqual(typeof(MadLibGame), madLib.GetType());
    }

    [TestMethod]
    public void MadLibGameConstructor_CreateMadLibGame_Strings()
    {
      MadLibGame madLib = new MadLibGame("hat", "run", "happy", "tool", "smack", "OOF");
      string resultNoun = madLib.Noun;
      string resultVerb = madLib.Verb;
      string resultAdjective = madLib.Adjective;
      string resultNoun2 = madLib.Noun2;
      string resultVerb2 = madLib.Verb2;
      string resultExclamation = madLib.Exclamation;

      Assert.AreEqual("hat", resultNoun);
      Assert.AreEqual("run", resultVerb);
      Assert.AreEqual("happy", resultAdjective);
      Assert.AreEqual("tool", resultNoun2);
      Assert.AreEqual("smack", resultVerb2);
      Assert.AreEqual("OOF", resultExclamation);
    }
  }
}