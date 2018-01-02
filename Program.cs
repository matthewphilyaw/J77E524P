using System;
using System.IO;

namespace J77E524P
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = File.ReadAllText("programs/factorial.asm");
            var assembled = Assembler.assemble(program);
            var vm = new Vm(assembled, 22, 1);

            vm.Exec(true);
            vm.dumpData();
            vm.dumpCode();
        }
    }
}
