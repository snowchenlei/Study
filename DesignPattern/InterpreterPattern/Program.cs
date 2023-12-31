// See https://aka.ms/new-console-template for more information
using InterpreterPattern;

Console.WriteLine("Hello, World!");

Context context = new Context();
IList<AbstractExpression> expressions = new List<AbstractExpression>();
expressions.Add(new TerminalExpression());
expressions.Add(new NonterminalExpression());
expressions.Add(new TerminalExpression());
expressions.Add(new TerminalExpression());

foreach (var expression in expressions)
{
    expression.Interpret(context);
}

Console.ReadKey();