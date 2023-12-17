using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern;

/// <summary>
/// 备忘录，保存备份的状态
/// </summary>
public class Memento
{
    public string State { get; private set; }

    public Memento(string state)
    {
        State = state;
    }
}
