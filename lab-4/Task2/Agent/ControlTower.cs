using System;
using System.Collections.Generic;

class ControlTower
{
    private List<Runway> _runways;
    private List<Aircraft> _aircrafts;

    public ControlTower(List<Runway> runways, List<Aircraft> aircrafts)
    {
        this._runways = runways;
        this._aircrafts = aircrafts;
    }

    public void LandAircraft(Aircraft aircraft)
    {
        foreach (Runway runway in this._runways)
        {
            if (runway.IsBusyWithAircraft == null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                Console.WriteLine($"Checking runway.");
                Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                runway.IsBusyWithAircraft = aircraft;
                runway.HighLightRed();
                aircraft.CurrentRunway = runway;
                return;
            }
        }
        Console.WriteLine($"Could not land, all runways are busy.");
    }

    public void TakeOffAircraft(Aircraft aircraft)
    {
        if (aircraft.CurrentRunway != null)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
            aircraft.CurrentRunway.IsBusyWithAircraft = null;
            aircraft.CurrentRunway.HighLightGreen();
            aircraft.CurrentRunway = null;
            Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
        }
        else
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
        }
    }
}
