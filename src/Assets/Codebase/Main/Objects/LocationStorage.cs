using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OutputController;

public class LocationStorage
{
    #region Declerations:Continents
    public static Continent NorthAmerica = new Continent("North America", true);
    public static Continent SouthAmerica = new Continent("South America", true);
    public static Continent Africa = new Continent("Africa", true);
    public static Continent Europe = new Continent("Europe", true);
    public static Continent Asia = new Continent("Asia", true);
    public static Continent Ocenia = new Continent("Ocenia", false);
    #endregion
    #region Declarations:Countries
    public static Country USA = new Country(NorthAmerica, "U.S.A.", true, true);
    public static Country England = new Country(Europe, "England", true, false);
    public static Country Germany = new Country(Europe, "Germany", true, false);
    public static Country France = new Country(Europe, "France", true, false);
    public static Country Turkey = new Country(Asia, "Turkey", true, false);
    public static Country China = new Country(Asia, "China", true, true);
    public static Country Japan = new Country(Asia, "Japan", true, true);
    public static Country Mexico = new Country(NorthAmerica, "Mexico", true, false);
    public static Country Brazil = new Country(SouthAmerica, "Brazil", true, false);
    public static Country Argentina = new Country(SouthAmerica, "Argentina", true, false);
    public static Country Spain = new Country(Europe, "Spain", true, false);
    public static Country Italy = new Country(Europe, "Italy", true, false);
    public static Country Russia = new Country(Europe, "Russia", true, true);
    public static Country Poland = new Country(Europe, "Poland", true, false);
    public static Country Romania = new Country(Europe, "Romania", true, false);
    public static Country India = new Country(Asia, "India", true, true);
    public static Country Columbia = new Country(SouthAmerica, "Columbia", true, false);
    #endregion
    #region Declerations:Cities
    public static City NewYorkCity = new City(USA, "New York City", true);
    public static City LosAngeles = new City(USA, "Los Angeles", true);
    public static City WhiteHaven = new City(USA, "White Haven", false);
    public static City Marfa = new City(USA, "Marfa", false);

    public static City London = new City(England, "London", true);
    public static City Manchester = new City(England, "Manchester", true);
    public static City StMadoes = new City(England, "St Madoes", false);
    public static City Clehonger = new City(England, "Clehonger", false);

    public static City Berlin = new City(Germany, "Berlin", true);
    public static City Munich = new City(Germany, "Munich", true);
    public static City Nienhorst = new City(Germany, "Nienhorst", false);
    public static City Andelfingen = new City(Germany, "Andelfingen", false);

    public static City Paris = new City(France, "Paris", true);
    public static City Lyon = new City(France, "Lyon", true);
    public static City Marambat = new City(France, "Marambat", false);
    public static City Margerie = new City(France, "Margerie", false);

    public static City Istanbul = new City(Turkey, "Ýstanbul", true);
    public static City Ankara = new City(Turkey, "Ankara", true);
    public static City PirincCesme = new City(Turkey, "Pirinç Çeþme", false);
    public static City Denizkent = new City(Turkey, "Denizkent", false);

    public static City Beijing = new City(China, "Beijing", true);
    public static City Shangai = new City(China, "Shangai", true);
    public static City Yantan = new City(China, "Yantan", false);
    public static City Wuxuzhen = new City(China, "Wuxuzhen", false);

    public static City Tokyo = new City(Japan, "Tokyo", true);
    public static City Osaka = new City(Japan, "Osaka", true);
    public static City Iki = new City(Japan, "Iki", false);
    public static City Honbetsu = new City(Japan, "Honbetsu", false);

    public static City MexicoCity = new City(Mexico, "Mexico City", true);
    public static City Guadalajara = new City(Mexico, "Guadalajara", true);
    public static City Namiquipa = new City(Mexico, "Namiquipa", false);
    public static City TresPicos = new City(Mexico, "Tres Picos", false);

    public static City SaoPaulo = new City(Brazil, "Sao Paulo", true);
    public static City RioDeJaneiro = new City(Brazil, "Rio De Janeiro", true);
    public static City VendaDasFlores = new City(Brazil, "Venda das Flores", false);
    public static City Brejo = new City(Brazil, "Brejo", false);

