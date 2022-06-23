namespace ExtensionMethodsDemo;

public static class IntExtension
{
    public static int Pow(this int num, int exp)
    {
        return (int)Math.Pow(num, exp);        
    }


    public static string ConcatTwoNumsToStr(this int num,int num2,string str)
    {
        return $"{num} - {str} - {num2}";
    }



}
