// 213034 Muneeb Shahid

using System;

// Part a: Create a base class, Telephone, and derive a class ElectronicPhone from it.
class Telephone
{
    protected string phonetype;

    public Telephone()
    {
        phonetype = "Unknown";
    }

    public void Ring()
    {
        Console.WriteLine("Ringing the " + phonetype + ".");
    }
}

class ElectronicPhone : Telephone
{
    public ElectronicPhone()
    {
        phonetype = "Digital";
    }

    public void Run()
    {
        Ring();
    }
}

// Part b: Extend the above exercise to illustrate a polymorphic method.

class Program
{
    static void Main()
    {
        ElectronicPhone electronicPhone = new ElectronicPhone();
        electronicPhone.Run();
    }
}

// Part c: Change the Telephone class to abstract, and make Ring an abstract method.


abstract class TelephoneC
{
    protected string phonetype;

    public TelephoneC(string type)
    {
        phonetype = type;
    }

    public abstract void Ring();
}

class DigitalPhone : TelephoneC
{
    public DigitalPhone() : base("Digital")
    {
    }

    public override void Ring()
    {
        Console.WriteLine("Digital phone is ringing.");
    }
}

class TalkingPhone : TelephoneC
{
    public TalkingPhone() : base("Analog")
    {
    }

    public override void Ring()
    {
        Console.WriteLine("Analog phone is ringing.");
    }
}