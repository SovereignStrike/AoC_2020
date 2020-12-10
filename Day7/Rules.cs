using System;
using System.Collections.Generic;
using System.Text;
using ChristmasUtils;
namespace Day7
{

    public class Rules
    {
        public List<Rule> rules;
        public List<string> rules_input;
        public List<Bag> bags;
        public Rules(string path)
        {
            rules = new List<Rule>();
            bags = new List<Bag>();
            rules_input = new List<string>();
            rules_input = FileUtils.Read(path);
            foreach (string r in rules_input) 
            {
                rules.Add(new Rule(r));            
            }
            CreateBags();
        }

        public void CreateBags()
        {
            foreach (Rule r in rules)
            {
                bags.Add(new Bag(r));
            }
        }

        public int CountGoldenBags()
        {
            int i = 0;
            foreach (Bag b in bags)
            {
                if (b.CanIHoldAGoldenBag(bags))
                {
                    ++i;
                }
            }
            return i; 
        }

        public int CountBagsInBag(string color)
        {
            return bags.Find(x => x.color == color).HowManyBagsCanIHold(bags);
        }
    }
}
