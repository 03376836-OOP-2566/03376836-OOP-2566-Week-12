
var tv1 = new TeleVision();
System.Console.WriteLine(tv1);
tv1.ChannelUp();
System.Console.WriteLine(tv1);
tv1.TurnOn();
tv1.ChannelUp();
System.Console.WriteLine(tv1);


var l1 = new Lamp();
System.Console.WriteLine(l1);
l1.ChannelUp();
System.Console.WriteLine(l1);
l1.TurnOn();
l1.ChannelUp();
System.Console.WriteLine(l1);


class Appliances
{
    public string? status { get; set; }
}

class TeleVision : Appliances, IRemoteControl
{
    public int channel { get; set; }

    public TeleVision()
    {
        status = "off";
        channel = 1;
    }
    public void TurnOn()
    {
        status = "on";
        System.Console.WriteLine("Television turned on");
    }
    public void TurnOff()
    {
        status = "off";
        System.Console.WriteLine("Television turned off");
    }
    public void ChannelUp()
    {
        if (status == "on")
            channel++;
        else
            System.Console.WriteLine("Cannot change channel");
    }
    public void ChannelDown()
    {
        if (status == "on")
        {
            if (channel > 0)
                channel--;
        }
        else
            System.Console.WriteLine("Cannot change channel");
    }
    public override string ToString()
    {
        return $"Television: Status = {status}, CH = {channel}";
    }
}

class Lamp : Appliances, IRemoteControl
{
    public Lamp()
    {
        status = "off";
    }
    public void TurnOn()
    {
        status = "On";
        System.Console.WriteLine("Lamp turned on");
    }
    public void TurnOff()
    {
        status = "Off";
        System.Console.WriteLine("Lamp turned off");
    }
    public void ChannelUp()
    {
        System.Console.WriteLine("Lamp does not have channel");
    }
    public void ChannelDown()
    {
        System.Console.WriteLine("Lamp does not have channel");
    }
    public override string ToString()
    {
        return $"Lamp: Status = {status}";
    }

}


interface IRemoteControl
{
    public void TurnOn();
    public void TurnOff();
    public void ChannelUp();
    public void ChannelDown();

}