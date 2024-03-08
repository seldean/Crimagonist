using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OutputController;

public class ItemStorage
{
    #region Decleration:Weapons
    //Ranged Weapons
    public static List<Weapon> AL47s = new List<Weapon>();
    public static List<Weapon> M40s = new List<Weapon>();
    public static List<Weapon> SMGs = new List<Weapon>();
    public static List<Weapon> MicroSMGs = new List<Weapon>();
    public static List<Weapon> BM4s = new List<Weapon>();
    public static List<Weapon> Spastic12s = new List<Weapon>();
    public static List<Weapon> Glotks = new List<Weapon>();
    public static List<Weapon> Cults = new List<Weapon>();
    public static List<Weapon> DesertTigers = new List<Weapon>();
    public static List<Weapon> Revolvers = new List<Weapon>();
    public static List<Weapon> Negets = new List<Weapon>();
    public static List<Weapon> SVKinetics = new List<Weapon>();
    //Melee Weapons
    public static List<Weapon> BaseballBats = new List<Weapon>();
    public static List<Weapon> PoliceJops = new List<Weapon>();
    public static List<Weapon> Knifes = new List<Weapon>();
    public static List<Weapon> MeatBlades = new List<Weapon>();
    public static List<Weapon> Axes = new List<Weapon>();
    public static List<Weapon> KnuckleDusters = new List<Weapon>();
    #endregion
    #region Decleration:Gears
    public static List<Gear> AssistantAIs = new List<Gear>();
    public static List<Gear> RadioLevelJammers = new List<Gear>();
    public static List<Gear> WhiteNoiseMakers = new List<Gear>();
    public static List<Gear> PoliceRadioListeners = new List<Gear>();
    public static List<Gear> LANBlockadeSoftwares = new List<Gear>();
    public static List<Gear> SurveilanceBlockadeSoftwares = new List<Gear>();
    public static List<Gear> BurnerPhones = new List<Gear>();
    public static List<Gear> ClosedWebAccess = new List<Gear>();
    public static List<Gear> Earphones = new List<Gear>();
    public static List<Gear> NightVisions = new List<Gear>();
    public static List<Gear> WeldingMasks = new List<Gear>();
    public static List<Gear> Drills = new List<Gear>();
    public static List<Gear> HeavyDrills = new List<Gear>();
    public static List<Gear> Cutters = new List<Gear>();
    public static List<Gear> HeavyCutters = new List<Gear>();
    public static List<Gear> Laptops = new List<Gear>();
    public static List<Gear> LabEquipments = new List<Gear>();
    public static List<Gear> AdvencedLabEquipments = new List<Gear>();
    public static List<Gear> GardeningTools = new List<Gear>();
    public static List<Gear> AdvencedGardeningTools = new List<Gear>();
    #endregion
    #region Decleration:Explosives
    //Explosives
    public static List<Explosive> TNTs = new List<Explosive>();
    public static List<Explosive> C4s = new List<Explosive>();
    public static List<Explosive> Dynamites = new List<Explosive>();
    public static List<Explosive> PETNs = new List<Explosive>();
    public static List<Explosive> HMXs = new List<Explosive>();
    #endregion
    #region Decleration:Clothings
    public static List<Clothing> Balaclavas = new List<Clothing>();
    public static List<Clothing> SkiMasks = new List<Clothing>();
    public static List<Clothing> HockeyMasks = new List<Clothing>();
    public static List<Clothing> SunGlasses = new List<Clothing>();
    public static List<Clothing> TacticalGoggles = new List<Clothing>();
    public static List<Clothing> TacticalHelmets = new List<Clothing>();
    public static List<Clothing> TShirts = new List<Clothing>();
    public static List<Clothing> CargoTops = new List<Clothing>();
    public static List<Clothing> TacticalTops = new List<Clothing>();
    public static List<Clothing> Suits = new List<Clothing>();
    public static List<Clothing> LabUniforms = new List<Clothing>();
    public static List<Clothing> BulletproofVests = new List<Clothing>();
    public static List<Clothing> KevlarArmors = new List<Clothing>();
    public static List<Clothing> CeramicArmors = new List<Clothing>();
    public static List<Clothing> SteelArmors = new List<Clothing>();
    public static List<Clothing> SuitPants = new List<Clothing>();
    public static List<Clothing> KevlarPants = new List<Clothing>();
    public static List<Clothing> CargoPants = new List<Clothing>();
    public static List<Clothing> TacticalBottoms = new List<Clothing>();
    public static List<Clothing> MilitaryBoots = new List<Clothing>();
    public static List<Clothing> SuitShoes = new List<Clothing>();
    #endregion
    #region Decleration:Bags
    public static List<Bag> Backpacks = new List<Bag>();
    public static List<Bag> DuffleBags = new List<Bag>();
    public static List<Bag> SuitCases = new List<Bag>();
    public static List<Bag> BriefCases = new List<Bag>();
    public static List<Bag> LaptopBags = new List<Bag>();
    #endregion
    #region Decleration:Vehicles
    public static List<Vehicle> SakiraSedans = new List<Vehicle>();
    public static List<Vehicle> SakiraPickups = new List<Vehicle>();
    public static List<Vehicle> SakiraPanelVans = new List<Vehicle>();
    public static List<Vehicle> SakiraBoxTrucks = new List<Vehicle>();
    public static List<Vehicle> SakiraJetSkis = new List<Vehicle>();
    public static List<Vehicle> SakiraDinghies = new List<Vehicle>();
    public static List<Vehicle> SakiraSailboats = new List<Vehicle>();
    public static List<Vehicle> SakiraSpeedBoats = new List<Vehicle>();
    public static List<Vehicle> SakiraYatch = new List<Vehicle>();
    public static List<Vehicle> SakiraSingleEnginePlanes = new List<Vehicle>();
    public static List<Vehicle> SakiraTwoEnginePlanes = new List<Vehicle>();
    public static List<Vehicle> SakiraBusinessJets = new List<Vehicle>();
    public static List<Vehicle> SakiraSingleEngineHelicopters = new List<Vehicle>();
    public static List<Vehicle> SakiraTwoEngineHelicopters = new List<Vehicle>();
    #endregion

