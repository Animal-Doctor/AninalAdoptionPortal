using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Donald Duck", Age = 5, Description = "Duck that can speak human language" },
            new Animal { Id = 2, Name = "Duckie", Age = 2, Description = "Under a lot of pressure to learn human language" },
            new Animal { Id = 3, Name = "Igno Yellow Duckling", Age = 1, Description = "Shiny and glasslike. AKA just born" },
        };
    }
}
