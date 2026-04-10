namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.That(Kata.TripleTrouble("this","test","lock"), Is.EqualTo("ttlheoiscstk"));
      Assert.That(Kata.TripleTrouble("aa","bb","cc"), Is.EqualTo("abcabc"));
      Assert.That(Kata.TripleTrouble("Bm", "aa", "tn"), Is.EqualTo("Batman"));
      Assert.That(Kata.TripleTrouble("LLh","euo","xtr"), Is.EqualTo("LexLuthor"));
    }
  }
}
