using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OutputController;

public class DrugStorage
{
    #region Declerations:DrugCurrencies
    public static Methamphetamine MethamphetamineCurrency = new Methamphetamine(0f);
    public static MethamphetamineSupply MethamphetamineSupplyCurrency = new MethamphetamineSupply(0f);
    public static Cocain CocainCurrency = new Cocain(0f);
    public static CocainSupply CocainSupplyCurrency = new CocainSupply(0f);
    public static CocainSeed CocainSeedCurrency = new CocainSeed(0f);
    public static Weed WeedCurrency = new Weed(0f);
    public static WeedSupply WeedSupplyCurrency = new WeedSupply(0f);
    public static WeedSeed WeedSeedCurrency = new WeedSeed(0f);
    public static MDMA MDMACurrency = new MDMA(0f);
    public static MDMASupply MDMASupplyCurrency = new MDMASupply(0f);
    #endregion

    #region Method:DrugCurrencyCreator
    private void CreateDrugCurrencyForCity(City city)
    {
        MethamphetamineCurrency.PricesByCountries.Add(city, SelectMethPrice());
        CocainCurrency.PricesByCountries.Add(city, SelectCocainPrice());
        WeedCurrency.PricesByCountries.Add(city, SelectWeedPrice());
        MDMACurrency.PricesByCountries.Add(city, SelectMDMAPrice());
    }
    private void CreateDrugSupplyCurrencyForCity(City city)
    {
        MethamphetamineSupplyCurrency.PriceByCountries.Add(city, SelectMethSupplyPrice());
        CocainSupplyCurrency.PriceByCountries.Add(city, SelectCocainSupplyPrice());
        WeedSupplyCurrency.PriceByCountries.Add(city, SelectWeedSupplyPrice());
        MDMASupplyCurrency.PriceByCountries.Add(city, SelectMDMASupplyPrice());
    }
    private void CreateDrugSeedCurrencyForCity(City city)
    {
        WeedSeedCurrency.PriceByCountries.Add(city, SelectWeedSeedPrice());
        CocainSeedCurrency.PriceByCountries.Add(city, SelectCocainSeedPrice());
    }
    #endregion
    #region Tools:Price Selectors
    private uint SelectMethPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_METH, DrugRules.MAX_PRICE_METH));
    }
    private uint SelectMethSupplyPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_METH_SUPPLY, DrugRules.MAX_PRICE_METH_SUPPLY));
    }
    private uint SelectCocainPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_COCAIN, DrugRules.MAX_PRICE_COCAIN));
    }
    private uint SelectCocainSupplyPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_COCAIN_SUPPLY, DrugRules.MAX_PRICE_COCAIN_SUPPLY));
    }
    private uint SelectCocainSeedPrice()
    {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_COCAIN_SEED, DrugRules.MAX_PRICE_COCAIN_SEED));
    }
    private uint SelectWeedPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_WEED, DrugRules.MAX_PRICE_WEED));
    }
    private uint SelectWeedSupplyPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_WEED_SUPPLY, DrugRules.MAX_PRICE_WEED_SUPPLY));
    }
    private uint SelectWeedSeedPrice()
    {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_WEED_SEED, DrugRules.MAX_PRICE_WEED_SEED));
    }
    private uint SelectMDMAPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_MDMA, DrugRules.MAX_PRICE_MDMA));
    }
    private uint SelectMDMASupplyPrice() {
        return Convert.ToUInt(Random.Range(DrugRules.MIN_PRICE_MDMA_SUPPLY, DrugRules.MAX_PRICE_MDMA_SUPPLY));
    }
    #endregion

    #region Executions
    public void ExecuteDrugStartUp()
    {
        List<City> tempCities = LocationStorage.TakeTempCities();

        foreach (City city in tempCities)
        {
            CreateDrugCurrencyForCity(city);
            CreateDrugSupplyCurrencyForCity(city);
            CreateDrugSeedCurrencyForCity(city);
        }
    }
    #endregion
}
