using System.Drawing; // for Color

System.Console.WriteLine("================\nA horse\n================");
var horse1 = new Horse();
horse1.Legs = 4;
horse1.color = Color.Brown;
System.Console.WriteLine(horse1);
horse1.Move();

System.Console.WriteLine("================\nAn Eagle\n================");
var eagle = new Eagle();
eagle.Legs = 2;
eagle.color = Color.Brown;
System.Console.WriteLine(eagle);
eagle.Move();


class Horse
{
    public int Legs { get; set; }
    public Color color { get; set; }

    public void Move()
    {
        System.Console.WriteLine("Fast move: gallop");
        System.Console.WriteLine("Slow move: trot");
    }
    public override string ToString()
    {
        return $"I'm a horse with {Legs} legs and color {color.Name}";
    }
}

class Eagle
{
    public int Legs { get; set; }
    public Color color { get; set; }

    public void Move()
    {
        System.Console.WriteLine("Fast move: fly");
        System.Console.WriteLine("Slow move: jump");
    }
    public override string ToString()
    {
        return $"I'm an eagle with {Legs} legs and color {color.Name}";
    }
}

class Unicon : Horse, Eagle
{

    
}