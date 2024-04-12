using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Armor : InventoryDecorator
{
    public Armor(Hero hero) : base(hero) { }

    public override string GetDescription()
    {
        return $"{hero.GetDescription()} with Armor";
    }

    public override int GetAttack()
    {
        return hero.GetAttack();
    }

    public override int GetDefense()
    {
        return hero.GetDefense() + 5;
    }

    public override int GetHealth()
    {
        return hero.GetHealth();
    }
}