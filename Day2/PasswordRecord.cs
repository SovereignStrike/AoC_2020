using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    public class PasswordRecord
    {
        private string pass;
        private int minrange;
        private int maxrange;
        private char criteria;


        public PasswordRecord(string pass)
        {
            string[] parts = pass.Split(" ");
            this.minrange = Int32.Parse(parts[0].Split("-")[0]);
            this.maxrange = Int32.Parse(parts[0].Split("-")[1]);
            this.criteria = char.Parse(parts[1].Trim(new Char[] {':'}));
            this.pass = parts[2];
        }

        public bool IsValid()
        {
            int i = 0;
            foreach (char car in pass)
            {
                if (car == criteria)
                {
                    i++;
                }

            }
                return (i >= minrange && i <= maxrange);
           }
    }

    public class PasswordRecordTobboggan
    {
        private char[] pass;
        private int firstposition;
        private int secondposition;
        private char criteria;


        public PasswordRecordTobboggan(string pass)
        {
            string[] parts = pass.Split(" ");
            this.firstposition = Int32.Parse(parts[0].Split("-")[0])-1;
            this.secondposition = Int32.Parse(parts[0].Split("-")[1])-1;
            this.criteria = char.Parse(parts[1].Trim(new Char[] { ':' }));
            this.pass = parts[2].ToCharArray();
        }

        public bool IsValid()
        {
              return (pass[firstposition]==criteria ^ pass[secondposition] == criteria);
        }
    }
}
