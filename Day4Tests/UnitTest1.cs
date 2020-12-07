using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Day4;
using ChristmasUtils;

namespace Day4Tests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        ////public void PassWordlistTest()
        ////{

        ////    List<string> testInput = new List<string>();
        ////    testInput.Add("ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr: 1937 iyr: 2017 cid: 147 hgt: 183cm");
        ////    testInput.Add("iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884 hcl:#cfa07d byr:1929");
        ////    testInput.Add("hcl:#ae17e1 iyr:2013 eyr: 2024 ecl: brn pid: 760753108 byr: 1931 hgt: 179cm");
        ////    testInput.Add("hcl:#cfa07d eyr:2025 pid:166559648 iyr: 2011 ecl: brn hgt: 59in ");
        ////    // Act


        ////    PassportList pL = new PassportList(FileUtils.CreateTempFileFromList(testInput));

        ////    Assert.AreEqual(2, pL.ValidPasswordsCount(Validator.requiredFields));
        ////}

        [TestMethod]
        public void PassWordInvalidTest()
        {
            PassportList pL = new PassportList("invalid.dat");

            Assert.AreEqual(0, pL.ValidPasswordsCount(Validator.requiredFields));
        }

        [TestMethod]
        public void PassWordValidTest()
        {
            PassportList pL = new PassportList("valid.dat");

            Assert.AreEqual(4, pL.ValidPasswordsCount(Validator.requiredFields));
        }

        [TestMethod]
        public void byrInvalidTest()
        {

            KeyValuePair<string, string> kv = new KeyValuePair<string, string>("byr", "2003");

            Assert.AreEqual(false, Validator.IsFieldValid(kv));
        }

        [TestMethod]
        public void hgt_inch_InvalidTest()
        {

            KeyValuePair<string, string> kv = new KeyValuePair<string, string>("hgt", "190in");

            Assert.AreEqual(false, Validator.IsFieldValid(kv));
        }

        [TestMethod]
        public void hgt_nounits_InvalidTest()
        {

            KeyValuePair<string, string> kv = new KeyValuePair<string, string>("hgt", "190");

            Assert.AreEqual(false, Validator.IsFieldValid(kv));

        }

        [TestMethod]
        public void hcl_nohashtag_InvalidTest()
        {

            KeyValuePair<string, string> kv = new KeyValuePair<string, string>("hcl", "123abc");

            Assert.AreEqual(false, Validator.IsFieldValid(kv));

        }
 [TestMethod]
        public void pid_too_long_InvalidTest()
        {

            KeyValuePair<string, string> kv = new KeyValuePair<string, string>("pid", "0123456789");

            Assert.AreEqual(false, Validator.IsFieldValid(kv));

        }
        [TestMethod]
        public void ecl_wat_lol_InvalidTest()
        {

            KeyValuePair<string, string> kv = new KeyValuePair<string, string>("ecl", "wat");

            Assert.AreEqual(false, Validator.IsFieldValid(kv));

        }
    }
}
