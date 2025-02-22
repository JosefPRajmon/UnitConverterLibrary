namespace UnitConverterLibrary
{
    public static class UnitExtensions
    {
        public static double GetFactor<T>( this T unit ) where T : struct, Enum
        {
            int factor = Convert.ToInt32(unit);
            return factor > 0 ? factor : 1.0 / Math.Abs( factor );
        }
    }
}
