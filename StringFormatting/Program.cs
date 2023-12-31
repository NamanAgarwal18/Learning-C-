// See https://aka.ms/new-console-template for more information
using System.Text; // For StringBuilder

int[] quaters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] percent = {.386, .413, .421, .457};

string str1 = "Testing String";
int val1 = 1234;
decimal val2 = 1234.5678m;

// Basic Formatting 
Console.WriteLine("\n-------------Basic Formatting------------");
Console.WriteLine("{0}", str1);

/* 
    Format -> {index[,alignment]:[format]} 
    N (Number)
    G (General)
    F (Fixed - Point)
    E (Exponential)
    D (Decimal)
    P (Percent)
    X (Hexadecimal)
    C (Local Currency)
*/
Console.WriteLine("\n-----------Precision Formatting----------");
Console.WriteLine("{0,4} {1,4} | {2,10} | {3,10} | {4,10} | {5,15} | {6,10} | {7,12} | {8,10} | {9,10}", "","    ","N","G","F","E","D","P","X","C");
Console.WriteLine("Val1  ->  | {0,10:N} | {0,10:G} | {0,10:F} | {0,15:E} | {0,10:D} | {0,12:P} | {0,10:X} | {0,10:C}", val1);
Console.WriteLine("Val2  ->  | {0,10:N} | {0,10:G} | {0,10:F} | {0,15:E} | {1,10:D} | {0,12:P} | {1,10:X} | {0,10:C}", val2, "-");


// Now implementing StringBuilder Functions

StringBuilder sb = new StringBuilder("Initial String.",200);
StringBuilder sb1 = new StringBuilder();

Console.WriteLine($"Capacity : {sb.Capacity} , Length : {sb.Length}");
Console.WriteLine($"Capacity : {sb1.Capacity} , Length : {sb1.Length}");