    public static City BuenosAires = new City(Argentina, "Buenos Aires", true);
    public static City Cordoba = new City(Argentina, "Cordoba", true);
    public static City PuntaBandera = new City(Argentina, "Punta Bandera", false);
    public static City Monteagudo = new City(Argentina, "Monteagudo", false);

    public static City Madrid = new City(Spain, "Madrid", true);
    public static City Barcelona = new City(Spain, "Barcelona", true);
    public static City Ribota = new City(Spain, "Ribota", false);
    public static City Parauta = new City(Spain, "Parauta", false);

    public static City Rome = new City(Italy, "Rome", true);
    public static City Milan = new City(Italy, "Milan", true);
    public static City Ragoli = new City(Italy, "Ragoli", false);
    public static City Mammola = new City(Italy, "Mammola", false);

    public static City Moscow = new City(Russia, "Moscow", true);
    public static City StPetersburg = new City(Russia, "Saint Petersburg", true);
    public static City KuduKyuyol = new City(Russia, "Kudu-Kyuyol", false);
    public static City Oma = new City(Russia, "Oma", false);

    public static City Warsaw = new City(Poland, "Warsaw", true);
    public static City Krakow = new City(Poland, "Krakow", true);
    public static City Rumsko = new City(Poland, "Rumsko", false);
    public static City Grodek = new City(Poland, "Grodek", false);

    public static City Bucharest = new City(Romania, "Bucharest", true);
    public static City ClujNapoca = new City(Romania, "Cluj-Napoca", true);
    public static City Rusca = new City(Romania, "Rusca", false);
    public static City Pomarla = new City(Romania, "Pomarla", false);

    public static City Mumbai = new City(India, "Mumbai", true);
    public static City Delhi = new City(India, "Delhi", true);
    public static City Gandhvi = new City(India, "Gandhvi", false);
    public static City Muttom = new City(India, "Muttom", false);

    public static City Bogota = new City(Columbia, "Bogota", true);
    public static City Medellin = new City(Columbia, "Medellin", true);
    public static City Mitu = new City(Columbia, "Mitu", false);
    public static City Jurado = new City(Columbia, "Jurado", false);
    #endregion
    #region Declerations:Places
    public static List<Business> Businesses = new List<Business>();
    public static List<RealEstate> RealEstates = new List<RealEstate>();
    public static List<Warehouse> Warehouses = new List<Warehouse>();
    public static List<ProductionLot> ProductionLots = new List<ProductionLot>();
    public static List<Bank> Banks = new List<Bank>();
    public static List<ArtGallery> ArtGalleries = new List<ArtGallery>();
    public static List<CarGallery> CarGalleries = new List<CarGallery>();
    #endregion

    // *IMPORTANT* If you manually added new countries or cities, you need to add them to this methods too
    #region Declerations (Temporary):Countries, Cities
    public static List<Country> TakeTempCountries() {
        List<Country> list = new List<Country> {
            USA,
            England,
            Germany,
            France,
            Turkey,
            China,
            Japan,
            Mexico,
            Brazil,
            Argentina,
            Spain,
            Italy,
            Russia,
            Poland,
            Romania,
            India,
            Columbia
        };

        return list;
    }
    public static List<City> TakeTempCities() {
        List<City> list = new List<City> {
            NewYorkCity,
            LosAngeles,
            WhiteHaven,
            Marfa,

            London,
            Manchester,
            StMadoes,
            Clehonger,

            Berlin,
            Munich,
            Nienhorst,
            Andelfingen,

            Paris,
            Lyon,
            Marambat,
            Margerie,

            Istanbul,
            Ankara,
            PirincCesme,
            Denizkent,

            Beijing,
            Shangai,
            Yantan,
            Wuxuzhen,

            Tokyo,
            Osaka,
            Iki,
            Honbetsu,

            MexicoCity,
            Guadalajara,
            Namiquipa,
            TresPicos,

            SaoPaulo,
            RioDeJaneiro,
            VendaDasFlores,
            Brejo,

            BuenosAires,
            Cordoba,
            PuntaBandera,
            Monteagudo,

            Madrid,
            Barcelona,
            Ribota,
            Parauta,

            Rome,
            Milan,
            Ragoli,
            Mammola,

            Moscow,
            StPetersburg,
            KuduKyuyol,
            Oma,

            Warsaw,
            Krakow,
            Rumsko,
            Grodek,

            Bucharest,
            ClujNapoca,
            Rusca,
            Pomarla,

            Mumbai,
            Delhi,
            Gandhvi,
            Muttom,

            Bogota,
            Medellin,
            Mitu,
            Jurado
        };

        return list;
    }
    #endregion

