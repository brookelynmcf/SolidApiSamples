namespace SolidAPI.Types;

public class SailBoat : WaterVessel, IWindPowered
{
    public string GetWindPower()
    {
        return "Sail Boat";
    }

    public override void Float()
    {
        //Floating logic
    }
}