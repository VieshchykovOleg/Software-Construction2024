using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Paladin : Hero
{
    public override string GetDescription()
    {
        return "Paladin";
    }

    public override int GetAttack()
    {
        return 9;
    }

    public override int GetDefense()
    {
        return 7;
    }

    public override int GetHealth()
    {
        return 90;
    }
}
