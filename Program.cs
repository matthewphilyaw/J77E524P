using System;
using System.IO;

// ANTLR parser is not CLS compliant, without this there are warnings
[assembly: CLSCompliant(false)]
namespace J77E524P
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = File.ReadAllText("programs/intro.asm");
            var assembled = AssemblerParser.assemble(program);
            var vm = new Vm(assembled, 0, 1);

            vm.Exec(true);
            vm.dumpData();
            vm.dumpCode();
        }
    }
}
