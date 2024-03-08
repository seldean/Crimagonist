using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using OutputController;

#region Rules
public static class LocationCreationSettings
{
    public const ushort MIN_EACH_PLACE_AMOUNT_FOR_BIG_CITY = 1000;
    public const ushort MIN_EACH_ROBBABLE_PLACE_AMOUNT_FOR_BIG_CITY = 100;
    public const byte MIN_EACH_PLACE_AMOUNT_FOR_SMALL_CITY = 10;
    public const float MIN_AMOUNT_DRIFT_MULTIPLIER = 1f;
    public const float MAX_AMOUNT_DRIFT_MULTIPLIER = 3f;
}
public static class PlaceSettings
{
    public const byte DIRTY_MONEY_PAYMENT_TO_WANTED_LEVEL_CHANCE = 10;
}
public static class CountrySettings
{
    public const byte MAX_ALARM_LEVEL = 10;
}
public static class BusinessSettings
{
    public const byte TYPE_INDEX_MAX = 6;
    public static readonly string[] TYPE_NAME_BY_INDEX = {"Other", "Office", "Night Club", "Strip Club", "Internet Cafe", "Bar", "Industrial"};

    public const uint DEFAULT_MONTHLY_EXPENSE = 500;

    public const byte CHANCE_TO_HAVE_GARAGE = 20;

    public const float MIN_STAT_DRIFT_MULTIPLIER = 0.3f;
    public const float MAX_STAT_DRIFT_MULTIPLIER = 2f;

    public static readonly uint[] PRICE_BY_TYPE_INDEX = { 50000, 2000000, 300000, 250000, 25000, 100000, 150000};

    public const float VOLUME_CAPACITY_DEFAULT = 200f;

    public const byte DEFAULT_ACCOUNTANT_AMOUNT = 2;

    public const byte LAUNDERY_DIVIDE_INCOME_AMOUNT = 4;
}
public static class RealEstateSettings
{
    public const uint DEFAULT_MONTHLY_EXPENSE = 250;

    public const byte CHANCE_TO_HAVE_GARAGE = 90;

    public const float MIN_STAT_DRIFT_MULTIPLIER = 0.1f;
    public const float MAX_STAT_DRIFT_MULTIPLIER = 2f;

    public const uint PRICE_BIG_CITY = 300000;
    public const uint PRICE_SMALL_CITY = 30000;

    public const float VOLUME_CAPACITY_DEFAULT = 400f;

    public const byte DEFAULT_COMFORT_LEVEL = 50;
}
public static class WarehouseSettings
{
    public const uint DEFAULT_MONTHLY_EXPENSE = 50;

    public const float MIN_STAT_DRIFT_MULTIPLIER = 0.5f;
    public const float MAX_STAT_DRIFT_MULTIPLIER = 5f;

    public const uint PRICE_BIG_CITY = 50000;
    public const uint PRICE_SMALL_CITY = 5000;

    public const float VOLUME_CAPACITY_DEFAULT = 4800f;
}
public static class ProductionLotSettings
{
    public const float MIN_STAT_DRIFT_MULTIPLIER = 0.2f;
    public const float MAX_STAT_DRIFT_MULTIPLIER = 2f;

    public const uint PRICE_FARM = 100000;
    public const uint PRICE_PRODUCTION_HOUSE = 30000;

    public const uint MONTHLY_EXPENSE_FARM = 500;
    public const uint MONTHLY_EXPENSE_PRODUCTION_HOUSE = 7500;

    public const byte DEFAULT_WORKER_CAPACITY = 20;

    public const float MIN_OUTPUT_MULTIPLIER = 0.1f;
    public const float MAX_OUTPUT_MULTIPLIER = 3f;

    public const float MAX_PRODUCT = 100f;
    public const float MIN_PRODUCT = 0f;
    public const float MAX_SUPPLY = 1000f;
    public const float MIN_SUPPLY = 0f;
    public const float SUPPLY_LOST_AMOUNT = 2f;
    public const float SUPPLY_TO_PRODUCT_RATIO = 2f;
}
public static class BankSettings
{
    public const float MIN_STAT_DRIFT_MULTIPLIER = 0.5f;
    public const float MAX_STAT_DRIFT_MULTIPLIER = 10f;

    public const byte DEFAULT_EARLY_CIVILIAN_AMOUNT = 10;
    public const byte DEFAULT_LATE_CIVILIAN_AMOUNT = 10;

    public const sbyte MIN_CIVILIAN_INSIDER_INTIMIDATION_CAP = -50;
    public const sbyte MAX_CIVILIAN_INSIDER_INTIMIDATION_CAP = 50;

