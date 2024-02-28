
var appliances = new Appliances[]
{
    new TeleVision(),
    new TeleVision(),
    new TeleVision(),
    new TeleVision(),
    new Lamp(),
    new Lamp(),
    new Lamp(),
    new Lamp(),
    new Lamp(),
};


foreach (Appliances app in appliances)
{
    app.TurnOn();
}

    appliances[0].ChannelUp();
    appliances[2].ChannelUp();
    appliances[3].ChannelUp();
    appliances[3].ChannelUp();
    appliances[3].ChannelUp();
    appliances[1].ChannelDown();

foreach (Appliances app in appliances)
{
    System.Console.WriteLine(app);
}

foreach (Appliances app in appliances)
{
    app.TurnOff();
}
class Appliances : IRemoteControl
{
    public static int id = 1;
    public string? status { get; set; }
    public virtual void TurnOn() { }
    public virtual void TurnOff() { }
    public virtual void ChannelUp() { }
    public virtual void ChannelDown() { }
}

class TeleVision : Appliances
{
    public int channel { get; set; }
    public static int globalID = 1;
    public  int objectID = 0;
    public TeleVision()
    {
        objectID = globalID++;
        status = "off";
        channel = 1;
    }
    public override void TurnOn()
    {
        status = "on";
        System.Console.WriteLine($"Television {objectID} turned on");
    }
    public override void TurnOff()
    {
        status = "off";
        System.Console.WriteLine($"Television {objectID} turned off");
    }
    public override void ChannelUp()
    {
        if (status == "on")
            channel++;
        else
            System.Console.WriteLine("Cannot change channel");
    }
    public override void ChannelDown()
    {
        if (status == "on")
        {
            if (channel > 1)
                channel--;
        }
        else
            System.Console.WriteLine("Cannot change channel");
    }
    public override string ToString()
    {
        return $"Television: id: {objectID}, Status = {status}, CH = {channel}";
    }
}

class Lamp : Appliances
{

    public static int globalID = 1;
    public  int objectID = 0;
    public Lamp()
    {
        objectID = globalID++;
        status = "off";
    }
    public override void TurnOn()
    {
        status = "On";
        System.Console.WriteLine($"Lamp {objectID} turned on");
    }
    public override void TurnOff()
    {
        status = "Off";
        System.Console.WriteLine($"Lamp {objectID} turned off");
    }
    public override void ChannelUp()
    {
        System.Console.WriteLine($"Lamp {objectID} does not have channel");
    }
    public override void ChannelDown()
    {
        System.Console.WriteLine($"Lamp {objectID} does not have channel");
    }
    public override string ToString()
    {
        return $"Lamp: id: {objectID}, Status = {status}";
    }

}


interface IRemoteControl
{
    public void TurnOn();
    public void TurnOff();
    public void ChannelUp();
    public void ChannelDown();

}