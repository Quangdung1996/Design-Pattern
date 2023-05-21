namespace Builder;

public abstract record VehicleBuilder(Vehicle Vehicle)
{
    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
}