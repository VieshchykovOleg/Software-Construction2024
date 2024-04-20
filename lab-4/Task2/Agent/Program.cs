
class Program
{
    static void Main(string[] args)
    {
        List<Runway> runways = new List<Runway>();
        for (int i = 0; i <5; i++)
        {
            runways.Add(new Runway());
        }

        List<Aircraft> aircrafts = new List<Aircraft>();
        aircrafts.Add(new Aircraft("Boeing 748"));
        aircrafts.Add(new Aircraft("Airbus A320"));
        aircrafts.Add(new Aircraft("Boeing 777"));
        aircrafts.Add(new Aircraft("Embraer E190"));
        aircrafts.Add(new Aircraft("Cessna 182"));

        ControlTower controlTower = new ControlTower(runways, aircrafts);

        foreach (var aircraft in aircrafts)
        {
            aircraft.Land(controlTower);
            aircraft.TakeOff(controlTower);
        }

        Console.ReadLine();
    }
}