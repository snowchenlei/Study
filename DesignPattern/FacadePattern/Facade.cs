using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern;

public class Facade
{
    private readonly SubSystemOne _one;
    private readonly SubSystemTwo _two;
    private readonly SubSystemThree _three;

    public Facade()
    {
        _one = new SubSystemOne();
        _two = new SubSystemTwo();
        _three = new SubSystemThree();
    }
    public void DoA()
    {
        Console.WriteLine("方法A————————");
        _one.Do();
        _two.Do();
    }

    public void DoB()
    {
        Console.WriteLine("方法B————————");
        _two.Do();
        _three.Do();
    }
}
