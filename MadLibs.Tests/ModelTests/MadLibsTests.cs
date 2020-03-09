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
      MadLibGame madLib = new MadLibGame("hat", "run", "happy", "tool", "smack", "OOF!");
      Assert.AreEqual(typeof(MadLibGame), madLib.GetType());
    }

    [TestMethod]
    public void MadLibGameConstructor_CreateMadLibGame_MadLibGame()
    {
      MadLibGame madLib = new MadLibGame("hat", "run", "happy", "tool", "smack", "OOF!");
      string resultNoun = madLib.Noun;
      string resultNoun2 = madLib.Noun2;
      string resultVerb = madLib.Verb;
      string resultVerb2 = madLib.Verb2;
      string resultAdjective = madLib.Adjective;
      string resultExclamation = madLib.Exclamation;

      Assert.AreEqual("hat", resultNoun);
      Assert.AreEqual("run", resultNoun2);
      Assert.AreEqual("happy", resultVerb);
      Assert.AreEqual("tool", resultVerb2);
      Assert.AreEqual("smack", resultAdjective);
      Assert.AreEqual("OOF!", resultExclamation);

    }
  }
}