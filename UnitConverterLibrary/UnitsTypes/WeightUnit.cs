namespace UnitConverterLibrary.UnitsTypes
{
    public enum WeightUnit : int
    {
        KgToG = 1000,
        GToKg = -1000,  // Záporné hodnoty budou znamenat 1 / abs(hodnota)
        LbToKg = -454,  // 0.453592
        KgToLb = 2205   // 2.20462
    }
}