    #region Methods:PlaceAmounts
    private ushort NewPlaceAmount(City city)
    {
        ushort placeAmount = LocationCreationSettings.MIN_EACH_PLACE_AMOUNT_FOR_BIG_CITY;
        float amountMultiplier = Random.Range(LocationCreationSettings.MIN_AMOUNT_DRIFT_MULTIPLIER, LocationCreationSettings.MAX_AMOUNT_DRIFT_MULTIPLIER);

        //Amount controller
        if (!city.IsHighlyPopulated)
        {
            placeAmount = LocationCreationSettings.MIN_EACH_PLACE_AMOUNT_FOR_SMALL_CITY;
        }

        placeAmount = Convert.ToUShort(placeAmount * amountMultiplier);

        return placeAmount;
    }
    private ushort NewRobbablePlaceAmount(City city)
    {
        ushort robbablePlaceAmount = LocationCreationSettings.MIN_EACH_ROBBABLE_PLACE_AMOUNT_FOR_BIG_CITY;
        float amountMultiplier = Random.Range(LocationCreationSettings.MIN_AMOUNT_DRIFT_MULTIPLIER, LocationCreationSettings.MAX_AMOUNT_DRIFT_MULTIPLIER);

        robbablePlaceAmount = Convert.ToUShort(robbablePlaceAmount * amountMultiplier);

        return robbablePlaceAmount;
    }
    #endregion
    #region Methods:ToolsForFillingPlaces
    private Weapon SelectGunForSecurity(string weaponName)
    {
        Weapon weapon = new Weapon();
        switch (weaponName)
        {
            case "M40":
                weapon = ItemStorage.M40s[System.Convert.ToInt32(Random.Range(1, ItemStorage.M40s.Count))];
                return weapon;
            case "SMG":
                weapon = ItemStorage.SMGs[System.Convert.ToInt32(Random.Range(1, ItemStorage.SMGs.Count))];
                return weapon;
            default:
                weapon = ItemStorage.Glotks[System.Convert.ToInt32(Random.Range(1, ItemStorage.Glotks.Count))];
                return weapon;
        }
    }
    #endregion

    #region Methods:FillingTheCities
    private void FillThisCity(City city)
    {
        ushort placeAmount = NewPlaceAmount(city);
        ushort robbablePlaceAmount = NewRobbablePlaceAmount(city);

        //Businesses
        if (city.IsHighlyPopulated)
        {
            for (int i = 0; i < placeAmount; i++)
            {
                Business business = new Business();
                FillBusinessStats(business, city);
                Businesses.Add(business);
            }
        }

        placeAmount = NewPlaceAmount(city);
        //RealEstates
        for (int i = 0; i < placeAmount; i++)
        {
            RealEstate realEstate = new RealEstate();
            FillRealEstateStats(realEstate, city);
            RealEstates.Add(realEstate);
        }

        placeAmount = NewPlaceAmount(city);
        //Warehouses
        for (int i = 0; i < placeAmount; i++)
        {
            Warehouse warehouse = new Warehouse();
            FillWarehouseStats(warehouse, city);
            Warehouses.Add(warehouse);
        }

        if (!city.IsHighlyPopulated)
        {
            placeAmount = NewPlaceAmount(city);
            //Production Lot
            for (int i = 0; i < placeAmount; i++)
            {
                ProductionLot productionLot = new ProductionLot();
                FillProductionLotStats(productionLot, city);
                ProductionLots.Add(productionLot);
            }
        }

        if (!city.IsHighlyPopulated)
        {
            robbablePlaceAmount = NewRobbablePlaceAmount(city);
            //Bank
            for (int i = 0; i < robbablePlaceAmount; i++)
            {
                Bank bank = new Bank();
                FillBankStats(bank, city);
                Banks.Add(bank);
            }

            robbablePlaceAmount = NewRobbablePlaceAmount(city);
            //ArtGallery
            for (int i = 0; i < robbablePlaceAmount; i++)
            {
                ArtGallery artGallery = new ArtGallery();
                FillArtGalleryStats(artGallery, city);
                ArtGalleries.Add(artGallery);
            }

            robbablePlaceAmount = NewRobbablePlaceAmount(city);
            //CarGallery
            for (int i = 0; i < robbablePlaceAmount; i++)
            {
                CarGallery carGallery = new CarGallery();
                FillCarGalleryStats(carGallery, city);
                CarGalleries.Add(carGallery);
            }
        }
    }
    #endregion

