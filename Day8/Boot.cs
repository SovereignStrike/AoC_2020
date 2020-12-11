using System;
using System.Collections.Generic;
using System.Text;
using ChristmasUtils;

namespace Day8
{
    public class Boot
    {
        public Dictionary<int, Instruction> instructions;
        Dictionary<int, int> visited_instructions;
        public (int current_line, int accumulator) state;
        public List<string> raw_instructions;
        public bool Run()
        {
            state = (0, 0);
            bool not_looping = true;
            
            while (not_looping)
            {
                if (!visited_instructions.TryAdd(state.current_line, 1))
                {
                    not_looping = false;                    
                }
                else
                {
                    Instruction inst;
                    if (instructions.TryGetValue(state.current_line, out inst))
                    {
                        state = inst.Execute(state);
                    }
                    else
                    {
                        //must be over
                        return true;
                    }
                }
            }
            return not_looping;
        }

        public Boot(string path)
        {
            instructions = new Dictionary<int, Instruction>();
            visited_instructions = new Dictionary<int, int>();
            raw_instructions = FileUtils.Read(path);
            instructions = CreateInstructions(raw_instructions);

        }

        private Dictionary<int, Instruction> CreateInstructions(List<string> raw_instructions)
        {
            Dictionary<int, Instruction> temp_instructions = new Dictionary<int, Instruction>();
            int line_number = 0;
            foreach (string raw in raw_instructions)
            {
                temp_instructions.Add(line_number, new Instruction(raw));
                ++line_number;
            }

            return temp_instructions;
        }

        public Boot(Dictionary<int, Instruction> try_instructions_mod)
        {
            this.instructions = try_instructions_mod;
            visited_instructions = new Dictionary<int, int>();
        }

        public Boot(List<string> raw_instructions)
        {
            this.instructions = CreateInstructions(raw_instructions);
            visited_instructions = new Dictionary<int, int>();
        }
    }
}
