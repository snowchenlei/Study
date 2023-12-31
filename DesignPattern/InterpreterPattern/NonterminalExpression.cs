using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern;

public class NonterminalExpression : AbstractExpression
{
    public void Interpret(Context context)
    {
        Console.WriteLine("非终端解释器");
    }
}
