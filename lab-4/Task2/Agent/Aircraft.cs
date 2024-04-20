using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aircraft
{
    public string Name;
    public Runway? CurrentRunway { get; set; }
    public bool IsTakingOff { get; set; }

    public Aircraft(string name)
    {
        this.Name = name;
    }

    public void Land(ControlTower controlTower)
    {
        controlTower.LandAircraft(this);
    }

    public void TakeOff(ControlTower controlTower)
    {
        controlTower.TakeOffAircraft(this);
    }
}
