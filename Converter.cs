namespace knightmoves;

public class Converter{
   //Add your code here
   public double ConvertImplicitly(int intValue){
      double doubleValue = intValue;
      return doubleValue;
   }

   public int ConvertExplicitly(double doubleValue2)
   {
      int intValue2 = (int)doubleValue2;
      return intValue2;
   }
   public string ConvertToString(decimal value1, double value2)
   {
      return $"{value1} {value2}";
   }

   public double ConvertDecimalToDouble(decimal value)
   {
      return (double)value;
   }
}