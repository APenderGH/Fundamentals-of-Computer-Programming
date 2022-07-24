//5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467
class FloatDoubleAndDecimal
{
    static void Main()
    {
        float float1 = 5f;
        float float2  = -5.01f;
        float float3 = 12.345f;
        double double1 = 34.567839023d;
        double double2 = 8923.1234857d;
        decimal decimal1 = 3456.091124875956542151256683467m; 

        Console.WriteLine("{0},\n{1},\n{2},\n{3},\n{4},\n{5}",float1.ToString(), float2.ToString(), float3.ToString(), double1.ToString(), double2.ToString(), decimal1.ToString());

    }
}