    #region Methods:FillingThePlaces
    private void FillBusinessStats(Business business, City city)
    {
        byte TypeIndex = Convert.ToByte(Random.Range(0, BusinessSettings.TYPE_INDEX_MAX));
        float StatMultiplier = Random.Range(BusinessSettings.MIN_STAT_DRIFT_MULTIPLIER, BusinessSettings.MAX_STAT_DRIFT_MULTIPLIER);

        business.Name = BusinessSettings.TYPE_NAME_BY_INDEX[TypeIndex];

        if (Random.Range(0, 101) < 50)
        {
            business.IsHighlyPopulated = true;
        }

        business.Price = Convert.ToUInt(StatMultiplier * BusinessSettings.PRICE_BY_TYPE_INDEX[TypeIndex]);
        business.MonthlyExpense = BusinessSettings.DEFAULT_MONTHLY_EXPENSE;
        business.Address = city;
        business.VolumeCapacity = BusinessSettings.VOLUME_CAPACITY_DEFAULT;

        if (Random.Range(0, 101) < BusinessSettings.CHANCE_TO_HAVE_GARAGE)
        {
            business.IsStorageAcceptingVehicles = true;
            business.VolumeCapacity += BusinessSettings.VOLUME_CAPACITY_DEFAULT;
            business.Price += Convert.ToUInt(BusinessSettings.VOLUME_CAPACITY_DEFAULT * 100);
        }

        business.Income = Convert.ToUInt((BusinessSettings.PRICE_BY_TYPE_INDEX[TypeIndex] * StatMultiplier) / 36);

        if (StatMultiplier > 1.5f)
        {
            business.AccountantCapacity = BusinessSettings.DEFAULT_ACCOUNTANT_AMOUNT * 5;
        }
        else
        {
            business.AccountantCapacity = BusinessSettings.DEFAULT_ACCOUNTANT_AMOUNT;
        }
    }
    private void FillRealEstateStats(RealEstate realEstate, City city)
    {
        float StatMultiplier = Random.Range(RealEstateSettings.MIN_STAT_DRIFT_MULTIPLIER, RealEstateSettings.MAX_STAT_DRIFT_MULTIPLIER);

        realEstate.Name = "Empty House";
        if (city.IsHighlyPopulated)
        {
            realEstate.Name = "Empty Apartment";
        }

        realEstate.Price = Convert.ToUInt(StatMultiplier * RealEstateSettings.PRICE_BIG_CITY);
        if (!city.IsHighlyPopulated)
        {
            realEstate.Price = Convert.ToUInt(StatMultiplier * RealEstateSettings.PRICE_SMALL_CITY);
        }

        realEstate.MonthlyExpense = RealEstateSettings.DEFAULT_MONTHLY_EXPENSE;
        realEstate.Address = city;

        realEstate.VolumeCapacity = RealEstateSettings.VOLUME_CAPACITY_DEFAULT;
        if (Random.Range(0, 101) < RealEstateSettings.CHANCE_TO_HAVE_GARAGE)
        {
            realEstate.IsStorageAcceptingVehicles = true;
            realEstate.VolumeCapacity += RealEstateSettings.VOLUME_CAPACITY_DEFAULT;
            realEstate.Price += Convert.ToUInt(RealEstateSettings.VOLUME_CAPACITY_DEFAULT * 100);
        }

        realEstate.ComfortLevel = Convert.ToByte(RealEstateSettings.DEFAULT_COMFORT_LEVEL * StatMultiplier);
    }
    private void FillWarehouseStats(Warehouse warehouse, City city)
    {
        float StatMultiplier = Random.Range(WarehouseSettings.MIN_STAT_DRIFT_MULTIPLIER, WarehouseSettings.MAX_STAT_DRIFT_MULTIPLIER);

        warehouse.Name = "Warehouse";

        warehouse.Price = Convert.ToUInt(StatMultiplier * WarehouseSettings.PRICE_BIG_CITY);
        if (!city.IsHighlyPopulated)
        {
            warehouse.Price = Convert.ToUInt(StatMultiplier * WarehouseSettings.PRICE_SMALL_CITY);
        }

        warehouse.MonthlyExpense = WarehouseSettings.DEFAULT_MONTHLY_EXPENSE;
        warehouse.Address = city;

        warehouse.VolumeCapacity = Convert.ToUShort(WarehouseSettings.VOLUME_CAPACITY_DEFAULT * StatMultiplier);
    }
    private void FillProductionLotStats(ProductionLot productionLot, City city)
    {
        float StatMultiplier = Random.Range(ProductionLotSettings.MIN_STAT_DRIFT_MULTIPLIER, ProductionLotSettings.MAX_STAT_DRIFT_MULTIPLIER);

        if (Random.Range(0, 101) < 50)
        {
            productionLot.Name = "Farming Field";
            productionLot.IsFarm = true;
            productionLot.Price = Convert.ToUInt(StatMultiplier * ProductionLotSettings.PRICE_FARM);
            productionLot.MonthlyExpense = ProductionLotSettings.MONTHLY_EXPENSE_FARM;
        }
        else
        {
            productionLot.Name = "Producing House";
            productionLot.Price = Convert.ToUInt(StatMultiplier * ProductionLotSettings.PRICE_PRODUCTION_HOUSE);
            productionLot.MonthlyExpense = ProductionLotSettings.MONTHLY_EXPENSE_PRODUCTION_HOUSE;
        }

        productionLot.Address = city;

        productionLot.OutputMultiplier = StatMultiplier * Random.Range(ProductionLotSettings.MIN_OUTPUT_MULTIPLIER, ProductionLotSettings.MAX_OUTPUT_MULTIPLIER);

        productionLot.WorkerCapacity = Convert.ToByte(StatMultiplier * ProductionLotSettings.DEFAULT_WORKER_CAPACITY);
    }
    #endregion

