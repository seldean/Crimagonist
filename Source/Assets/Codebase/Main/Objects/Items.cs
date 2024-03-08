using System.Collections.Generic;
using UnityEngine;
using OutputController;

#region Rules
public static class ItemCapacities
{
    //Durability
    public const byte DURABILITY_CAP = 100;
    //Stats
    public const byte STAT_CAP = 125;
}
public static class ItemCreationSettings
{
    //Serial Number Settings
    public const string SERIAL_NUMBER_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    public const byte SERIAL_NUMBER_LENGTH = 8;
    //Durability Settings
    public const byte DURABILIY_MIN = 50;
    public const byte DURABILITY_MAX = 100;
    //Chance to not belong to Market
    public const byte CHANCE_TO_BELONG_NPC = 5;
    //Stats
    public const byte STAT_DRIFT_VALUE = 5;
    //Amount of each Item
    public const uint AMOUT_OF_EACH_ITEM = 1000;
}
public static class JewelrySettings
{
    public const uint MIN_BLACKMARKET_PRICE = 7500;
    public const uint MAX_BLACKMARKET_PRICE = 45000;

    public const byte DEFAULT_BLACKMARKET_INTEREST = 100;
}
public static class EnvelopeSettings
{
    public const uint DEFAULT_ENVELOPE_BLACKMARKET_PRICE = 250000;
}
public static class ArtSettings
{
    public const uint MIN_BLACKMARKET_PRICE = 2000;
    public const uint MAX_BLACKMARKET_PRICE = 150000;

    public const byte DEFAULT_BLACKMARKET_INTEREST = 10;
}
public static class SportCarSettings
{
    public const uint MIN_BLACKMARKET_PRICE = 1500;
    public const uint MAX_BLACKMARKET_PRICE = 750000;

    public const byte DEFAULT_BLACKMARKET_INTEREST = 5;
}
#endregion

#region Items
public class Item
{
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public byte Durability { get; set; }
    public byte PoliceInterest { get; set; }
    public float Volume { get; set; }
    public uint Price { get; set; }
    public bool IsCaptured { get; set; }
    public bool IsMissing { get; set; }
    public Player OwnerPlayer { get; set; }
    public NPC OwnerNPC { get; set; }

    public Item()
    {
        Name = "";
        SerialNumber = "";
        Durability = 100;
        PoliceInterest = 0;
        Volume = 1f;
        Price = 0;
        IsCaptured = false;
        IsMissing = false;
        OwnerPlayer = null;
        OwnerNPC = null;
    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }
    public void ChangeDurability(sbyte amount)
    {
        Durability = Convert.ToByte(Durability + amount);
    }
    public void ChangePoliceInterest(sbyte amount)
    {
        PoliceInterest = Convert.ToByte(PoliceInterest + amount);
    }
    public void ChangePrice(int amount)
    {
        Price = Convert.ToUInt(Price + amount);
    }
    public void SetIsCaptured(bool isCaptured)
    {
        IsCaptured = isCaptured;
    }
    public void SetIsMissing(bool isMissing)
    {
        IsMissing = isMissing;
    }
    public void ChangeOwnerPlayer(Player newOwner = null)
    {
        OwnerPlayer = newOwner;
        OwnerNPC = null;
    }
    public void ChangeOwnerNPC(NPC newOwner = null)
    {
        OwnerNPC = newOwner;
        OwnerPlayer = null;
    }
    public void ChangeOwnerAsMarket()
    {
        OwnerPlayer = null;
        OwnerNPC = null;
    }
}

public class Weapon : Item
{
    public byte PowerLevel { get; set; }
    public byte DamageLevel { get; set; }
    public byte IntimidationLevel { get; set; }
    public bool IsRanged { get; set; }
    public bool IsSupressed { get; set; }
    public bool IsOffRecord { get; set; }

    public Weapon()
    {
        PowerLevel = 0;
        DamageLevel = 0;
        IntimidationLevel = 0;
        IsRanged = false;
        IsSupressed = false;
        IsOffRecord = false;
    }

