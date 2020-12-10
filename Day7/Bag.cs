using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    
    
    public class Bag
    {
        public string color;
        public Dictionary<string,int> inner_bags = new Dictionary<string, int>();
        public int goldbags = 0;
        public Bag(Rule rul)
        {
            this.color = rul.basecolor;
            foreach (KeyValuePair<string, int> b in rul.inner_bags)
            {
                inner_bags.Add(b.Key.Trim(),b.Value);
            }

            
        }

        public int HowManyBagsCanIHold(List<Bag> all_bags)
        {
            int i = 0;



            foreach (KeyValuePair<string,int> bag in inner_bags)
            {
                int j;
                i = i + bag.Value;
                j = all_bags.Find(x => x.color == bag.Key).HowManyBagsCanIHold(all_bags);
                i = i + bag.Value * j;
                
            }

            return i;
        }


        public bool CanIHoldAGoldenBag(List<Bag> all_bags)
        {
            foreach (KeyValuePair<string, int> bag in inner_bags)
            {
                if (bag.Key == "shiny gold")
                {
                    return true;
                }
                else
                {
                    if (all_bags.Find(x => x.color == bag.Key).CanIHoldAGoldenBag(all_bags))

                    {
                        return true;
                    }

                }
            }
            return false;
        }
        //public int Count(List<Bag> bags)
        //{
        //    int i = 0;
        //    foreach (Bag bag in bags)
        //    {

        //    }


        //    i++;
        //    return i;
        //}
    }
}