    #region Methods:FillRobbablePlaces //Note: Envelopes and Jewelries are off in "FillRobbablePlaces" section
    private void FillBankStats(Bank bank, City city)
    {
        float StatMultiplier = Random.Range(BankSettings.MIN_STAT_DRIFT_MULTIPLIER, BankSettings.MAX_STAT_DRIFT_MULTIPLIER);

        bank.Name = "Bank";
        bank.Address = city;

        bank.EarlyCivilianAmount = Convert.ToByte(StatMultiplier * BankSettings.DEFAULT_EARLY_CIVILIAN_AMOUNT);
        bank.LateCivilianAmount = Convert.ToByte(StatMultiplier * BankSettings.DEFAULT_LATE_CIVILIAN_AMOUNT);

        bank.IsThereInsider = System.Convert.ToBoolean(Random.Range(0, 2));
        if (!bank.IsThereInsider)
        {
            bank.CivilianInsiderIntimidationCap = Convert.ToShort(StatMultiplier * Random.Range(BankSettings.MIN_CIVILIAN_INSIDER_INTIMIDATION_CAP, BankSettings.MAX_CIVILIAN_INSIDER_INTIMIDATION_CAP));
        }

        bank.SecurityLevel = Convert.ToByte(StatMultiplier * BankSettings.DEFAULT_SECURITY_LEVEL);
        bank.SecurityOfficerAmountWhileOpen = Convert.ToByte(StatMultiplier * BankSettings.DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_OPEN);
        bank.SecurityOfficerAmountWhileClosed = Convert.ToByte(StatMultiplier * BankSettings.DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_CLOSED);
        bank.IsSecurityArmed = true;

        if (StatMultiplier < BankSettings.MIN_STAT_DRIFT_MULTIPLIER + (BankSettings.MIN_STAT_DRIFT_MULTIPLIER / 2))
        {
            bank.SecurityOfficerWeapons = SelectGunForSecurity(" ");
        }
        else if (StatMultiplier < BankSettings.MAX_STAT_DRIFT_MULTIPLIER - (BankSettings.MAX_STAT_DRIFT_MULTIPLIER / 4))
        {
            bank.SecurityOfficerWeapons = SelectGunForSecurity("M40");
        }
        else
        {
            bank.SecurityOfficerWeapons = SelectGunForSecurity("SMG");
        }
        bank.SecurityOfficerWeapons.OwnerPlayer = null;
        bank.SecurityOfficerWeapons.OwnerNPC = null;

        bank.SecurityCameraAmount = Convert.ToByte(StatMultiplier * BankSettings.DEFAULT_SECURITY_CAMERA_AMOUNT);
        bank.PoliceStationDistance = Convert.ToByte(Random.Range(BankSettings.MIN_POLICE_STATION_DISTANCE, BankSettings.MAX_POLICE_STATION_DISTANCE));

        //Unique Stats
        bank.StoredCash = Convert.ToUInt(StatMultiplier * BankSettings.DEFAULT_STORED_CASH);

        bank.IsThereDepositBoxes = System.Convert.ToBoolean(Random.Range(0, 2));

        /*
        if (bank.IsThereDepositBoxes)
        {
            if (Random.Range(0, 101) < BankSettings.CHANCE_TO_HAVE_ENVELOPE)
            {
                Envelope envelope = new Envelope();
                envelope.BlackmarketValue = envelope.OwnerOrganization.Level * EnvelopeSettings.DEFAULT_ENVELOPE_BLACKMARKET_PRICE;
                envelope.BlackmarketInterest = Convert.ToUInt(envelope.OwnerOrganization.InvolvedNPCs.Count);
                bank.Envelope = envelope;
            }

            byte JeweleryAmount = Convert.ToByte(Random.Range(BankSettings.MIN_JEWELRY_AMOUNT, BankSettings.MAX_JEWELRY_AMOUNT));
            Jewelery[] jeweleries = new Jewelery[JeweleryAmount];
            for (int i = 0; i < JeweleryAmount; i++)
            {
                jeweleries[i] = new Jewelery();
            }
            foreach (Jewelery jewelry in jeweleries)
            {
                jewelry.BlackmarketValue = Convert.ToUInt(Random.Range(JewelrySettings.MIN_BLACKMARKET_PRICE, JewelrySettings.MAX_BLACKMARKET_PRICE));
                jewelry.BlackmarketInterest = JewelrySettings.DEFAULT_BLACKMARKET_INTEREST;
                bank.Jeweleries.Add(jewelry);
            }
        }
        */
    }
    private void FillArtGalleryStats(ArtGallery artGallery, City city)
    {
        float StatMultiplier = Random.Range(ArtGallerySettings.MIN_STAT_DRIFT_MULTIPLIER, ArtGallerySettings.MAX_STAT_DRIFT_MULTIPLIER);

        artGallery.Name = "Art Gallery";
        artGallery.Address = city;

        artGallery.EarlyCivilianAmount = Convert.ToByte(StatMultiplier * ArtGallerySettings.DEFAULT_EARLY_CIVILIAN_AMOUNT);
        artGallery.LateCivilianAmount = Convert.ToByte(StatMultiplier * ArtGallerySettings.DEFAULT_LATE_CIVILIAN_AMOUNT);

        artGallery.IsThereInsider = System.Convert.ToBoolean(Random.Range(0, 2));
        if (!artGallery.IsThereInsider)
        {
            artGallery.CivilianInsiderIntimidationCap = Convert.ToShort(StatMultiplier * Random.Range(ArtGallerySettings.MIN_CIVILIAN_INSIDER_INTIMIDATION_CAP, ArtGallerySettings.MAX_CIVILIAN_INSIDER_INTIMIDATION_CAP));
        }

        artGallery.SecurityLevel = Convert.ToByte(StatMultiplier * ArtGallerySettings.DEFAULT_SECURITY_LEVEL);
        artGallery.SecurityOfficerAmountWhileOpen = Convert.ToByte(StatMultiplier * ArtGallerySettings.DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_OPEN);
        artGallery.SecurityOfficerAmountWhileClosed = Convert.ToByte(StatMultiplier * ArtGallerySettings.DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_CLOSED);

        artGallery.IsSecurityArmed = System.Convert.ToBoolean(Random.Range(0, 2));
        if (artGallery.IsSecurityArmed)
        {
            artGallery.SecurityOfficerWeapons = SelectGunForSecurity(" ");
            artGallery.SecurityOfficerWeapons.OwnerPlayer = null;
            artGallery.SecurityOfficerWeapons.OwnerNPC = null;
        }

        artGallery.SecurityCameraAmount = Convert.ToByte(StatMultiplier * ArtGallerySettings.DEFAULT_SECURITY_CAMERA_AMOUNT);
        artGallery.PoliceStationDistance = Convert.ToByte(Random.Range(ArtGallerySettings.MIN_POLICE_STATION_DISTANCE, ArtGallerySettings.MAX_POLICE_STATION_DISTANCE));

        //Unique Stats
        artGallery.StoredArtAmount = Convert.ToByte(StatMultiplier * ArtGallerySettings.DEFAULT_STORED_ART_AMOUNT);
        for (int i = 1; i < artGallery.StoredArtAmount; i++)
        {
            Art art = new Art();
            art.BlackmarketValue = Convert.ToUInt(StatMultiplier * Random.Range(ArtSettings.MIN_BLACKMARKET_PRICE, ArtSettings.MAX_BLACKMARKET_PRICE));
            art.BlackmarketInterest = Convert.ToByte(StatMultiplier * ArtSettings.DEFAULT_BLACKMARKET_INTEREST);
            artGallery.StoredArts.Add(art);
        }
    }
    private void FillCarGalleryStats(CarGallery carGallery, City city)
    {
        float StatMultiplier = Random.Range(CarGallerySettings.MIN_STAT_DRIFT_MULTIPLIER, CarGallerySettings.MAX_STAT_DRIFT_MULTIPLIER);

        carGallery.Name = "Art Gallery";
        carGallery.Address = city;

        carGallery.EarlyCivilianAmount = Convert.ToByte(StatMultiplier * CarGallerySettings.DEFAULT_EARLY_CIVILIAN_AMOUNT);
        carGallery.LateCivilianAmount = Convert.ToByte(StatMultiplier * CarGallerySettings.DEFAULT_LATE_CIVILIAN_AMOUNT);

        carGallery.IsThereInsider = System.Convert.ToBoolean(Random.Range(0, 2));
        if (!carGallery.IsThereInsider)
        {
            carGallery.CivilianInsiderIntimidationCap = Convert.ToShort(StatMultiplier * Random.Range(CarGallerySettings.MIN_CIVILIAN_INSIDER_INTIMIDATION_CAP, CarGallerySettings.MAX_CIVILIAN_INSIDER_INTIMIDATION_CAP));
        }

        carGallery.SecurityLevel = Convert.ToByte(StatMultiplier * CarGallerySettings.DEFAULT_SECURITY_LEVEL);
        carGallery.SecurityOfficerAmountWhileOpen = Convert.ToByte(StatMultiplier * CarGallerySettings.DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_OPEN);
        carGallery.SecurityOfficerAmountWhileClosed = Convert.ToByte(StatMultiplier * CarGallerySettings.DEFAULT_SECURITY_OFFICER_AMOUNT_WHILE_CLOSED);

        carGallery.IsSecurityArmed = true;
        if (carGallery.IsSecurityArmed)
        {
            carGallery.SecurityOfficerWeapons = SelectGunForSecurity(" ");
            carGallery.SecurityOfficerWeapons.OwnerPlayer = null;
            carGallery.SecurityOfficerWeapons.OwnerNPC = null;
        }

        carGallery.SecurityCameraAmount = Convert.ToByte(StatMultiplier * CarGallerySettings.DEFAULT_SECURITY_CAMERA_AMOUNT);
        carGallery.PoliceStationDistance = Convert.ToByte(Random.Range(CarGallerySettings.MIN_POLICE_STATION_DISTANCE, CarGallerySettings.MAX_POLICE_STATION_DISTANCE));

        //Unique Stats
        carGallery.StoredCarAmount = Convert.ToByte(StatMultiplier * CarGallerySettings.DEFAULT_STORED_CAR_AMOUNT);
        for (int i = 1; i < carGallery.StoredCarAmount; i++)
        {
            SportCar sportCar = new SportCar();
            sportCar.BlackmarketValue = Convert.ToUInt(StatMultiplier * Random.Range(SportCarSettings.MIN_BLACKMARKET_PRICE, SportCarSettings.MAX_BLACKMARKET_PRICE));
            sportCar.BlackmarketInterest = Convert.ToByte(StatMultiplier * SportCarSettings.DEFAULT_BLACKMARKET_INTEREST);
            carGallery.StoredSportCars.Add(sportCar);
        }
    }
    #endregion

