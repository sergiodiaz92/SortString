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
        private List<string> FiveStringSample2()
        {
            return new List<string> {
                "xqycs",
                "beoax",
                "afkso",
                "bldit",
                "gwrys"
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
        private List<string> TenStringSample2()
        {
            return new List<string> {
                "qakmc",
                "rrtbk",
                "vaixn",
                "wmpnj",
                "uproi",
                "btska",
                "ejqwr",
                "elwlg",
                "oaoiy",
                "hrqkn"
            };
        }

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
                SortString.Sort.sortStrings(2, TwoStringSample());
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
                SortString.Sort.sortStrings(3, ThreeStringSample());
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
                SortString.Sort.sortStrings(5, FiveStringSample());
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
                SortString.Sort.sortStrings(5, FiveStringSample2());
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
                SortString.Sort.sortStrings(10, TenStringSample());
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
                SortString.Sort.sortStrings(10, TenStringSample2());
                string expected = $"ackmq{Environment.NewLine}rrbkt{Environment.NewLine}ainvx{Environment.NewLine}jmnpw{Environment.NewLine}iopru{Environment.NewLine}abkst{Environment.NewLine}ejqrw{Environment.NewLine}llegw{Environment.NewLine}ooaiy{Environment.NewLine}hknqr{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
       }
    }
}