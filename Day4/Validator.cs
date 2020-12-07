using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day4
{
    public static class Validator
    {
        public static readonly string[] requiredFields = { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
        public static readonly string[] eyeColors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

        public static bool IsFieldValid(KeyValuePair<string, string> kv)
        {
            switch (kv.Key)
            {
                case "byr":
                    if (kv.Value.Length !=4) { return false; }
                    if (Int32.Parse(kv.Value)< 1920 || Int32.Parse(kv.Value) > 2002) { return false; }
                    return true;
                case "iyr":
                    if (kv.Value.Length != 4) { return false; }
                    if (Int32.Parse(kv.Value) < 2010 || Int32.Parse(kv.Value) > 2020) { return false; }
                    return true;
                case "eyr":
                    if (kv.Value.Length != 4) { return false; }
                    if (Int32.Parse(kv.Value) < 2020 || Int32.Parse(kv.Value) > 2030) { return false; }
                    return true;
                case "hgt":
                    if (kv.Value.EndsWith("cm"))
                    {
                        int height = Int32.Parse(kv.Value.Remove(kv.Value.Length - 2));
                        if (height >= 150 && height <= 193) { return true; }
                    }
                    else if (kv.Value.EndsWith("in"))
                    {
                        int height = Int32.Parse(kv.Value.Remove(kv.Value.Length - 2));
                        if (height >= 59 && height <= 76) { return true; }
                    }
                    return false;
                case "hcl":
                    Regex reg_hcl = new Regex("#[a-fA-F0-9]{6}");
                    return reg_hcl.IsMatch(kv.Value);
                case "ecl":
                    if (Array.IndexOf(eyeColors, kv.Value) != -1) { return true; }
                    return false;
                case "pid":
                    Regex reg_pid = new Regex("^[0-9]{9}$");
                    return reg_pid.IsMatch(kv.Value);
                default:
                    return true;

            }


        }

    }
}