    #region Creation Tools
    private byte SelectByteStatForItems(byte preferredLevel, bool isDriftActive)
    {
        if (isDriftActive)
        {
            byte statDriftValue = ItemCreationSettings.STAT_DRIFT_VALUE;
            int skillLevel = Random.Range(preferredLevel - statDriftValue, preferredLevel + statDriftValue);

            if (skillLevel >= ItemCapacities.STAT_CAP)
            {
                skillLevel = 125;
            }
            else if (skillLevel <= 0)
            {
                skillLevel = 0;
            }

            return Convert.ToByte(skillLevel);
        }

        return preferredLevel;
    }
    private string GenerateSerialNumber()
    {
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        for (int i = 0; i < ItemCreationSettings.SERIAL_NUMBER_LENGTH; i++)
        {
            if (i == 2)
            {
                stringBuilder.Append("-");
            }
            else
            {
                byte randomIndex = Convert.ToByte(Random.Range(0, ItemCreationSettings.SERIAL_NUMBER_CHARACTERS.Length));
                char randomChar = ItemCreationSettings.SERIAL_NUMBER_CHARACTERS[randomIndex];
                stringBuilder.Append(randomChar);
            }
        }

        return stringBuilder.ToString();
    }
    private byte GenerateDurability()
    {
        return Convert.ToByte(Random.Range(ItemCreationSettings.DURABILIY_MIN, ItemCreationSettings.DURABILITY_MAX));
    }
    #endregion

