using UnitConverterLibrary;
using UnitConverterLibrary.UnitsTypes;

namespace UnitConverterTest
{
    public class UnitConverterTests
    {
        [Theory]
        [InlineData( 2, WeightUnit.KgToG, 2000 )]
        [InlineData( 2000, WeightUnit.GToKg, 2 )]
        public void ConvertWeight_ShouldReturnCorrectValues( double input, WeightUnit unit, double expected )
        {
            double result = UnitConverter.Convert(input, unit);
            Assert.Equal( expected, result, precision: 4 ); // tolerance na 4 desetinná místa
        }

        [Theory]
        [InlineData( 1.5, VolumeUnit.LToMl, 1500 )]
        [InlineData( 1500, VolumeUnit.MlToL, 1.5 )]
        public void ConvertVolume_ShouldReturnCorrectValues( double input, VolumeUnit unit, double expected )
        {
            double result = UnitConverter.Convert(input, unit);
            Assert.Equal( expected, result, precision: 4 );
        }

        [Theory]
        [InlineData( 3000, LengthUnit.MToKm, 3 )]
        public void ConvertLength_ShouldReturnCorrectValues( double input, LengthUnit unit, double expected )
        {
            double result = UnitConverter.Convert(input, unit);
            Assert.Equal( expected, result, precision: 4 );
        }
    }
}
