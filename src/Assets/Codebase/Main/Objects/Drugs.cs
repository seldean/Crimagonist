using System.Collections.Generic;

#region Rules
public static class DrugRules
{
    public const uint MIN_PRICE_METH = 1000;
    public const uint MAX_PRICE_METH = 10000;
    public const uint MIN_PRICE_METH_SUPPLY = 500;
    public const uint MAX_PRICE_METH_SUPPLY = 20000;
    public const uint MIN_PRICE_COCAIN = 5000;
    public const uint MAX_PRICE_COCAIN = 50000;
    public const uint MIN_PRICE_COCAIN_SUPPLY = 2500;
    public const uint MAX_PRICE_COCAIN_SUPPLY = 100000;
    public const uint MIN_PRICE_COCAIN_SEED = 650;
    public const uint MAX_PRICE_COCAIN_SEED = 25000;
    public const uint MIN_PRICE_WEED = 500;
    public const uint MAX_PRICE_WEED = 5000;
    public const uint MIN_PRICE_WEED_SUPPLY = 250;
    public const uint MAX_PRICE_WEED_SUPPLY = 10000;
    public const uint MIN_PRICE_WEED_SEED = 60;
    public const uint MAX_PRICE_WEED_SEED = 2500;
    public const uint MIN_PRICE_MDMA = 750;
    public const uint MAX_PRICE_MDMA = 7500;
    public const uint MIN_PRICE_MDMA_SUPPLY = 375;
    public const uint MAX_PRICE_MDMA_SUPPLY = 15000;
}
#endregion

#region Declerations
public class Drug
{
    public Dictionary<City, uint> PricesByCountries { get; set; }
    public float Volume { get; set; }

    public Drug()
    {
        PricesByCountries = new Dictionary<City, uint>();
        Volume = 0f;
    }
}
public class DrugSupply
{
    public Dictionary<City, uint> PriceByCountries { get; set; }
    public float Volume { get; set; }

    public DrugSupply()
    {
        PriceByCountries = new Dictionary<City, uint>();
        Volume = 0f;
    }
}
public class DrugSeed
{
    public Dictionary<City, uint> PriceByCountries { get; set; }
    public float Volume { get; set; }

    public DrugSeed()
    {
        PriceByCountries = new Dictionary<City, uint>();
        Volume = 0f;
    }
}

public class Methamphetamine : Drug
{
    public Methamphetamine(float volume)
    {
        Volume = volume;
    }
}
public class MethamphetamineSupply : DrugSupply
{
    public MethamphetamineSupply(float volume)
    {
        Volume = volume;
    }
}
public class Cocain : Drug
{
    public Cocain(float volume)
    {
        Volume = volume;
    }
}
public class CocainSupply : DrugSupply
{
    public CocainSupply(float volume)
    {
        Volume = volume;
    }
}
public class CocainSeed : DrugSeed
{
    public CocainSeed(float volume)
    {
        Volume = volume;
    }
}
public class Weed : Drug
{
    public Weed(float volume)
    {
        Volume = volume;
    }
}
public class WeedSupply : DrugSupply
{
    public WeedSupply(float volume)
    {
        Volume = volume;
    }
}
public class WeedSeed : DrugSeed
{
    public WeedSeed(float volume)
    {
        Volume = volume;
    }
}
public class MDMA : Drug 
{
    public MDMA(float volume)
    {
        Volume = volume;
    }
}
public class MDMASupply : DrugSupply
{
    public MDMASupply(float volume)
    {
        Volume = volume;
    }
}
#endregion
