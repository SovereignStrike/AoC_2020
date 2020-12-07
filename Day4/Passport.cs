using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Passport
    {

        private string[] fieldsraw;
        private Dictionary<string, string> fields;

        public Passport(string input) 
        {
            fields = new Dictionary<string, string>();
            fieldsraw = input.Split(" ");
            foreach (string field in fieldsraw)
            {
                string newkey = field.Split(":")[0];
                string newvalue = field.Split(":")[1];
                fields.Add(newkey, newvalue);
            }
         }

        internal bool IsValid(string[] requiredFields)
        {
            foreach (string field in requiredFields) 
            { 
                if (!fields.ContainsKey(field))
                {
                    return false;
                } 
            }
            foreach (KeyValuePair<string,string> field in fields)
            {
                if (!Validator.IsFieldValid(field))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
