using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public sealed class Car:Entity
    {
        public string Name { get; set; } = default!;
        public string? Model { get; set; }
    }
}
