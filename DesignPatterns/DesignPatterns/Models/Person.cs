using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models;

public class Person
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Person(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public Person()
    {
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
}
