using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace J77E524P
{
    public class OpCode {
        public string Name;
        public int NumArgs;

        public OpCode(string name, int numArgs) {
            Name = name;
            NumArgs = numArgs;
        }
    }

    public static class Bytecode
    {
        public static int IADD   = 1;
        public static int ISUB   = 2;
        public static int IMUL   = 3;
        public static int ILT    = 4;
        public static int IEQ    = 5;
        public static int BR     = 6;
        public static int BRT    = 7;
        public static int BRF    = 8;
        public static int ICONST = 9;
        public static int LOAD   = 10;
        public static int GLOAD  = 11;
        public static int STORE  = 12;
        public static int GSTORE = 13;
        public static int PRINT  = 14;
        public static int POP    = 15;
        public static int CALL   = 16;
        public static int RET    = 17;
        public static int HALT   = 18;

        private static Dictionary<int, OpCode> codes = new Dictionary<int, OpCode>
        {
            {  1, new OpCode("IADD",   0) },
            {  2, new OpCode("ISUB",   0) },
            {  3, new OpCode("IMUL",   0) },
            {  4, new OpCode("ILT",    0) },
            {  5, new OpCode("IEQ",    0) },
            {  6, new OpCode("BR",     1) },
            {  7, new OpCode("BRT",    1) },
            {  8, new OpCode("BRF",    1) },
            {  9, new OpCode("ICONST", 1) },
            { 10, new OpCode("LOAD",   1) },
            { 11, new OpCode("GLOAD",  1) },
            { 12, new OpCode("STORE",  1) },
            { 13, new OpCode("GSTORE", 1) },
            { 14, new OpCode("PRINT",  0) },
            { 15, new OpCode("POP",    0) },
            { 16, new OpCode("CALL",   2) },
            { 17, new OpCode("RET",    0) },
            { 18, new OpCode("HALT",   0) },
        };

        public static OpCode GetCode(int code) 
        {
            return codes[code];
        }
    }
}