    public void ChangePowerLevel(sbyte amount)
    {
        PowerLevel = Convert.ToByte(PowerLevel + amount);
    }
    public void ChangeDamageLevel(sbyte amount)
    {
        DamageLevel = Convert.ToByte(DamageLevel + amount);
    }
    public void ChangeIntimidationLevel(sbyte amount)
    {
        IntimidationLevel = Convert.ToByte(IntimidationLevel + amount);
    }
    public void SetIsRanged(bool isRanged)
    {
        IsRanged = isRanged;
    }
    public void SetIsSupressed(bool isSupressed)
    {
        if (IsRanged)
        {
            IsSupressed = isSupressed;
        }
        else
        {
            IsSupressed = false;
        }
    }
    public void SetIsOffRecord(bool isOffRecord)
    {
        if (IsRanged)
        {
            IsOffRecord = isOffRecord;
        }
        else
        {
            IsOffRecord = true;
        }
    }
}
public class Gear : Item
{
    public byte IntelligenceLevel { get; set; }
    public byte StealthLevel { get; set; }
    public byte HandinessLevel { get; set; }
    public byte TechLevel { get; set; }
    public byte TransporterLevel { get; set; }
    public byte ConnectionLevel { get; set; }
    public byte FarmerLevel { get; set; }
    public byte LabLevel { get; set; }
    public bool IsElectronic { get; set; }

    public Gear()
    {
        IntelligenceLevel = 0;
        StealthLevel = 0;
        HandinessLevel = 0;
        TechLevel = 0;
        TransporterLevel = 0;
        ConnectionLevel = 0;
        FarmerLevel = 0;
        LabLevel = 0;
        IsElectronic = false;
    }

    public void ChangeIntelligenceLevel(sbyte amount)
    {
        IntelligenceLevel = Convert.ToByte(IntelligenceLevel + amount);
    }
    public void ChangeStealthLevel(sbyte amount)
    {
        StealthLevel = Convert.ToByte(StealthLevel + amount);
    }
    public void ChangeHandinessLevel(sbyte amount)
    {
        HandinessLevel = Convert.ToByte(HandinessLevel + amount);
    }
    public void ChangeTechLevel(sbyte amount)
    {
        TechLevel = Convert.ToByte(TechLevel + amount);
    }
    public void ChangeTransportLevel(sbyte amount)
    {
        TransporterLevel = Convert.ToByte(TransporterLevel + amount);
    }
    public void ChangeConnectinLevel(sbyte amount)
    {
        ConnectionLevel = Convert.ToByte(ConnectionLevel + amount);
    }
    public void ChangeFarmerLevel(sbyte amount)
    {
        FarmerLevel = Convert.ToByte(FarmerLevel + amount);
    }
    public void ChangeLabLevel(sbyte amount)
    {
        LabLevel = Convert.ToByte(LabLevel + amount);
    }
    public void ChangeIsElectronic(bool isElectronic)
    {
        IsElectronic = isElectronic;
    }
}
public class Explosive : Item
{
    public ushort ExplosivePower { get; set; }

    public Explosive()
    {
        ExplosivePower = 0;
    }

    public void ChangeExplosivePower(short amount)
    {
        ExplosivePower = Convert.ToUShort(ExplosivePower + amount);
    }
}
public class Clothing : Item
{
    public byte ArmorLevel { get; set; }
    public byte IntimidationLevel { get; set; }
    public byte BusinessLevel { get; set; }
    public byte CharmLevel { get; set; }
    public byte StealthLevel { get; set; }
    public byte HandinessLevel { get; set; }
    public byte TechLevel { get; set; }
    public byte FarmerLevel { get; set; }
    public byte LabLevel { get; set; }
    public byte MoneyLaunderingLevel { get; set; }
    public byte LawyeringLevel { get; set; }
    //Clothing Mechanism
    public bool IsOnHead { get; set; }
    public bool IsAGlasses { get; set; }
    public bool IsOnBody { get; set; }
    public bool IsOnTopBody { get; set; }
    public bool IsOnLegs { get; set; }
    public bool IsOnFeet { get; set; }

    public Clothing()
    {
        ArmorLevel = 0;
        IntimidationLevel = 0;
        BusinessLevel = 0;
        CharmLevel = 0;
        StealthLevel = 0;
        HandinessLevel = 0;
        TechLevel = 0;
        FarmerLevel = 0;
        LabLevel = 0;
        MoneyLaunderingLevel = 0;
        LawyeringLevel = 0;
        IsOnHead = false;
        IsAGlasses = false;
        IsOnBody = false;
        IsOnTopBody = false;
        IsOnLegs = false;
        IsOnFeet = false;
    }

