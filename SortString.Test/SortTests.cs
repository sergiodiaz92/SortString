using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace SortString.Test
{
    [TestFixture]
    public class SortTests
    {
        private List<string> TwoStringSample()
        {
            return new List<string> {
                "abaccadcc",
                "xyzxy"
            };
        }
        private List<string> ThreeStringSample()
        {
            return new List<string> {
                "pzjim",
                "njnfq",
                "xyohs"
            };
        }
        private List<string> FiveStringSample()
        {
            return new List<string> {
                "wzenwebuau",
                "vokfxzynwl",
                "neldfeyrxk",
                "wqadfiodgs",
                "ykiuvzfcbc"
            };
        }
        private List<string> TenStringSample()
        {
            return new List<string> {
                "dulgvgzwqg",
                "gxtjtmtywr",
                "hnlnxiupgt",
                "gzjotckivp",
                "dpwwsdptae",
                "pcscpilknb",
                "btvyhhmflf",
                "artrtnqxcr",
                "nrtcmcoadn",
                "fkdsgnekft"
            };
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SortStringTwoStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(2, TwoStringSample());
                string expected = $"ccccaaabd{Environment.NewLine}xxyyz{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortStringThreeStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(3, ThreeStringSample());
                string expected = $"ijmpz{Environment.NewLine}nnfjq{Environment.NewLine}hosxy{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortStringFiveStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(5, FiveStringSample());
                string expected = $"eeuuwwabnz{Environment.NewLine}fklnovwxyz{Environment.NewLine}eedfklnrxy{Environment.NewLine}ddafgioqsw{Environment.NewLine}ccbfikuvyz{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SortStringTenStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                SortString.Sort.sortStrings(10, TenStringSample());
                string expected = $"gggdlquvwz{Environment.NewLine}tttgjmrwxy{Environment.NewLine}nnghilptux{Environment.NewLine}cgijkoptvz{Environment.NewLine}ddppwwaest{Environment.NewLine}ccppbiklns{Environment.NewLine}ffhhblmtvy{Environment.NewLine}rrrttacnqx{Environment.NewLine}ccnnadmort{Environment.NewLine}ffkkdegnst{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}