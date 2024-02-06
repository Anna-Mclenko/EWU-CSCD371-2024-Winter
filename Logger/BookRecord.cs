﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class BookRecord(string Name) : IEntity
{
    // we implemented implicitly:
    // because each BookRecord object needs to have the id accessable in order to use the Get() function.
    public Guid Id { get; init; } = Guid.NewGuid();
    // we implemented explicity:
    // because the Book record and the IEntity both have a duplicated naming convention for the Property Name.
    string IEntity.Name { get; } = Name;

}