    public void ChangeArmorLevel(sbyte amount)
    {
        ArmorLevel = Convert.ToByte(ArmorLevel + amount);
    }
    public void ChangeIntimidationLevel(sbyte amount)
    {
        IntimidationLevel = Convert.ToByte(IntimidationLevel + amount);
    }
    public void ChangeBusinessLevel(sbyte amount)
    {
        BusinessLevel = Convert.ToByte(BusinessLevel + amount);
    }
    public void ChangeCharmLevel(sbyte amount)
    {
        CharmLevel = Convert.ToByte(CharmLevel + amount);
    }
    public void ChangeStealthLevel(sbyte amount)
    {
        StealthLevel = Convert.ToByte(StealthLevel + amount);
    }
    public void ChangeHandinessLevel(sbyte amount)
    {
        HandinessLevel = Convert.ToByte(HandinessLevel + amount);
    }
    public void ChangeTechLevel(sbyte amount)
    {
        TechLevel = Convert.ToByte(TechLevel + amount);
    }
    public void ChangeFarmerLevel(sbyte amount)
    {
        FarmerLevel = Convert.ToByte(FarmerLevel + amount);
    }
    public void ChangeLabLevel(sbyte amount)
    {
        LabLevel = Convert.ToByte(LabLevel + amount);
    }
    public void ChangeMoneyLaunderingLevel(sbyte amount)
    {
        MoneyLaunderingLevel = Convert.ToByte(MoneyLaunderingLevel + amount);
    }
    public void ChangeLawyeringLevel(sbyte amount)
    {
        LawyeringLevel = Convert.ToByte(LawyeringLevel + amount);
    }

    private void ChangeClothingLayer(bool isOnHead = false, bool isAGlasses = false, bool isOnBody = false, bool isOnTopBody = false, bool isOnLegs = false, bool isOnFeet = false)
    {
        IsOnHead = isOnHead;
        IsAGlasses = isAGlasses;
        IsOnBody = isOnBody;
        IsOnTopBody = isOnTopBody;
        IsOnLegs = isOnLegs;
        IsOnFeet = isOnFeet;
    }
    public void ChangeLayerToHead()
    {
        ChangeClothingLayer(isOnHead: true);
    }
    public void ChangeLayerToGlasses()
    {
        ChangeClothingLayer(isAGlasses: true);
    }
    public void ChangeLayerToBody()
    {
        ChangeClothingLayer(isOnBody: true);
    }
    public void ChangeLayerToTopBody()
    {
        ChangeClothingLayer(isOnTopBody: true);
    }
    public void ChangeLayerToLegs()
    {
        ChangeClothingLayer(isOnLegs: true);
    }
    public void ChangeLayerToFeet()
    {
        ChangeClothingLayer(isOnFeet: true);
    }
    public void ChangeLayerToNull()
    {
        ChangeClothingLayer();
    }
}
public class Bag : Item
{
    public bool IsWearableOnBack { get; set; }

    public float VolumeCapacity { get; set; }
    public float VolumeCapacityInUse { get; set; }
    public List<Weapon> StoredWeapons { get; set; }
    public List<Gear> StoredGears { get; set; }
    public List<Explosive> StoredExplosives { get; set; }
    public List<Clothing> StoredClothings { get; set; }
    public float StoredMethamphetamines { get; set; }
    public float StoredMethamphetamineSupplies { get; set; }
    public float StoredCocain { get; set; }
    public float StoredCocainSupply { get; set; }
    public float StoredCocainSeed { get; set; }
    public float StoredWeed { get; set; }
    public float StoredWeedSupply { get; set; }
    public float StoredWeedSeed { get; set; }
    public float StoredMDMA { get; set; }
    public float StoredMDMASupply { get; set; }

    public Bag()
    {
        IsWearableOnBack = false;

        VolumeCapacity = 0f;
        VolumeCapacityInUse = 0f;
        StoredWeapons = new List<Weapon>();
        StoredGears = new List<Gear>();
        StoredExplosives = new List<Explosive>();
        StoredClothings = new List<Clothing>();
        StoredMethamphetamines = 0f;
        StoredMethamphetamineSupplies = 0f;
        StoredCocain = 0f;
        StoredCocainSupply = 0f;
        StoredCocainSeed = 0f;
        StoredWeed = 0f;
        StoredWeedSupply = 0f;
        StoredWeedSeed = 0f;
        StoredMDMA = 0f;
        StoredMDMASupply = 0f;
    }
    
