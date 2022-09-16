using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    internal class DemoPrograms
    {        
        public static readonly string SimpleWithJumps 
= @"PUSH 5
PUSH 2
DUP
INC
NOP
MUL
ADD
DUP
SUB
JZ 1
NOP
HLT";

        public static readonly string SimpleWithJumpsIP
= @"push 0
dup
inc
puship 1
dup
push 10
sub
jz 9
popip
hlt";
        public static readonly string SimpleWithJumpsIP2
= @"PUSH 0
PUSH 1
puship 2
DUP
INC
DUP
PUSH 10
SUB
JZ 10
Dropip
HLT";

        public static readonly string SimpleWithJumpsIPstore
=@"push 0
store 2
dup
inc
puship 1
dup
push 10
sub
jz 10
dropip
hlt";
    }
}
