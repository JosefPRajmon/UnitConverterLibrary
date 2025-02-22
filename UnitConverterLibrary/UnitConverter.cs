namespace UnitConverterLibrary
{
    public static class UnitConverter
    {
        public static double Convert<T>( double value, T unit ) where T : struct, Enum
        {
            return value * unit.GetFactor();
        }
    }
}
