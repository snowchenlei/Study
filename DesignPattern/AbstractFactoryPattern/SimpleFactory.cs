using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern;

public class SimpleFactory
{
    private static readonly string _type = "A";
    public static IProductA? CreateProductA()
    {
        IProductA? result = null;
        switch (_type)
        {
            case "A":
                result = new ProductAA();
                break;
            case "B":
                result = new ProductAB();
                break;
        }
        return result;
    }

    public static IProductB? CreateProductB()
    {
        IProductB? result = null;
        switch (_type)
        {
            case "A":
                result = new ProductBA();
                break;
            case "B":
                result = new ProductBB();
                break;
        }
        return result;
    }
}
