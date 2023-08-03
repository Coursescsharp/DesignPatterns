﻿using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

public abstract class PersonBuilder
{
    protected Person person = new Person();

    public Person Build() { return person; }
}
