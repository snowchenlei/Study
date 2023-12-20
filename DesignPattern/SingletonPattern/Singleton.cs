using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

public sealed class HungrySingleton
{
    private static readonly HungrySingleton _instance = new HungrySingleton();
    private HungrySingleton()
    {

    }

    public static HungrySingleton GetInstance()
    {
        return _instance;
    }
}

public sealed class LazySingleton
{
    private static LazySingleton? _instance;
    private static readonly object syncRoot = new object();
    private LazySingleton()
    {

    }

    public static LazySingleton GetInstance()
    {
        lock (syncRoot)
        {
            if (_instance is null)
            {
                _instance = new LazySingleton();
            }
        }
        return _instance;
    }
}

public sealed class DoubleCheckSingleton
{
    private static DoubleCheckSingleton? _instance;
    private static readonly object syncRoot = new object();
    private DoubleCheckSingleton()
    {

    }

    public static DoubleCheckSingleton GetInstance()
    {
        if (_instance is null)
        {
            lock (syncRoot)
            {
                if (_instance is null)
                {
                    _instance = new DoubleCheckSingleton();
                }
            }
        }
        return _instance;
    }
}

public sealed class InnerClassSingleton
{
    private InnerClassSingleton()
    {

    }

    private static class SingletonHolder
    {
        public static readonly InnerClassSingleton _instance = new InnerClassSingleton();
    }

    public static InnerClassSingleton GetInstance()
    {
        return SingletonHolder._instance;
    }
}
