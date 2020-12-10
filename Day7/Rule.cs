using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    public class Rule
    {
        internal Dictionary<string,int> inner_bags = new Dictionary<string, int>();
        public string basecolor;
        public string cleanedRule;
        public Rule(string input) 
        {
            cleanedRule = Clean(input);
            string[] parts = cleanedRule.Split(":");
            basecolor = parts[0];
            string[] bags_input = parts[1].Split(";");
            foreach (string bi in bags_input)
            {
                int firstspace = bi.IndexOf(" ");
                if (firstspace != -1)
                {
                    int num = Int32.Parse(bi.Substring(0, firstspace ));
                    string bagname = bi.Substring(firstspace);
                    inner_bags.Add(bagname, num);
                }
                

            }

        }
        public string Clean(string r)
        {
            r = r.Replace(" bags contain no other", ":");
            r = r.Replace(" bags contain ", ":");
            r = r.Replace(" bags ", "");
            r = r.Replace(" bags, ", ";");
            r = r.Replace(" bags.", "");
            r = r.Replace(" bag, ", ";");
            r = r.Replace(" bag.", ";");
            return r;
        }
    }
}
