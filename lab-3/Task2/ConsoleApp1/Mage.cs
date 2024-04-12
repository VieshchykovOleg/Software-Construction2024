using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mage : Hero
{
    public override string GetDescription()
    {
        return "Mage";
    }

    public override int GetAttack()
    {
        return 8;
    }

    public override int GetDefense()
    {
        return 3;
    }

    public override int GetHealth()
    {
        return 80;
    }
}