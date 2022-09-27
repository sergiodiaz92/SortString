using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace SortString.Test
{
    [TestFixture]
    public class SortTests
    {       

        [Test]
        public void SortStringEmptyString()
        {
            string result = SortString.Sort.sortString("");
            string expected = "-404";
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SortStringOneString()
        {
                string result = SortString.Sort.sortString("abaccadcc");
                string expected = "ccccaaabd";
                Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortListOfTwoStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(2, Samples.TwoStringSample());
                string expected = $"ccccaaabd{Environment.NewLine}xxyyz{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortListOfThreeStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(3, Samples.ThreeStringSample());
                string expected = $"ijmpz{Environment.NewLine}nnfjq{Environment.NewLine}hosxy{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortListOfFiveStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(5, Samples.FiveStringSample());
                string expected = $"eeuuwwabnz{Environment.NewLine}fklnovwxyz{Environment.NewLine}eedfklnrxy{Environment.NewLine}ddafgioqsw{Environment.NewLine}ccbfikuvyz{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortListOfFiveStrings2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(5, Samples.FiveStringSample2());
                string expected = $"cqsxy{Environment.NewLine}abeox{Environment.NewLine}afkos{Environment.NewLine}bdilt{Environment.NewLine}grswy{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortListOfTenStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(10, Samples.TenStringSample());
                string expected = $"gggdlquvwz{Environment.NewLine}tttgjmrwxy{Environment.NewLine}nnghilptux{Environment.NewLine}cgijkoptvz{Environment.NewLine}ddppwwaest{Environment.NewLine}ccppbiklns{Environment.NewLine}ffhhblmtvy{Environment.NewLine}rrrttacnqx{Environment.NewLine}ccnnadmort{Environment.NewLine}ffkkdegnst{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortListOfTenStrings2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(10, Samples.TenStringSample2());
                string expected = $"ackmq{Environment.NewLine}rrbkt{Environment.NewLine}ainvx{Environment.NewLine}jmnpw{Environment.NewLine}iopru{Environment.NewLine}abkst{Environment.NewLine}ejqrw{Environment.NewLine}llegw{Environment.NewLine}ooaiy{Environment.NewLine}hknqr{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
       }
    }
}