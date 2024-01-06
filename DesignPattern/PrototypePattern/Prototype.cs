﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern;

public abstract class Prototype
{
    public string Id { get; private set; }

    public Prototype(string id)
    {
        Id = id;
    }

    public abstract Prototype Clone();
}
