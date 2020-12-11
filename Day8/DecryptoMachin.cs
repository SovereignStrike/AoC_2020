using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    public class DecryptoMachin
    {
        int last_try;
        Dictionary<int, Instruction> try_instructions;
        public List<string> raw_instructions;
        public DecryptoMachin(string path)
        {
            Boot boo = new Boot(path);
             try_instructions = boo.instructions;
            


        }


        

        public DecryptoMachin(List<string> raw_instructions)
        {
            Boot boo = new Boot(raw_instructions);
            this.raw_instructions = raw_instructions;
            try_instructions = boo.instructions;



        }

        public int Decrypt()
        {
            last_try = 0;

            foreach (var ins 
                in try_instructions)
            {
               //Dictionary<int, Instruction> try_instructions_mod = new Dictionary<int, Instruction>(try_instructions);
                //try_instructions_mod[last_try] = try_instructions_mod[last_try].flip();
                Boot boo_adjusted = new Boot(raw_instructions);
                boo_adjusted.instructions[last_try] = boo_adjusted.instructions[last_try].flip();

                if (boo_adjusted.Run())
                { return boo_adjusted.state.accumulator; }
                ++last_try;
            }

            return 0;

        }


    }
}
