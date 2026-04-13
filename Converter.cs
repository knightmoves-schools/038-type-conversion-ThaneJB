namespace knightmoves;

public class Converter{
   //Add your code here
   public decimal ConvertImplicitly(int intValue){
      decimal decimalValue = intValue;
      return decimalValue;
   }

   public int ConvertExplicitly(decimal decimalValue2)
   {
      int intValue2 = (int)decimalValue2;
      return intValue2;
   }
}