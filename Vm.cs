using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace J77E524P
{
    public class Vm
    {
        private const int DEFAULT_STACK_SIZE = 1000;
        private const int FALSE              = 0;
        private const int TRUE               = 1;

        private int[] code;
        private int[] data;
        private int[] stack;

        private bool trace = false;

        private int sp; // stack pointer
        private int ip; // instruction pointer
        private int fp; // frame pointer

        private int startIp = 0;

        private Dictionary<int, Action> opcodes;
        private void initOpcodes()
        {
            opcodes = new Dictionary<int, Action>()
            {
                { Bytecode.IADD    , iadd   },
                { Bytecode.ISUB    , isub   },
                { Bytecode.IMUL    , imul   },
                { Bytecode.ILT     , ilt    },
                { Bytecode.IEQ     , ieq    },
                { Bytecode.BR      , br     },
                { Bytecode.BRT     , brt    },
                { Bytecode.BRF     , brf    },
                { Bytecode.ICONST  , iconst },
                { Bytecode.LOAD    , load   },
                { Bytecode.GLOAD   , gload  },
                { Bytecode.STORE   , store  },
                { Bytecode.GSTORE  , gstore },
                { Bytecode.PRINT   , print  },
                { Bytecode.POP     , pop    },
                { Bytecode.CALL    , call   },
                { Bytecode.RET     , ret    },
                { Bytecode.HALT    , this.NotImplemented },
            };
        }

        public Vm(int[] code, int startIp, int dataSize)
        {
            initOpcodes();

            this.code = code;
            this.data = new int[dataSize];
            this.stack = new int[DEFAULT_STACK_SIZE];

            this.startIp = startIp;
            this.sp = -1;
        }

        public void Exec(bool trace = false)
        {
            this.trace = trace;
            ip = this.startIp;
            this.cpu();
        }

        private void cpu()
        {
            int opcode = this.code[ip];
            while(opcode != Bytecode.HALT && ip < code.Length)
            {
                if (trace)
                { 
                    Console.Error.Write(traceInstr());
                    Console.Error.Write(traceStack());
                }

                ip++;
                opcodes[opcode]();
                opcode = code[ip];
            }
        }

        private void iadd()
        {
            int a, b = 0;

            b = stack[sp--];
            a = stack[sp--];

            stack[++sp] = a + b;
        }

        private void isub()
        {
            int a, b = 0;

            b = stack[sp--];
            a = stack[sp--];

            stack[++sp] = a - b;
        }

        private void imul()
        {
            int a, b = 0;

            b = stack[sp--];
            a = stack[sp--];

            stack[++sp] = a * b;
        }

        private void ilt()
        {
            int a, b = 0;

            b = stack[sp--];
            a = stack[sp--];

            stack[++sp] = a < b ? TRUE : FALSE;
        }

        private void ieq()
        {
            int a, b = 0;

            b = stack[sp--];
            a = stack[sp--];

            stack[++sp] = a == b ? TRUE : FALSE;
        }

        private void br()
        {
            int addr = code[ip];
            ip = addr;
        }

        private void brt()
        {
            int addr = code[ip];

            int result = stack[sp--];
            if (result == TRUE)
            {
                ip = addr; 
            }
            else
            {
                // continue onto the next instruction since there is no branch
                ip++;
            }
        }

        private void brf()
        {
            int addr = code[ip];

            int result = stack[sp--];
            if (result == FALSE)
            {
                ip = addr; 
            }
            else
            {
                // continue onto the next instruction since there is no branch
                ip++;
            }
        }

        private void gload()
        {
            int addr = code[ip++];
            int val = data[addr];

            stack[++sp] = val;
        }

        private void gstore()
        {
            int addr = code[ip++];
            int val = stack[sp--];

            data[addr] = val;
        }

        private void load()
        {
            int offset = code[ip++];
            int val = stack[fp + offset]; // fp + 1 and up are locals, fp - 3 and downward are args
            stack[++sp] = val;
        }

        private void store()
        {
            int offset = code[ip++];
            int val = stack[sp--];
            stack[fp + offset] = val;
        }

        private void call() 
        {
            int addr = code[ip++];
            int numArgs = code[ip++];

            stack[++sp] = numArgs;
            stack[++sp] = fp;
            stack[++sp] = ip;

            fp = sp;
            ip = addr; // jump to function
        }

        private void ret()
        {
            int rvalue = stack[sp--];
            sp = fp;
            ip = stack[sp--];
            fp = stack[sp--];

            int numArgs = stack[sp--];
            sp -= numArgs;

            stack[++sp] = rvalue;
        }

        private void pop()
        {
            --sp;
        }

        private void iconst()
        {
            // grab code value and increment ip after
            int val = code[ip++];
            stack[++sp] = val;
        }

        private void print()
        {
            int val = stack[sp--];
            Console.WriteLine(val);
        }

        private void NotImplemented()
        {
            // IP always points to the next instruction when function is called, so IP - 1 is the current opcode
            // Next instruction is usually the arguments to the opcode.
            Console.WriteLine($"{ip - 1} Not Implemented");
        }

        private string traceInstr() 
        {
            int opCode = code[ip];
            OpCode oc = Bytecode.GetCode(opCode);

            StringBuilder sb = new StringBuilder();

            sb.Append($"{ip:D4}: {oc.Name, -7}");

            StringBuilder args = new StringBuilder();
            if (oc.NumArgs > 0)
            {
                for (int i = ip + 1; i <= ip + oc.NumArgs; i++)
                {
                    args.Append(code[i]);
                    args.Append(" ");
                }
            }
            sb.Append($"{args.ToString(), -20}");
            return sb.ToString();
        }

        private string traceStack() 
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("stack = [");
            for (int i = 0; i <= sp; i++) 
            {
                int val = stack[i];
                sb.Append(" ");
                sb.Append(val);
            }
            sb.Append(" ]");
            sb.AppendLine();

            return sb.ToString();
        }

        public void dumpCode()
        {
            Console.Error.WriteLine();
            Console.Error.WriteLine("Code:");
            for (int i = 0; i < code.Length; i++)
            {
                Console.Error.WriteLine($"{i:D4}: {code[i]}");
            }
        }

        public void dumpData()
        {
            Console.Error.WriteLine();
            Console.Error.WriteLine("Data:");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Error.WriteLine($"{i:D4}: {data[i]}");
            }
        }
    }
}