    #region Methods:Custom Places
    public static void CreateCustomPlaces()
    {
        //Custom places gonna be builded in here
    }
    #endregion

    #region Executions
    public void ExecuteCityStartUp()
    {
        FillThisCity(NewYorkCity);
        FillThisCity(LosAngeles);
        FillThisCity(WhiteHaven);
        FillThisCity(Marfa);

        FillThisCity(London);
        FillThisCity(Manchester);
        FillThisCity(StMadoes);
        FillThisCity(Clehonger);

        FillThisCity(Berlin);
        FillThisCity(Munich);
        FillThisCity(Nienhorst);
        FillThisCity(Andelfingen);

        FillThisCity(Paris);
        FillThisCity(Lyon);
        FillThisCity(Marambat);
        FillThisCity(Margerie);

        FillThisCity(Istanbul);
        FillThisCity(Ankara);
        FillThisCity(PirincCesme);
        FillThisCity(Denizkent);

        FillThisCity(Beijing);
        FillThisCity(Shangai);
        FillThisCity(Yantan);
        FillThisCity(Wuxuzhen);

        FillThisCity(Tokyo);
        FillThisCity(Osaka);
        FillThisCity(Iki);
        FillThisCity(Honbetsu);

        FillThisCity(MexicoCity);
        FillThisCity(Guadalajara);
        FillThisCity(Namiquipa);
        FillThisCity(TresPicos);

        FillThisCity(SaoPaulo);
        FillThisCity(RioDeJaneiro);
        FillThisCity(VendaDasFlores);
        FillThisCity(Brejo);

        FillThisCity(BuenosAires);
        FillThisCity(Cordoba);
        FillThisCity(PuntaBandera);
        FillThisCity(Monteagudo);

        FillThisCity(Madrid);
        FillThisCity(Barcelona);
        FillThisCity(Ribota);
        FillThisCity(Parauta);

        FillThisCity(Rome);
        FillThisCity(Milan);
        FillThisCity(Ragoli);
        FillThisCity(Mammola);

        FillThisCity(Moscow);
        FillThisCity(StPetersburg);
        FillThisCity(KuduKyuyol);
        FillThisCity(Oma);

        FillThisCity(Warsaw);
        FillThisCity(Krakow);
        FillThisCity(Rumsko);
        FillThisCity(Grodek);

        FillThisCity(Bucharest);
        FillThisCity(ClujNapoca);
        FillThisCity(Rusca);
        FillThisCity(Pomarla);

        FillThisCity(Mumbai);
        FillThisCity(Delhi);
        FillThisCity(Gandhvi);
        FillThisCity(Muttom);

        FillThisCity(Bogota);
        FillThisCity(Medellin);
        FillThisCity(Mitu);
        FillThisCity(Jurado);
    }
    #endregion
}
