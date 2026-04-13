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
}