    #region Creating:Weapons
    private void CreateWeaponArray(List<Weapon> weaponList, uint price, string name, byte policeInterest, ushort volume, byte power, byte damage, byte intimidation, bool isDriftActive, bool isRanged)
    {
        for (int i = 0; i < ItemCreationSettings.AMOUT_OF_EACH_ITEM; i++)
        {
            Weapon weapon = new Weapon();

            weapon.Name = name;
            weapon.SerialNumber = GenerateSerialNumber();
            weapon.Durability = GenerateDurability();
            weapon.PoliceInterest = policeInterest;
            weapon.Volume = volume;
            weapon.Price = price;
            weapon.OwnerPlayer = null;
            weapon.OwnerNPC = null;

            weapon.PowerLevel = SelectByteStatForItems(power, isDriftActive);
            weapon.DamageLevel = SelectByteStatForItems(damage, isDriftActive);
            weapon.IntimidationLevel = SelectByteStatForItems(intimidation, isDriftActive);
            weapon.IsRanged = isRanged;
            weapon.IsOffRecord = !isRanged;

            weaponList.Add(weapon);
        }
    }
    public void CREATEWEAPONS()
    {
        CreateWeaponArray(AL47s, 800, "AL-47", 100, 10, 90, 90, 100, true, true);
        CreateWeaponArray(M40s, 3000, "M40", 95, 10, 95, 85, 100, true, true);
        CreateWeaponArray(SMGs, 2500, "SMG", 90, 5, 75, 70, 85, true, true);
        CreateWeaponArray(MicroSMGs, 1000, "Micro SMG", 85, 4, 70, 65, 80, true, true);
        CreateWeaponArray(BM4s, 2500, "BM4", 120, 12, 100, 110, 100, true, true);
        CreateWeaponArray(Spastic12s, 3000, "Spastic-12", 120, 14, 110, 120, 110, true, true);
        CreateWeaponArray(Glotks, 500, "Glotk", 30, 2, 50, 50, 50, true, true);
        CreateWeaponArray(Cults, 1000, "Cult", 35, 2, 60, 55, 60, true, true);
        CreateWeaponArray(DesertTigers, 1750, "Desert Tiger", 40, 3, 75, 80, 110, true, true);
        CreateWeaponArray(Revolvers, 1500, "Revolver", 40, 3, 85, 90, 90, true, true);
        CreateWeaponArray(Negets, 5000, "Neget", 110, 20, 100, 100, 120, true, true);
        CreateWeaponArray(SVKinetics, 6000, "SV Kinetik", 120, 20, 110, 110, 120, true, true);
        CreateWeaponArray(BaseballBats, 50, "Baseball Bat", 10, 10, 15, 25, 10, true, false);
        CreateWeaponArray(PoliceJops, 150, "Police Jop", 15, 10, 20, 30, 15, true, false);
        CreateWeaponArray(Knifes, 25, "Knife", 70, 1, 5, 30, 30, true, false);
        CreateWeaponArray(MeatBlades, 75, "Meat Blade", 60, 5, 10, 40, 50, true, false);
        CreateWeaponArray(Axes, 175, "Axe", 0, 10, 60, 70, 110, true, false);
        CreateWeaponArray(KnuckleDusters, 125, "Knuckle Duster", 80, 1, 25, 50, 80, true, false);
    }
    #endregion
    #region Creating:Gears
    private void CreateGearArray(List<Gear> gearList, uint price, string name, byte policeInterest, ushort volume, byte intelligence, byte stealth, byte handiness, byte tech, byte transport, byte connection, byte farmer, byte lab, bool isElectronic, bool isDriftActive)
    {
        for (int i = 0; i < ItemCreationSettings.AMOUT_OF_EACH_ITEM; i++)
        {
            Gear gear = new Gear();

            gear.Name = name;
            gear.SerialNumber = GenerateSerialNumber();
            gear.Durability = GenerateDurability();
            gear.PoliceInterest = policeInterest;
            gear.Volume = volume;
            gear.Price = price;
            gear.OwnerPlayer = null;
            gear.OwnerNPC = null;

            gear.IntelligenceLevel = SelectByteStatForItems(intelligence, isDriftActive);
            gear.StealthLevel = SelectByteStatForItems(stealth, isDriftActive);
            gear.HandinessLevel = SelectByteStatForItems(handiness, isDriftActive);
            gear.TechLevel = SelectByteStatForItems(tech, isDriftActive);
            gear.TransporterLevel = SelectByteStatForItems(transport, isDriftActive);
            gear.ConnectionLevel = SelectByteStatForItems(connection, isDriftActive);
            gear.FarmerLevel = SelectByteStatForItems(farmer, isDriftActive);
            gear.LabLevel = SelectByteStatForItems(lab, isDriftActive);
            gear.IsElectronic = isElectronic;

            gearList.Add(gear);
        }
    }
    public void CREATEGEARS()
    {
        CreateGearArray(AssistantAIs, 25000, "Assistant AI", 0, 0, 100, 0, 50, 75, 0, 0, 0, 0, true, true);
        CreateGearArray(RadioLevelJammers, 2000, "Radio Level Jammer", 5, 1, 0, 50, 0, 0, 10, 0, 0, 0, true, true);
        CreateGearArray(WhiteNoiseMakers, 1500, "White Noise Maker", 5, 1, 0, 50, 0, 0, 0, 0, 0, 0, true, true);
        CreateGearArray(PoliceRadioListeners, 1500, "Police Radio Jammer", 0, 2, 0, 25, 0, 0, 50, 0, 0, 0, true, true);
        CreateGearArray(LANBlockadeSoftwares, 0, "LAN Blockader", 0, 0, 0, 50, 0, 0, 0, 0, 0, 0, false, false);
        CreateGearArray(SurveilanceBlockadeSoftwares, 0, "Surveilance Interrupter", 0, 0, 0, 75, 0, 0, 0, 0, 0, 0, false, false);
        CreateGearArray(BurnerPhones, 20, "Burner Phone", 10, 1, 0, 0, 0, 0, 30, 50, 0, 0, true, true);
        CreateGearArray(ClosedWebAccess, 0, "Closed Web Access", 30, 0, 0, 5, 0, 0, 0, 75, 0, 0, false, false);
        CreateGearArray(Earphones, 250, "Earphone", 5, 1, 0, 10, 10, 10, 10, 0, 0, 10, true, true);
        CreateGearArray(NightVisions, 2000, "Nightvision", 20, 2, 0, 25, 25, 0, 0, 0, 0, 0, true, true);
        CreateGearArray(WeldingMasks, 300, "Welding Mask", 0, 3, 0, 20, 40, 0, 0, 0, 0, 0, false, true);
        CreateGearArray(Drills, 750, "Drill", 20, 4, 0, 0, 60, 0, 0, 0, 0, 0, true, true);
        CreateGearArray(HeavyDrills, 2500, "Heavy Drill", 40, 6, 0, 0, 80, 0, 0, 0, 0, 0, true, true);
        CreateGearArray(Cutters, 300, "Metal Cutter", 10, 1, 0, 0, 40, 0, 0, 0, 0, 0, false, true);
        CreateGearArray(HeavyCutters, 2000, "Heavy Metal Cutter", 0, 3, 0, 0, 60, 0, 0, 0, 0, 0, false, false);
        CreateGearArray(Laptops, 750, "Laptop", 0, 2, 25, 0, 25, 75, 25, 50, 0, 75, true, true);
        CreateGearArray(LabEquipments, 5000, "Lab Equipments", 110, 40, 0, 0, 0, 0, 0, 0, 0, 85, false, true);
        CreateGearArray(AdvencedLabEquipments, 25000, "Advenced Lab Equipments", 110, 60, 0, 0, 0, 0, 0, 0, 0, 120, false, true);
        CreateGearArray(GardeningTools, 2000, "Gardening Tools", 0, 2, 0, 0, 0, 0, 0, 0, 85, 0, false, true);
        CreateGearArray(AdvencedGardeningTools, 15000, "Advenced Gardening Tools", 0, 6, 0, 0, 0, 0, 0, 0, 120, 0, false, false);
    }
    #endregion
    #region Creating:Explosives
    private void CreateExplosiveArray(List<Explosive> explosiveList, string name, byte policeInterest, ushort volume, uint price, ushort power)
    {
        for (int i = 0; i < ItemCreationSettings.AMOUT_OF_EACH_ITEM; i++)
        {
            Explosive explosive = new Explosive();

            explosive.Name = name;
            explosive.SerialNumber = GenerateSerialNumber();
            explosive.Durability = GenerateDurability();
            explosive.PoliceInterest = policeInterest;
            explosive.Volume = volume;
            explosive.Price = price;
            explosive.OwnerPlayer = null;
            explosive.OwnerNPC = null; ;

            explosive.ExplosivePower = power;

            explosiveList.Add(explosive);
        }
    }
    public void CREATEEXPLOSIVES()
    {
        CreateExplosiveArray(TNTs, "TNT", 100, 4, 5000, 10000);
        CreateExplosiveArray(C4s, "C4", 100, 1, 10000, 15000);
        CreateExplosiveArray(Dynamites, "Dynamite", 2, 110, 15000, 13000);
        CreateExplosiveArray(PETNs, "PETN", 120, 1, 80000, 20000);
        CreateExplosiveArray(HMXs, "HMX", 120, 1, 100000, 25000);
    }
    #endregion
    #region Creating:Clothings
    private void CreateClothingArray(List<Clothing> clothingList, byte layer, string name, ushort volume, uint price, byte armor, byte intimidation, byte policeInterest, byte business, byte charm, byte stealth, byte handiness, byte tech, byte farmer, byte lab, byte moneylaundering, byte lawyering, bool isDriftActive)
    {
        for (int i = 0; i < ItemCreationSettings.AMOUT_OF_EACH_ITEM; i++)
        {
            Clothing clothing = new Clothing();

            clothing.Name = name;
            clothing.SerialNumber = GenerateSerialNumber();
            clothing.Durability = GenerateDurability();
            clothing.PoliceInterest = policeInterest;
            clothing.Volume = volume;
            clothing.Price = price;
            clothing.OwnerPlayer = null;
            clothing.OwnerNPC = null;

            clothing.ArmorLevel = armor;
            clothing.IntimidationLevel = SelectByteStatForItems(intimidation, isDriftActive);
            clothing.BusinessLevel = SelectByteStatForItems(business, isDriftActive);
            clothing.CharmLevel = SelectByteStatForItems(charm, isDriftActive);
            clothing.StealthLevel = SelectByteStatForItems(stealth, isDriftActive);
            clothing.HandinessLevel = SelectByteStatForItems(handiness, isDriftActive);
            clothing.TechLevel = SelectByteStatForItems(tech, isDriftActive);
            clothing.FarmerLevel = SelectByteStatForItems(farmer, isDriftActive);
            clothing.LabLevel = SelectByteStatForItems(lab, isDriftActive);
            clothing.MoneyLaunderingLevel = SelectByteStatForItems(moneylaundering, isDriftActive);
            clothing.LawyeringLevel = SelectByteStatForItems(lawyering, isDriftActive);

            //Clothing Mechanism
            switch (layer)
            {
                case 0:
                    clothing.IsOnHead = true;
                    break;
                case 1:
                    clothing.IsAGlasses = true;
                    break;
                case 2:
                    clothing.IsOnBody = true;
                    break;
                case 3:
                    clothing.IsOnTopBody = true;
                    break;
                case 4:
                    clothing.IsOnLegs = true;
                    break;
                case 5:
                    clothing.IsOnFeet = true;
                    break;
                default:
                    clothing.IsOnBody = true;
                    break;
            }

            clothingList.Add(clothing);
        }
    }
    public void CREATECLOTHINGS()
    {
        CreateClothingArray(Balaclavas, 0, "Balaclava",
            1, 20, 0, 75, 100, 0, 0, 50, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(SkiMasks, 0, "Ski Mask",
            1, 50, 0, 75, 90, 0, 0, 80, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(HockeyMasks, 0, "Hockey Mask",
            1, 75, 3, 90, 100, 0, 0, 80, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(SunGlasses, 1, "Sun Glasses",
            1, 250, 0, 50, 0, 75, 75, 0, 0, 0, 0, 0, 20, 20, true);
        CreateClothingArray(TacticalGoggles, 1, "Tactical Goggle",
            1, 700, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(TacticalHelmets, 0, "Tactical Helmet",
            2, 2000, 50, 50, 75, 0, 25, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(TShirts, 2, "T-Shirt",
            1, 100, 2, 0, 0, 10, 20, 10, 20, 20, 20, 20, 10, 10, true);
        CreateClothingArray(CargoTops, 2, "Cargo Top",
            3, 250, 5, 0, 15, 0, 0, 30, 40, 0, 30, 0, 0, 0, true);
        CreateClothingArray(TacticalTops, 2, "Tactical Top",
            4, 4500, 50, 25, 50, 0, 0, 30, 20, 0, 0, 0, 0, 0, true);
        CreateClothingArray(Suits, 2, "Suit",
            1, 1500, 0, 25, 0, 100, 100, 0, 0, 0, 0, 0, 100, 100, true);
        CreateClothingArray(LabUniforms, 2, "Lab Uniform",
            1, 500, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100, 0, 0, true);
        CreateClothingArray(BulletproofVests, 3, "Bulletproof Vest",
            4, 2500, 50, 0, 90, 0, 0, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(KevlarArmors, 3, "Kevlar Armor",
            4, 4000, 70, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(CeramicArmors, 3, "Ceramic Armor",
            4, 5000, 80, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(SteelArmors, 3, "Steel Armor",
            6, 10000, 100, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(SuitPants, 4, "Suit Pant",
            1, 500, 0, 0, 0, 50, 50, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(KevlarPants, 4, "Kevlar Pant",
            2, 2000, 50, 0, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, true);
        CreateClothingArray(CargoPants, 4, "Cargo Pant",
            2, 150, 5, 0, 15, 0, 0, 25, 50, 0, 40, 0, 0, 0, true);
        CreateClothingArray(TacticalBottoms, 4, "Tactical Bottom",
            3, 2000, 50, 25, 50, 0, 0, 20, 30, 0, 0, 0, 0, 0, true);
        CreateClothingArray(MilitaryBoots, 5, "Military Boots",
            1, 200, 50, 20, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, true);
        CreateClothingArray(SuitShoes, 5, "Suit Shoes",
            1, 250, 0, 0, 0, 50, 50, 0, 0, 0, 0, 0, 50, 50, true);
    }
    #endregion
    #region Creating:Bags
    private void CreateBagArray(List<Bag> bagList, string name, byte policeInterest, ushort volume, uint price, ushort capacity, bool isWearableOnBack)
    {
        for (int i = 0; i < ItemCreationSettings.AMOUT_OF_EACH_ITEM; i++)
        {
            Bag bag = new Bag();

            bag.Name = name;
            bag.SerialNumber = GenerateSerialNumber();
            bag.Durability = GenerateDurability();
            bag.PoliceInterest = policeInterest;
            bag.Volume = volume;
            bag.Price = price;
            bag.OwnerPlayer = null;
            bag.OwnerNPC = null;

            bag.IsWearableOnBack = isWearableOnBack;
            bag.VolumeCapacity = capacity;

            bagList.Add(bag);
        }
    }
    public void CREATEBAGS()
    {
        CreateBagArray(Backpacks, "Backpack", 10, 4, 50, 15, true);
        CreateBagArray(DuffleBags, "Duffle Bag", 25, 4, 75, 25, true);
        CreateBagArray(SuitCases, "Suit Case", 15, 10, 100, 50, false);
        CreateBagArray(BriefCases, "Brief Case", 0, 3, 150, 6, false);
        CreateBagArray(LaptopBags, "Laptop Bag", 0, 3, 100, 2, false);
    }
    #endregion
    #region Creating:Vehicles
    private void CreateVehicleArray(List<Vehicle> vehicleList, string name, byte policeInterest, ushort volume, uint price, ushort capacity, byte passengerCapacity, byte workFieldIndex, byte speed, byte stealth, bool isDriftActive)
    {
        for (int i = 0; i < ItemCreationSettings.AMOUT_OF_EACH_ITEM; i++)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Name = name;
            vehicle.SerialNumber = GenerateSerialNumber();
            vehicle.Durability = GenerateDurability();
            vehicle.PoliceInterest = policeInterest;
            vehicle.Volume = volume;
            vehicle.Price = price;
            vehicle.OwnerPlayer = null;
            vehicle.OwnerNPC = null;

            vehicle.VolumeCapacity = capacity;
            vehicle.PassengerCapacity = passengerCapacity;
            vehicle.SpeedLevel = SelectByteStatForItems(speed, isDriftActive);
            vehicle.StealthLevel = SelectByteStatForItems(stealth, isDriftActive);

            vehicle.SetVehicleWorkField(workFieldIndex);

            vehicleList.Add(vehicle);
        }
    }
    public void CREATEVEHICLES()
    {
        CreateVehicleArray(SakiraSedans, "Sakira Sedan", 10, 100, 15000, 100, 3, 0, 100, 80, true);
        CreateVehicleArray(SakiraPickups, "Sakira Pickup", 15, 125, 15000, 400, 1, 0, 80, 50, true);
        CreateVehicleArray(SakiraPanelVans, "Sakira PV", 15, 125, 10000, 200, 1, 0, 70, 25, true);
        CreateVehicleArray(SakiraBoxTrucks, "Sakira BT", 30, 500, 25000, 800, 2, 0, 50, 0, true);
        CreateVehicleArray(SakiraJetSkis, "Sakira S-JS", 0, 40, 7500, 10, 1, 1, 100, 80, true);
        CreateVehicleArray(SakiraDinghies, "Sakira Dinghie", 50, 50, 10000, 50, 5, 1, 80, 80, true);
        CreateVehicleArray(SakiraSailboats, "Sakira Sail Boat", 0, 250, 250000, 300, 9, 1, 40, 0, true);
        CreateVehicleArray(SakiraSpeedBoats, "Sakira S-SB", 0, 150, 50000, 150, 1, 1, 120, 20, true);
        CreateVehicleArray(SakiraYatch, "Sakira Yatch", 0, 18000, 7500000, 4000, 49, 1, 10, 0, true);
        CreateVehicleArray(SakiraSingleEnginePlanes, "Sakira A-SEP", 10, 200, 30000, 150, 1, 2, 100, 25, true);
        CreateVehicleArray(SakiraTwoEnginePlanes, "Sakira A-TEP", 10, 300, 300000, 200, 3, 2, 120, 25, true);
        CreateVehicleArray(SakiraBusinessJets, "Sakira A-BJ", 0, 700, 20000000, 800, 9, 2, 120, 50, true);
        CreateVehicleArray(SakiraSingleEngineHelicopters, "Sakira A-SEH", 0, 300, 1000000, 300, 3, 2, 110, 50, true);
        CreateVehicleArray(SakiraTwoEngineHelicopters, "Sakira A-TEH", 0, 350, 5000000, 350, 3, 2, 120, 50, true);
    }
    #endregion

    #region Creating:Custom Item
    public static void CreateCustomItems()
    {
        //Custom items gonna be builded in here
    }
    #endregion

    #region Executions
    public void ExecuteItemStartup()
    {
        CREATEWEAPONS();
        CREATEGEARS();
        CREATEEXPLOSIVES();
        CREATECLOTHINGS();
        CREATEBAGS();
        CREATEVEHICLES();
    }
    #endregion
}