    public const byte DEFAULT_SECURITY_LEVEL = 50;
    public const byte DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_OPEN = 5;
    public const byte DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_CLOSED = 1;
    public const byte DEFAULT_SECURITY_CAMERA_AMOUNT = 10;

    public const byte MIN_POLICE_STATION_DISTANCE = 1;
    public const byte MAX_POLICE_STATION_DISTANCE = 50;

    public const uint DEFAULT_STORED_CASH = 250000;

    public const byte CHANCE_TO_HAVE_ENVELOPE = 1;

    public const byte MIN_JEWELRY_AMOUNT = 0;
    public const byte MAX_JEWELRY_AMOUNT = 10;
}
public static class ArtGallerySettings
{
    public const float MIN_STAT_DRIFT_MULTIPLIER = 0.1f;
    public const float MAX_STAT_DRIFT_MULTIPLIER = 10f;

    public const byte DEFAULT_EARLY_CIVILIAN_AMOUNT = 20;
    public const byte DEFAULT_LATE_CIVILIAN_AMOUNT = 40;

    public const sbyte MIN_CIVILIAN_INSIDER_INTIMIDATION_CAP = -75;
    public const sbyte MAX_CIVILIAN_INSIDER_INTIMIDATION_CAP = 75;

    public const byte DEFAULT_SECURITY_LEVEL = 50;
    public const byte DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_OPEN = 4;
    public const byte DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_CLOSED = 1;
    public const byte DEFAULT_SECURITY_CAMERA_AMOUNT = 10;

    public const byte MIN_POLICE_STATION_DISTANCE = 1;
    public const byte MAX_POLICE_STATION_DISTANCE = 50;

    public const byte DEFAULT_STORED_ART_AMOUNT = 20;
}
public static class CarGallerySettings
{
    public const float MIN_STAT_DRIFT_MULTIPLIER = 0.1f;
    public const float MAX_STAT_DRIFT_MULTIPLIER = 10f;

    public const byte DEFAULT_EARLY_CIVILIAN_AMOUNT = 30;
    public const byte DEFAULT_LATE_CIVILIAN_AMOUNT = 50;

    public const sbyte MIN_CIVILIAN_INSIDER_INTIMIDATION_CAP = -50;
    public const sbyte MAX_CIVILIAN_INSIDER_INTIMIDATION_CAP = 50;

    public const byte DEFAULT_SECURITY_LEVEL = 50;
    public const byte DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_OPEN = 5;
    public const byte DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_CLOSED = 1;
    public const byte DEFAULT_SECURITY_CAMERA_AMOUNT = 10;

    public const byte MIN_POLICE_STATION_DISTANCE = 1;
    public const byte MAX_POLICE_STATION_DISTANCE = 50;

    public const byte DEFAULT_STORED_CAR_AMOUNT = 20;
}
#endregion

#region LocationBase
public class BaseLocation
{
    public string Name { get; set; }
    public bool IsHighlyPopulated { get; set; }
    public Organization LeaderOrganization { get; set; }

    public BaseLocation()
    {
        Name = "";
        IsHighlyPopulated = false;
        LeaderOrganization = null;
    }

    #region Methods
    public void ChangeName(string newName)
    {
        Name = newName;
    }
    public void ChangePopulation(bool isHighlyPopulated = true)
    {
        IsHighlyPopulated = isHighlyPopulated;
    }
    public void ChangeLeaderOrganization(Organization organization = null)
    {
        LeaderOrganization = organization;

        GameMessageScript.Notification("Your organizations is now lead organization of " + Name + ".", organization.InvolvedPlayers, Color.green, false);
    }
    #endregion
}
#endregion

#region Continents, Countries and Cities
public class Continent : BaseLocation
{
    public Continent(string name, bool isHighlyPopulated)
    {
        Name = name;
        IsHighlyPopulated = isHighlyPopulated;
    }
}
public class Country : BaseLocation
{
    public Continent Continent { get; set; }
    public byte AlarmLevel { get; set; }
    public bool DeathSentenceAllowed { get; set; }
    
    public Country(Continent continent, string name, bool isHighlyPopulated, bool deathSentenceAllowed)
    {
        Continent = continent;
        Name = name;
        IsHighlyPopulated = isHighlyPopulated;
        AlarmLevel = 0;
        DeathSentenceAllowed = deathSentenceAllowed;
    }

