using System;
using System.Collections.Generic;
using System.Text;
using ChristmasUtils;

namespace Day8
{
    public class Boot
    {
        Dictionary<int, Instruction> instructions;
        Dictionary<int, int> visited_instructions;
        public (int current_line, int accumulator) state;

        public void Run()
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
                    state = instructions.GetValueOrDefault(state.current_line).Execute(state);
                }
                    
            }
        }

        public Boot(string path)
        {
            instructions = new Dictionary<int, Instruction>();
            visited_instructions = new Dictionary<int, int>();
            List<string> raw_instructions = FileUtils.Read(path);
            int line_number = 0;
            foreach (string raw in raw_instructions)
            {
                instructions.Add(line_number, new Instruction(raw));
                ++line_number;
            }

            
        }

    }
}
