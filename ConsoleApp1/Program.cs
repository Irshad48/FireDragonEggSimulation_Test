using System;

public interface IReptile
{
    ReptileEgg Lay(); // Interface method for laying an egg
}

public class FireDragon : IReptile
{
    public ReptileEgg Lay()
    {
        // Pass a factory function to create a FireDragon to the ReptileEgg constructor
        return new ReptileEgg(() => new FireDragon());
    }
}

public class ReptileEgg
{
    private Func<IReptile> _createReptile; // Factory function to create a reptile
    private bool _hatched; // Keeps track of whether the egg has hatched

    public ReptileEgg(Func<IReptile> createReptile)
    {
        _createReptile = createReptile ?? throw new ArgumentNullException(nameof(createReptile));
        _hatched = false; // Initially, the egg is not hatched
    }

    public IReptile Hatch()
    {
        if (_hatched)
        {
            throw new InvalidOperationException("Egg has already hatched.");
        }

        _hatched = true; // Mark the egg as hatched
        return _createReptile(); // Create and return the reptile
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var fireDragon = new FireDragon();
        var egg = fireDragon.Lay();
        var childFireDragon = egg.Hatch();

        Console.WriteLine("A new FireDragon has hatched!");        
    }
}
