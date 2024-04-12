using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sword : InventoryDecorator
{
    public Sword(Hero hero) : base(hero) { }

    public override string GetDescription()
    {
        return $"{hero.GetDescription()} with Sword";
    }

    public override int GetAttack()
    {
        return hero.GetAttack() + 5;
    }

    public override int GetDefense()
    {
        return hero.GetDefense();
    }

    public override int GetHealth()
    {
        return hero.GetHealth();
    }
}