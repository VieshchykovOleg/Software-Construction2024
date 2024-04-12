using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Warrior : Hero
{
    public override string GetDescription()
    {
        return "Warrior";
    }

    public override int GetAttack()
    {
        return 10;
    }

    public override int GetDefense()
    {
        return 5;
    }

    public override int GetHealth()
    {
        return 100;
    }
}