    public void IncreaseAlarmLevel(byte amount)
    {
        if (AlarmLevel + amount >= CountrySettings.MAX_ALARM_LEVEL)
        {
            AlarmLevel = CountrySettings.MAX_ALARM_LEVEL;
        }
        else
        {
            AlarmLevel += amount;
        }

        //Notifying the players inside country.
        List<Player> notifyPlayers = new List<Player>();
        foreach (Player pl in CharacterStorage.Players) {
            if (pl.CurrentLocation.Country.Name == Name) {
                notifyPlayers.Add(pl);
            }
        }
        GameMessageScript.Notification(Name + "'s alarm level is increased by" + amount + ". Current alarm level: " + AlarmLevel + ".", notifyPlayers, Color.red, false);
    }
    public void DecreaseAlarmLevel(byte amount)
    {
        if (AlarmLevel - amount <= 0)
        {
            AlarmLevel = 0;
        }
        else
        {
            AlarmLevel -= amount;
        }

        //Notifying the players inside country.
        List<Player> notifyPlayers = new List<Player>();
        foreach (Player pl in CharacterStorage.Players)
        {
            if (pl.CurrentLocation.Country.Name == Name)
            {
                notifyPlayers.Add(pl);
            }
        }
        GameMessageScript.Notification(Name + "'s alarm level is decreased by" + amount + ". Current alarm level: " + AlarmLevel + ".", notifyPlayers, Color.green, false);
    }
}
public class City : BaseLocation
{
    public Country Country { get; set; }

    public City(Country country, string name, bool isHighlyPopulated)
    {
        Country = country;
        Name = name;
        IsHighlyPopulated = isHighlyPopulated;
    }
}
#endregion

#region Places
public class Place : BaseLocation
{
    public bool IsActive { get; set; }
    public uint Price { get; set; }
    public uint Debt { get; set; }
    public uint MonthlyExpense { get; set; }
    public City Address { get; set; }
    public byte SecurityLevel { get; set; }
    public Player OwnerPlayer { get; set; }

    public float VolumeCapacity { get; set; }
    public float VolumeCapacityInUse { get; set; }
    public List<Weapon> StoredWeapons { get; set; }
    public List<Gear> StoredGears { get; set; }
    public List<Explosive> StoredExplosives { get; set; }
    public List<Clothing> StoredClothings { get; set; }
    public List<Bag> StoredBags { get; set; }
    public bool IsStorageAcceptingVehicles { get; set; }
    public List<Vehicle> StoredVehicles { get; set; }
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

