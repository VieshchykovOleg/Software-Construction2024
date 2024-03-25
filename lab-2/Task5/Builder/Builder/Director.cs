using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Director
{
    public void Construct(ICharacterBuilder builder)
    {
        builder.SetHeight(180)
        .SetBuild("Атлетичний")
        .SetHairColor("Коричневий")
        .SetEyeColor("Синій")
        .SetClothing("Броня")
        .SetInventory("Меч, Щит");
    }
}
