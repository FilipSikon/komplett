using System;

public class Fireball
{
    protected string sound;

    public Fireball(string sound)
    {
        this.sound = sound;
    }

    public virtual void Cast()
    {
        // Skriv ut en beskrivning av eldbollens kastning med ljudet
        Console.WriteLine("Kastar en eldboll... Ljudet: " + sound);
    }
}

public class FastFireball : Fireball
{
    private double speed;

    public FastFireball(string sound, double speed) : base(sound)
    {
        this.speed = speed;
    }

    public override void Cast()
    {
        base.Cast();
        // Skriv ut en beskrivning av snabb eldbolls kastning med hastigheten
        Console.WriteLine("Kastar en snabb eldboll! Hastighet: " + speed);
    }
}

public class PowerfulFireball : Fireball
{
    private double power;

    public PowerfulFireball(string sound, double power) : base(sound)
    {
        this.power = power;
    }

    public override void Cast()
    {
        base.Cast();
        // Skriv ut en beskrivning av kraftfull eldbolls kastning med styrkan
        Console.WriteLine("Kastar en kraftfull eldboll! Styrka: " + power);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Skapar en eldboll med ljudet "Whoosh" och kastar den
        Fireball fireball = new Fireball("Whoosh");
        fireball.Cast();

        Console.WriteLine();

        // Skapar en snabb eldboll med ljudet "Swoosh" och hastigheten 10.0, och kastar den
        FastFireball fastFireball = new FastFireball("Swoosh", 10.0);
        fastFireball.Cast();

        Console.WriteLine();

        // Skapar en kraftfull eldboll med ljudet "Boom" och styrkan 100.0, och kastar den
        PowerfulFireball powerfulFireball = new PowerfulFireball("Boom", 100.0);
        powerfulFireball.Cast();

        Console.ReadLine();
    }
}
