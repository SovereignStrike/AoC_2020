using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    public class Instruction
    {
        public string verb;
        public int increment;
        public Instruction(string raw)
        {
            Raw = raw;
            string[] parts = raw.Split(" ");
            verb = parts[0];
            increment = Int32.Parse(parts[1]);
        }

        public string Raw { get; }

        public Instruction flip()
        {
            switch (verb)
            { 
                case "nop":
                    verb = "jmp";
                    return this;
                case "jmp":
                    verb = "nop";
                    return this;
                default:
                    return this;
            }
        }

        internal (int , int) Execute((int current_line, int accumulator) state)
        {
            switch (verb)
                {
                case "nop":
                    ++state.current_line;
                    return state;
                case "jmp":
                    state.current_line = state.current_line + increment;
                    return state;
                case "acc":
                    state.accumulator = state.accumulator + increment;
                    ++state.current_line;
                    return state;
                default:
                    return state;

            }

        }
    }
}
