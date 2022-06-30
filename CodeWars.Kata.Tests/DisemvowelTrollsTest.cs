using NUnit.Framework;

namespace CodeWars.Kata.Tests
{
    [TestFixture]
    public class DisemvowelTrollsTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemvowelTrolls.Disemvowel("This website is for losers LOL!"));
        }

        [Test]
        public void MultilineString()
        {
            Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", DisemvowelTrolls.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
        }

        [Test]
        public void OneMoreForGoodMeasure()
        {
            Assert.AreEqual("Wht r y,  cmmnst?", DisemvowelTrolls.Disemvowel("What are you, a communist?"));
        }
    }


}