    public Place()
    {
        IsActive = false;
        Price = 0;
        Debt = 0;
        MonthlyExpense = 500;
        SecurityLevel = 0;
        OwnerPlayer = null;

        VolumeCapacity = 0f;
        VolumeCapacityInUse = 0f;
        StoredWeapons = new List<Weapon>();
        StoredGears = new List<Gear>();
        StoredExplosives = new List<Explosive>();
        StoredClothings = new List<Clothing>();
        StoredBags = new List<Bag>();
        IsStorageAcceptingVehicles = false;
        StoredVehicles = new List<Vehicle>();
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

    //Triggers
    public void TriggerDaily()
    {
        
    }
    public void TriggerWeekly()
    {

    }
    public void TriggerMonthly()
    {
        //Monthly Expense
        if (OwnerPlayer != null)
        {
            if (OwnerPlayer.MoneyDollar >= MonthlyExpense)
            {
                OwnerPlayer.MoneyDollar -= MonthlyExpense;
                GameMessageScript.Notification("-" + MonthlyExpense + "$ from place: " + Name + ".", new List<Player> { OwnerPlayer }, Color.yellow, true);
            }
            else if (OwnerPlayer.DirtyMoneyDollar >= MonthlyExpense)
            {
                OwnerPlayer.DirtyMoneyDollar -= MonthlyExpense;
                GameMessageScript.Notification("-" + MonthlyExpense + "$ (Dirty) from place: " + Name + ".", new List<Player> { OwnerPlayer }, Color.yellow, true);
                if (!Address.IsHighlyPopulated)
                {
                    if (OwnerPlayer.WantedLevel <= 2)
                    {
                        if (Random.Range(0, 101) < PlaceSettings.DIRTY_MONEY_PAYMENT_TO_WANTED_LEVEL_CHANCE - (PlaceSettings.DIRTY_MONEY_PAYMENT_TO_WANTED_LEVEL_CHANCE / 2))
                        {
                            OwnerPlayer.GiveWantedLevel(1);
                            GameMessageScript.Notification("+1 wanted level. Cause: " + Name + "'s expenses paid with dirty money.", new List<Player> { OwnerPlayer }, Color.red, true);
                        }
                    }
                    else
                    {
                        if (Random.Range(0, 101) < PlaceSettings.DIRTY_MONEY_PAYMENT_TO_WANTED_LEVEL_CHANCE)
                        {
                            OwnerPlayer.GiveWantedLevel(1);
                            GameMessageScript.Notification("+1 wanted level. Cause: " + Name + "'s expenses paid with dirty money.", new List<Player> { OwnerPlayer }, Color.red, true);
                        }
                    }
                }
            }
            else
            {
                IsActive = false;
                Debt += MonthlyExpense;
                GameMessageScript.Notification(Name + "'s debt is increased, and now it is " + Debt + "$.", new List<Player> { OwnerPlayer }, Color.red, true);
            }
        }
    }
    public void TriggerYearly()
    {

    }

    public void PayDebt()
    {
        if (OwnerPlayer.MoneyDollar >= Debt)
        {
            OwnerPlayer.MoneyDollar -= Debt;
            IsActive = true;
            GameMessageScript.Notification(Name + "'s debt is now closed (" + Debt + "$) and the " + Name + " is active again.", new List<Player> { OwnerPlayer }, Color.yellow, true);
        }
        else if (OwnerPlayer.DirtyMoneyDollar >= Debt)
        {
            OwnerPlayer.DirtyMoneyDollar -= Debt;
            IsActive = true;
            GameMessageScript.Notification(Name + "'s debt is now closed (" + Debt + "$ (Dirty)) and the " + Name + " is active again.", new List<Player> { OwnerPlayer }, Color.yellow, true);
            if (!Address.IsHighlyPopulated)
            {
                if (OwnerPlayer.WantedLevel <= 2)
                {
                    if (Random.Range(0, 101) < PlaceSettings.DIRTY_MONEY_PAYMENT_TO_WANTED_LEVEL_CHANCE - (PlaceSettings.DIRTY_MONEY_PAYMENT_TO_WANTED_LEVEL_CHANCE / 2))
                    {
                        OwnerPlayer.GiveWantedLevel(1);
                        GameMessageScript.Notification("+1 wanted level. Cause: " + Name+ "'s debt paid with dirty money.", new List<Player> { OwnerPlayer }, Color.red, true);
                    }
                }
                else
                {
                    if (Random.Range(0, 101) < PlaceSettings.DIRTY_MONEY_PAYMENT_TO_WANTED_LEVEL_CHANCE)
                    {
                        OwnerPlayer.GiveWantedLevel(1);
                        GameMessageScript.Notification("+1 wanted level. Cause: " + Name + "'s debt paid with dirty money.", new List<Player> { OwnerPlayer }, Color.red, true);
                    }
                }
            }
        }
        else
        {
            GameMessageScript.Notification("You can't afford the debt of " + Name + ".", new List<Player> { OwnerPlayer }, Color.yellow, true);
        }
    }

    public void ChangePrice(uint changeAmount)
    {
        Price = Convert.ToUInt(Price + changeAmount);
    }
    public void SetPrice(uint newValue)
    {
        Price = newValue;
    }
    public void ChangeMonthlyExpense(uint changeAmount)
    {
        MonthlyExpense = Convert.ToUInt(MonthlyExpense + changeAmount);
        GameMessageScript.Notification(Name + "'s monthly expenses are changed by " + changeAmount + "$, and now it's " + MonthlyExpense + "$/Month.", new List<Player> { OwnerPlayer }, Color.yellow, true);
    }
    public void SetMonthlyExpense(uint newValue)
    {
        MonthlyExpense = newValue;
        GameMessageScript.Notification(Name + "'s monthly expenses are changed, and now it is " + MonthlyExpense + "$/Month.", new List<Player> { OwnerPlayer }, Color.yellow, true);
    }
    public void ChangeSecurityLevel(uint changeAmount)
    {
        SecurityLevel = Convert.ToByte(SecurityLevel + changeAmount);
    }
    public void SetSecurityLevel(byte newValue)
    {
        SecurityLevel = newValue;
    }
    public void SetOwnerPlayer(Player newOwner)
    {
        IsActive = true;
        OwnerPlayer = newOwner;
        GameMessageScript.Notification("You are now the owner of " + Name + ".", new List<Player> { OwnerPlayer }, Color.green, false);
    }
    public void SetOwnerAsMarket()
    {
        GameMessageScript.Notification("You are no longer the owner of " + Name + ".", new List<Player> { OwnerPlayer }, Color.yellow, true);
        IsActive = false;
        OwnerPlayer = null;
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
    public void AddVehicleToStorage(Vehicle vehicle)
    {
        if (IsStorageAcceptingVehicles)
        {
            if (CheckSpaceInStorage(vehicle.Volume))
            {
                StoredVehicles.Add(vehicle);
                VolumeCapacityInUse += vehicle.Volume;
            }
        }
    }
    public void RemoveVehicleFromStorage(Vehicle vehicle)
    {
        if (StoredVehicles.Contains(vehicle))
        {
            StoredVehicles.Remove(vehicle);
            VolumeCapacityInUse -= vehicle.Volume;
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
public class Business : Place
{
    public uint Income { get; set; }
    public uint MonthlyLaunderingCapacity { get; set; }
    public byte AccountantCapacity { get; set; }

    public Business()
    {
        Income = 0;
        MonthlyLaunderingCapacity = 0;
        AccountantCapacity = 0;
    }

    public void MultiplyIncome(float multiplyAmount)
    {
        Income = Convert.ToUInt(Income * multiplyAmount);
    }
    public void ChangeIncome(int amount)
    {
        Income = Convert.ToUInt(Income + amount);
    }

    private void UpdateLaunderingCapacity()
    {
        MonthlyLaunderingCapacity = Income / BusinessSettings.LAUNDERY_DIVIDE_INCOME_AMOUNT;
    }

    public void ChangeAccountantAmount(sbyte amount)
    {
        AccountantCapacity = Convert.ToByte(AccountantCapacity + amount);
        GameMessageScript.Notification(Name + "'s Accountant capacity has increased by " + amount + ".", new List<Player> { OwnerPlayer }, Color.green, true);
    }
}
public class RealEstate : Place
{
    public byte ComfortLevel { get; set; }

    public RealEstate()
    {
        ComfortLevel = 0;
    }

    public void ChangeComfortLevel(sbyte amount)
    {
        ComfortLevel = Convert.ToByte(ComfortLevel + amount);
    }
}
public class Warehouse : Place
{
    public Warehouse()
    {
        IsStorageAcceptingVehicles = true;
    }
}
public class ProductionLot : Place
{
    public string ProductionType { get; set; } //Weed, Meth, Cocain, MDMA
    public bool AutoSwapProductionType { get; set; }
    public float OutputMultiplier { get; set; }
    public byte WorkerCapacity { get; set; }
    public byte WorkerCapacityInUse { get; set; }
    public List<NPC> NPCWorkers { get; set; }
    public List<Player> PlayerWorkers { get; set; }

    public Gear CurrentEquipment { get; set; }

    public bool IsFarm { get; set; }

    public ProductionLot()
    {
        ProductionType = "Idle";
        AutoSwapProductionType = true;
        OutputMultiplier = 1f;
        WorkerCapacity = 0;
        WorkerCapacityInUse = 0;
        NPCWorkers = new List<NPC>();
        PlayerWorkers = new List<Player>();
        CurrentEquipment = new Gear();
        IsFarm = false;
    }

    public void Produce()
    {
        uint SumOfSkills = 0;
        uint AverageOfSkills = 0;
        float SupplyLost = ProductionLotSettings.SUPPLY_LOST_AMOUNT;

        foreach (NPC npc in NPCWorkers)
        {
            if (!IsFarm)
            {
                switch (ProductionType)
                {
                    case "Weed":
                        SumOfSkills += Convert.ToUInt(npc.ProduceWeedLevel);
                        break;
                    case "Cocain":
                        SumOfSkills += Convert.ToUInt(npc.ProduceCocainLevel);
                        break;
                    case "Methamphetamine":
                        SumOfSkills += Convert.ToUInt(npc.ProduceMethLevel);
                        break;
                    case "MDMA":
                        SumOfSkills += Convert.ToUInt(npc.ProduceMDMALevel);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                SumOfSkills += npc.FarmerLevel;
            }
        }
        foreach (Player player in PlayerWorkers)
        {
            if (!IsFarm)
            {
                switch (ProductionType)
                {
                    case "Weed":
                        SumOfSkills += Convert.ToUShort(player.ProduceWeedLevel);
                        break;
                    case "Cocain":
                        SumOfSkills += Convert.ToUShort(player.ProduceCocainLevel);
                        break;
                    case "Methamphetamine":
                        SumOfSkills += Convert.ToUShort(player.ProduceMethLevel);
                        break;
                    case "MDMA":
                        SumOfSkills += Convert.ToUShort(player.ProduceMDMALevel);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                SumOfSkills += player.FarmerLevel;
            }
        }

        AverageOfSkills = Convert.ToUInt(SumOfSkills / (NPCWorkers.Count + PlayerWorkers.Count));

        SupplyLost = (SupplyLost - (AverageOfSkills / (CharacterCapacities.SKILLS_CAP / 2))) + ProductionLotSettings.SUPPLY_TO_PRODUCT_RATIO;
        if (!IsFarm)
        {
            if (ItemStorage.LabEquipments.Contains(CurrentEquipment))
            {
                SupplyLost -= 0.5f;
            }
            else if (ItemStorage.AdvencedLabEquipments.Contains(CurrentEquipment))
            {
                SupplyLost -= 2f;
            }
        }
        else
        {
            if (ItemStorage.GardeningTools.Contains(CurrentEquipment))
            {
                SupplyLost -= 0.5f;
            }
            else if (ItemStorage.AdvencedGardeningTools.Contains(CurrentEquipment))
            {
                SupplyLost -= 2f;
            }
        }

        if (SupplyLost < 0f)
        {
            SupplyLost = 0f;
        }

        switch (ProductionType)
        {
            case "Weed":
                if (StoredWeedSupply >= SupplyLost)
                {
                    StoredWeedSupply -= SupplyLost;
                    StoredWeed = StoredWeed + (1f * OutputMultiplier);
                    GameMessageScript.Notification(Name + "'s production report: Current weed amount in house is " + StoredWeed + ". Current weed supply amount in house is " + StoredWeedSupply + ".", new List<Player> { OwnerPlayer }, Color.green, true);
                }
                break;
            case "Methamphetamine":
                if (StoredMethamphetamineSupplies >= SupplyLost)
                {
                    StoredMethamphetamineSupplies -= SupplyLost;
                    StoredMethamphetamines = StoredMethamphetamines + (1f * OutputMultiplier);
                    GameMessageScript.Notification(Name + "'s production report: Current meth amount in house is " + StoredMethamphetamines + ". Current meth supply amount in house is " + StoredMethamphetamineSupplies + ".", new List<Player> { OwnerPlayer }, Color.green, true);
                }
                break;
            case "Cocain":
                if (StoredCocainSupply >= SupplyLost)
                {
                    StoredCocainSupply -= SupplyLost;
                    StoredCocain = StoredCocain + (1f * OutputMultiplier);
                    GameMessageScript.Notification(Name + "'s production report: Current cocain amount in house is " + StoredCocain + ". Current cocain supply amount in house is " + StoredCocainSupply + ".", new List<Player> { OwnerPlayer }, Color.green, true);
                }
                break;
            case "MDMA":
                if (StoredMDMASupply >= SupplyLost)
                {
                    StoredMDMASupply -= SupplyLost;
                    StoredMDMA = StoredMDMA + (1f * OutputMultiplier);
                    GameMessageScript.Notification(Name + "'s production report: Current MDMA amount in house is " + StoredMDMA + ". Current MDMA supply amount in house is " + StoredMDMASupply + ".", new List<Player> { OwnerPlayer }, Color.green, true);
                }
                break;
            case "WeedSupply":
                if (StoredWeedSeed >= SupplyLost)
                {
                    StoredWeedSeed -= SupplyLost;
                    StoredWeedSupply = StoredWeedSupply + (1f * OutputMultiplier);
                    GameMessageScript.Notification(Name + "'s production report: Current weed supply amount in house is " + StoredWeedSupply + ". Current weed seed amount in house is " + StoredWeedSeed + ".", new List<Player> { OwnerPlayer }, Color.green, true);
                }
                break;
            case "CocainSupply":
                if (StoredCocainSeed >= SupplyLost)
                {
                    StoredCocainSeed -= SupplyLost;
                    StoredCocainSupply = StoredCocainSupply + (1f * OutputMultiplier);
                    GameMessageScript.Notification(Name + "'s production report: Current cocain supply amount in house is " + StoredCocainSupply + ". Current cocain seed amount in house is " + StoredCocainSeed + ".", new List<Player> { OwnerPlayer }, Color.green, true);
                }
                break;
            default:
                break;
        }
    }

    public void ChangeProductionType(string newType = "Idle")
    {
        switch (newType)
        {
            case "Weed":
                ProductionType = newType;
                IsFarm = false;
                break;
            case "Methamphetamine":
                ProductionType = newType;
                IsFarm = false;
                break;
            case "Cocain":
                ProductionType = newType;
                IsFarm = false;
                break;
            case "MDMA":
                ProductionType = newType;
                IsFarm = false;
                break;
            case "WeedSupply":
                ProductionType = newType;
                IsFarm = true;
                break;
            case "CocainSupply":
                ProductionType = newType;
                IsFarm = true;
                break;
            default:
                ProductionType = "Idle";
                IsFarm = false;
                break;
        }

        GameMessageScript.Notification(Name + "'s production type is changed to " + newType, new List<Player> { OwnerPlayer }, Color.yellow, true);
    }

    public void SetAutoSwapProductionType(bool isEnabled = true)
    {
        AutoSwapProductionType = isEnabled;
    }

    public void ChangeOutputMultiplier(float amount)
    {
        OutputMultiplier += amount;
    }

    public void ChangeWorkerCapacity(sbyte amount)
    {
        if (WorkerCapacity + amount <= 0)
        {
            WorkerCapacity = 0;
            GameMessageScript.Notification(Name + "'s has a worker capacity crisis. Worker Capacity: 0.", new List<Player> { OwnerPlayer }, Color.red, true);
        }
        else
        {
            WorkerCapacity = Convert.ToByte(WorkerCapacity + amount);
            GameMessageScript.Notification(Name + "'s worker capacity has changed and now it is " + WorkerCapacity + ".", new List<Player> { OwnerPlayer }, Color.yellow, true);
        }
    }
    public void AddNPCWorker(NPC newWorker)
    {
        if (!NPCWorkers.Contains(newWorker) && WorkerCapacityInUse < WorkerCapacity)
        {
            NPCWorkers.Add(newWorker);
            WorkerCapacityInUse++;
        }
    }
    public void RemoveNPCWorker(NPC worker)
    {
        if (NPCWorkers.Contains(worker))
        {
            NPCWorkers.Remove(worker);
            WorkerCapacityInUse--;
        }
    }
    public void AddPlayerWorker(Player newWorker)
    {
        if (!PlayerWorkers.Contains(newWorker) && WorkerCapacityInUse < WorkerCapacity)
        {
            PlayerWorkers.Add(newWorker);
            WorkerCapacityInUse++;
        }
    }
    public void RemovePlayerWorker(Player worker)
    {
        if (PlayerWorkers.Contains(worker))
        {
            PlayerWorkers.Remove(worker);
            WorkerCapacityInUse--;
        }
    }

    public void ChangeEquipment(Gear gear)
    {
        CurrentEquipment = gear;
    }
}
#endregion

#region Robbable Place
public class RobbablePlace
{
    public string Name { get; set; }
    public City Address { get; set; }

    public byte EarlyCivilianAmount { get; set; }
    public byte EarlyEndTime { get; set; }
    public byte LateCivilianAmount { get; set; }

    public bool IsThereInsider { get; set; }
    public short CivilianInsiderIntimidationCap { get; set; }

    public byte SecurityLevel { get; set; }
    public byte SecurityOfficerAmountWhileOpen { get; set; }
    public byte SecurityOfficerAmountWhileClosed { get; set; }
    public bool IsSecurityArmed { get; set; }
    public bool IsSecurityAlarmed { get; set; }
    public Weapon SecurityOfficerWeapons { get; set; }
    public byte SecurityCameraAmount { get; set; }

    public byte PoliceStationDistance { get; set; } //UNIT

    public bool IsLoudAlarmOn { get; set; }
    public bool IsSilentAlarmOn { get; set; }

    public byte OpeningHour { get; set; }
    public byte ClosingHour { get; set; }

    public RobbablePlace()
    {
        Name = "";

        EarlyCivilianAmount = 0;
        EarlyEndTime = 13;
        LateCivilianAmount = 0;

        IsThereInsider = false;
        CivilianInsiderIntimidationCap = 50;

        SecurityLevel = 0;
        SecurityOfficerAmountWhileOpen = 0;
        SecurityOfficerAmountWhileClosed = 0;
        IsSecurityArmed = false;
        IsSecurityAlarmed = false;
        SecurityOfficerWeapons = new Weapon();
        SecurityCameraAmount = 0;

        PoliceStationDistance = 0;

        IsLoudAlarmOn = false;
        IsSilentAlarmOn = false;

        OpeningHour = 9;
        ClosingHour = 17;
    }

    //Triggers
    public void TriggerDaily()
    {

    }
    public void TriggerWeekly()
    {

    }
    public void TriggerMonthly()
    {
        
    }
    public void TriggerYearly()
    {

    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public void ChangeAddress(City city)
    {
        Address = city;
    }

    public void ChangeEarlyCivilianAmount(sbyte amount)
    {
        EarlyCivilianAmount = Convert.ToByte(EarlyCivilianAmount + amount);
    }
    public void ChangeEarlyEndTime(byte newTime = 13)
    {
        EarlyEndTime = newTime;
    }
    public void ChangeLateCivilianAmount(sbyte amount)
    {
        LateCivilianAmount = Convert.ToByte(LateCivilianAmount + amount);
    }

    public void ChangeIsThereInsider(bool isThereInsider)
    {
        IsThereInsider = isThereInsider;
    }
    public void ChangeCivilianInsiderIntimidationCap(short amount)
    {
        if (CivilianInsiderIntimidationCap + amount >= 100)
        {
            CivilianInsiderIntimidationCap = 100;
        }
        else if (CivilianInsiderIntimidationCap + amount <= -100)
        {
            CivilianInsiderIntimidationCap = -100;
        }
        else
        {
            CivilianInsiderIntimidationCap = Convert.ToShort(CivilianInsiderIntimidationCap + amount);
        }
    }

    public void ChangeSecurityLevel(sbyte amount)
    {
        SecurityLevel = Convert.ToByte(SecurityLevel + amount);
    }
    public void ChangeSecurityOfficerAmountWhileOpen(sbyte amount)
    {
        SecurityOfficerAmountWhileOpen = Convert.ToByte(SecurityOfficerAmountWhileOpen + amount);
    }
    public void ChangeSecurityOfficerAmountWhileClosed(sbyte amount)
    {
        SecurityOfficerAmountWhileClosed = Convert.ToByte(SecurityOfficerAmountWhileClosed + amount);
    }
    public void ChangeIsSecurityArmed(bool isSecurityArmed)
    {
        IsSecurityArmed = isSecurityArmed;
    }
    public void ChangeIsSecurityAlarmed(bool isSecurityAlarmed)
    {
        IsSecurityAlarmed = isSecurityAlarmed;
    }
    public void ChangeSecurityWeapon(Weapon newWeapon)
    {
        SecurityOfficerWeapons = newWeapon;
    }
    public void ChangeSecurityCameraAmount(sbyte amount)
    {
        SecurityCameraAmount = Convert.ToByte(SecurityCameraAmount + amount);
    }

    public void ChangePoliceStationDistance(sbyte amount)
    {
        PoliceStationDistance = Convert.ToByte(PoliceStationDistance + amount);
    }

    public void ChangeLoudAlarmState(bool isLoudAlarmOn)
    {
        IsLoudAlarmOn = isLoudAlarmOn;
    }
    public void ChangeSilentAlarmState(bool isSilentAlarmOn)
    {
        IsSilentAlarmOn = isSilentAlarmOn;
    }

    public void ChangeOpeningHour(byte newTime)
    {
        OpeningHour = newTime;
    }
    public void ChangeClosingHour(byte newTime)
    {
        ClosingHour = newTime;
    }
}
public class Bank : RobbablePlace
{
    public uint StoredCash { get; set; }
    public bool IsThereDepositBoxes { get; set; }
    public List<Jewelery> Jeweleries { get; set; }
    public Envelope Envelope { get; set; }

    public Bank()
    {
        StoredCash = 0;
        IsThereDepositBoxes = false;
        Jeweleries = new List<Jewelery>();
        Envelope = null;
    }

    public void ChangeStoredCash(int amount)
    {
        StoredCash = Convert.ToUInt(StoredCash + amount);
    }
    public void ChangeIsThereDepositBoxes(bool isThereDepositBoxes)
    {
        IsThereDepositBoxes = isThereDepositBoxes;
    }
    public void AddJewelry(Jewelery jewelery)
    {
        Jeweleries.Add(jewelery);
    }
    public void RemoveJewelry(Jewelery jewelery)
    {
        Jeweleries.Remove(jewelery);
    }
    public void AddJeweleries(List<Jewelery> listOfJeweleries)
    {
        foreach (Jewelery jewelery in listOfJeweleries)
        {
            Jeweleries.Add(jewelery);
        }
    }
    public void AddEnvelope(Envelope envelope)
    {
        Envelope = envelope;
    }
    public void RemoveEnvelope()
    {
        Envelope = null;
    }
}
public class ArtGallery : RobbablePlace
{
    public byte StoredArtAmount { get; set; }
    public List<Art> StoredArts { get; set; }

    public ArtGallery()
    {
        StoredArtAmount = 0;
        StoredArts = new List<Art>();
    }

    public void ChangeStoredArtAmount(sbyte amount)
    {
        StoredArtAmount = Convert.ToByte(StoredArtAmount + amount);
    }
    public void AddArt(Art art)
    {
        StoredArts.Add(art);
    }
    public void RemoveArt(Art art)
    {
        StoredArts.Remove(art);
    }
    public void AddArts(List<Art> arts)
    {
        foreach (Art art in arts)
        {
            StoredArts.Add(art);
        }
    }
}
public class CarGallery : RobbablePlace
{
    public byte StoredCarAmount { get; set; }
    public List<SportCar> StoredSportCars { get; set; }

    public CarGallery()
    {
        StoredCarAmount = 0;
        StoredSportCars = new List<SportCar>();
    }

    public void ChangeStoredCarAmount(sbyte amount) 
    {
        StoredCarAmount = Convert.ToByte(StoredCarAmount + amount);
    }
    public void AddSportCar(SportCar car)
    {
        StoredSportCars.Add(car);
    }
    public void RemoveSportCar(SportCar car)
    {
        StoredSportCars.Remove(car);
    }
    public void AddSportCars(List<SportCar> cars)
    {
        foreach(SportCar car in cars)
        {
            StoredSportCars.Add(car);
        }
    }
}
#endregion