    private bool CheckSpaceInStorage(float volume)
    {
        if (VolumeCapacityInUse + volume > VolumeCapacity)
            return false;
        else
            return true;
    }
    public void AddWeaponToStorage(Weapon weapon)
    {
        if (CheckSpaceInStorage(weapon.Volume))
        {
            StoredWeapons.Add(weapon);
            VolumeCapacityInUse += weapon.Volume;
        }
    }
    public void RemoveWeaponFromStorage(Weapon weapon)
    {
        if (StoredWeapons.Contains(weapon))
        {
            StoredWeapons.Remove(weapon);
            VolumeCapacityInUse -= weapon.Volume;
        }
    }
    public void AddGearToStorage(Gear gear)
    {
        if (CheckSpaceInStorage(gear.Volume))
        {
            StoredGears.Add(gear);
            VolumeCapacityInUse += gear.Volume;
        }
    }
    public void RemoveGearFromStorage(Gear gear)
    {
        if (StoredGears.Contains(gear))
        {
            StoredGears.Remove(gear);
            VolumeCapacityInUse -= gear.Volume;
        }
    }
    public void AddExplosiveToStorage(Explosive explosive)
    {
        if (CheckSpaceInStorage(explosive.Volume))
        {
            StoredExplosives.Add(explosive);
            VolumeCapacityInUse += explosive.Volume;
        }
    }
    public void RemoveExplosiveFromStorage(Explosive explosive)
    {
        if (StoredExplosives.Contains(explosive))
        {
            StoredExplosives.Remove(explosive);
            VolumeCapacityInUse -= explosive.Volume;
        }
    }
    public void AddClothingToStorage(Clothing clothing)
    {
        if (CheckSpaceInStorage(clothing.Volume))
        {
            StoredClothings.Add(clothing);
            VolumeCapacityInUse += clothing.Volume;
        }
    }
    public void RemoveClothingFromStorage(Clothing clothing)
    {
        if (StoredClothings.Contains(clothing))
        {
            StoredClothings.Remove(clothing);
            VolumeCapacityInUse -= clothing.Volume;
        }
    }
    public void AddMethamphetamineToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMethamphetamines += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMethamphetamineFromStorage(float volume)
    {
        if (StoredMethamphetamines >= volume)
        {
            StoredMethamphetamines -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddMethamphetamineSupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMethamphetamineSupplies += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMethamphetamineSupplyFromStorage(float volume)
    {
        if (StoredMethamphetamineSupplies >= volume)
        {
            StoredMethamphetamineSupplies -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddCocainToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredCocain += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveCocainFromStorage(float volume)
    {
        if (StoredCocain >= volume)
        {
            StoredCocain -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddCocainSupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredCocainSupply += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveCocainSupplyFromStorage(float volume)
    {
        if (StoredCocainSupply >= volume)
        {
            StoredCocainSupply -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddCocainSeedToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredCocainSeed += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveCocainSeedFromStorage(float volume)
    {
        if (StoredCocainSeed >= volume)
        {
            StoredCocainSeed -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddWeedToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredWeed += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveWeedFromStorage(float volume)
    {
        if (StoredWeed >= volume)
        {
            StoredWeed -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddWeedSupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredWeedSupply += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveWeedSupplyFromStorage(float volume)
    {
        if (StoredWeedSupply >= volume)
        {
            StoredWeedSupply -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddWeedSeedToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredWeedSeed += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveWeedSeedFromStorage(float volume)
    {
        if (StoredWeedSeed >= volume)
        {
            StoredWeedSeed -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddMDMAToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMDMA += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMDMAFromStorage(float volume)
    {
        if (StoredMDMA >= volume)
        {
            StoredMDMA -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddMDMASupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMDMASupply += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMDMASupplyFromStorage(float volume)
    {
        if (StoredMDMASupply >= volume)
        {
            StoredMDMASupply -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
}
public class Vehicle : Item
{
    public byte SpeedLevel { get; set; }
    public byte StealthLevel { get; set; }
    public byte PassengerCapacity { get; set; }
    public bool IsArmored { get; set; }
    public bool WorksAtGround { get; set; }
    public bool WorksAtSea { get; set; }
    public bool WorksAtAir { get; set; }

    public float VolumeCapacity { get; set; }
    public float VolumeCapacityInUse { get; set; }
    public List<Weapon> StoredWeapons { get; set; }
    public List<Gear> StoredGears { get; set; }
    public List<Explosive> StoredExplosives { get; set; }
    public List<Clothing> StoredClothings { get; set; }
    public List<Bag> StoredBags { get; set; }
    public float StoredMethamphetamines { get; set; }
    public float StoredMethamphetamineSupplies { get; set; }
    public float StoredCocain { get; set; }
    public float StoredCocainSupply { get; set; }
    public float StoredCocainSeed { get; set; }
    public float StoredWeed { get; set; }
    public float StoredWeedSupply { get; set; }
    public float StoredWeedSeed { get; set; }
    public float StoredMDMA { get; set; }
    public float StoredMDMASupply { get; set; }

    public Vehicle()
    {
        SpeedLevel = 0;
        StealthLevel = 0;
        PassengerCapacity = 0;
        IsArmored = false;
        WorksAtGround = true;
        WorksAtSea = false;
        WorksAtAir = false;

        VolumeCapacity = 0f;
        StoredWeapons = new List<Weapon>();
        StoredGears = new List<Gear>();
        StoredExplosives = new List<Explosive>();
        StoredClothings = new List<Clothing>();
        StoredBags = new List<Bag>();
        StoredMethamphetamines = 0f;
        StoredMethamphetamineSupplies = 0f;
        StoredCocain = 0f;
        StoredCocainSupply = 0f;
        StoredCocainSeed = 0f;
        StoredWeed = 0f;
        StoredWeedSupply = 0f;
        StoredWeedSeed = 0f;
        StoredMDMA = 0f;
        StoredMDMASupply = 0f;
    }

    public void ChangeSpeedLevel(sbyte amount)
    {
        SpeedLevel = Convert.ToByte(SpeedLevel + amount);
    }
    public void ChangeStealthLevel(sbyte amount)
    {
        StealthLevel = Convert.ToByte(StealthLevel + amount);
    }
    public void ChangePassengerCapacity(sbyte amount)
    {
        PassengerCapacity = Convert.ToByte(PassengerCapacity + amount);
    }

    public void SetIsArmored(bool isArmored)
    {
        IsArmored = isArmored;
    }

    public void SetVehicleWorkField(byte workFieldIndex)
    {
        WorksAtGround = false;
        WorksAtSea = false;
        WorksAtAir = false;

        switch (workFieldIndex)
        {
            case 1:
                WorksAtSea = true;
                break;
            case 2:
                WorksAtAir = true;
                break;
            default:
                WorksAtGround = true;
                break;
        }
    }

    private bool CheckSpaceInStorage(float volume)
    {
        if (VolumeCapacityInUse + volume > VolumeCapacity)
            return false;
        else
            return true;
    }
    public void AddWeaponToStorage(Weapon weapon)
    {
        if (CheckSpaceInStorage(weapon.Volume))
        {
            StoredWeapons.Add(weapon);
            VolumeCapacityInUse += weapon.Volume;
        }
    }
    public void RemoveWeaponFromStorage(Weapon weapon)
    {
        if (StoredWeapons.Contains(weapon))
        {
            StoredWeapons.Remove(weapon);
            VolumeCapacityInUse -= weapon.Volume;
        }
    }
    public void AddGearToStorage(Gear gear)
    {
        if (CheckSpaceInStorage(gear.Volume))
        {
            StoredGears.Add(gear);
            VolumeCapacityInUse += gear.Volume;
        }
    }
    public void RemoveGearFromStorage(Gear gear)
    {
        if (StoredGears.Contains(gear))
        {
            StoredGears.Remove(gear);
            VolumeCapacityInUse -= gear.Volume;
        }
    }
    public void AddExplosiveToStorage(Explosive explosive)
    {
        if (CheckSpaceInStorage(explosive.Volume))
        {
            StoredExplosives.Add(explosive);
            VolumeCapacityInUse += explosive.Volume;
        }
    }
    public void RemoveExplosiveFromStorage(Explosive explosive)
    {
        if (StoredExplosives.Contains(explosive))
        {
            StoredExplosives.Remove(explosive);
            VolumeCapacityInUse -= explosive.Volume;
        }
    }
    public void AddClothingToStorage(Clothing clothing)
    {
        if (CheckSpaceInStorage(clothing.Volume))
        {
            StoredClothings.Add(clothing);
            VolumeCapacityInUse += clothing.Volume;
        }
    }
    public void RemoveClothingFromStorage(Clothing clothing)
    {
        if (StoredClothings.Contains(clothing))
        {
            StoredClothings.Remove(clothing);
            VolumeCapacityInUse -= clothing.Volume;
        }
    }
    public void AddBagToStorage(Bag bag)
    {
        if (CheckSpaceInStorage(bag.Volume))
        {
            StoredBags.Add(bag);
            VolumeCapacityInUse += bag.Volume;
        }
    }
    public void RemoveBagFromStorage(Bag bag)
    {
        if (StoredBags.Contains(bag))
        {
            StoredBags.Remove(bag);
            VolumeCapacityInUse -= bag.Volume;
        }
    }
    public void AddMethamphetamineToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMethamphetamines += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMethamphetamineFromStorage(float volume)
    {
        if (StoredMethamphetamines >= volume)
        {
            StoredMethamphetamines -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddMethamphetamineSupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMethamphetamineSupplies += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMethamphetamineSupplyFromStorage(float volume)
    {
        if (StoredMethamphetamineSupplies >= volume)
        {
            StoredMethamphetamineSupplies -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddCocainToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredCocain += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveCocainFromStorage(float volume)
    {
        if (StoredCocain >= volume)
        {
            StoredCocain -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddCocainSeedToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredCocainSeed += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveCocainSeedFromStorage(float volume)
    {
        if (StoredCocainSeed >= volume)
        {
            StoredCocainSeed -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddCocainSupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredCocainSupply += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveCocainSupplyFromStorage(float volume)
    {
        if (StoredCocainSupply >= volume)
        {
            StoredCocainSupply -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddWeedToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredWeed += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveWeedFromStorage(float volume)
    {
        if (StoredWeed >= volume)
        {
            StoredWeed -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddWeedSupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredWeedSupply += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveWeedSupplyFromStorage(float volume)
    {
        if (StoredWeedSupply >= volume)
        {
            StoredWeedSupply -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddWeedSeedToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredWeedSeed += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveWeedSeedFromStorage(float volume)
    {
        if (StoredWeedSeed >= volume)
        {
            StoredWeedSeed -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddMDMAToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMDMA += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMDMAFromStorage(float volume)
    {
        if (StoredMDMA >= volume)
        {
            StoredMDMA -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
    public void AddMDMASupplyToStorage(float volume)
    {
        if (CheckSpaceInStorage(volume))
        {
            StoredMDMASupply += volume;
            VolumeCapacityInUse += volume;
        }
    }
    public void RemoveMDMASupplyFromStorage(float volume)
    {
        if (StoredMDMASupply >= volume)
        {
            StoredMDMASupply -= volume;
            VolumeCapacityInUse -= volume;
        }
    }
}
#endregion

#region RobbableItems
public class RobbableValuable
{
    public string Name { get; set; }
    public float Volume { get; set; }
    public uint BlackmarketValue { get; set; }
    public byte BlackmarketInterest { get; set; }

    public RobbableValuable()
    {
        Name = "Valuable";
        Volume = 1f;
        BlackmarketValue = 10000;
        BlackmarketInterest = 50;
    }

    public void SetName(string newName)
    {
        Name = newName;
    }
    public void ChangeVolume(float volume)
    {
        Volume += volume;
    }
    public void ChangeBlackmarketValue(int amount)
    {
        BlackmarketValue = Convert.ToUInt(BlackmarketInterest + amount);
    }
    public void ChangeBlackmarketInterest(sbyte amount)
    {
        if (BlackmarketInterest + amount > 100)
        {
            BlackmarketInterest = 100;
        }
        else
        {
            BlackmarketInterest = Convert.ToByte(BlackmarketInterest + amount);
        }
    }
}

public class Jewelery : RobbableValuable
{

    public Jewelery()
    {
        Name = "Jewelry";
    }
}
public class Envelope : RobbableValuable
{
    public Organization OwnerOrganization { get; set; }

    public Envelope()
    {
        Name = "Secret Envelope";
        OwnerOrganization = null;
    }

    public void SetOrganization(Organization newOrganization)
    {
        OwnerOrganization = newOrganization;
    }
}
public class Art : RobbableValuable
{

    public Art()
    {
        Name = "Art";
        Volume = 2f;
    }
}
public class SportCar : RobbableValuable
{

    public SportCar()
    {
        Name = "Sport Car";
        Volume = 200f;
    }
}
#endregion
