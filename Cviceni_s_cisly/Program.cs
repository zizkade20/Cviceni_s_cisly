using System.Runtime.Intrinsics.Arm;

Random rnd = new Random();
int n = rnd.Next(10, 13);

string f = n.ToString();


int soucet = 0;
int faktorial = 1;

// SOUCET --------------
for (int j = 0; j <= n; j++)
{
    soucet = soucet + j;
}

// FAKTORIAL --------------


for (int i = 1; i <= n; i++)
{
    faktorial = faktorial * i;
}

// ODMOCNINA

double odm = 0;

for (int z = n; z > 0; z--)
{

    odm = (double)Math.Sqrt((int)z);

    if (odm % 1 == 0)
    {
        odm = z;
        break;
    }
    
}
// POZPATKU

string stringPozpatku = string.Empty;
for (int i = f.Length - 1; i >= 0; i--)
{
    stringPozpatku += f[i];
}


// CIFERNY SOUCET --------------

int sum = 0;
while (n != 0)
{
    sum += n % 10;
    n /= 10;
}

// JEDNICKY

string str = f;
int countO = str.Split('1').Length - 1;

Console.WriteLine("n = " + f);
Console.WriteLine("soucet: " + soucet);
Console.WriteLine("Faktorial: " + faktorial);
Console.WriteLine("Odmocnina: " + Math.Sqrt(odm));
Console.WriteLine("ciferný součet: " + sum);
Console.WriteLine("Pocet jednicek v n: " + countO.ToString());
Console.WriteLine($"Pozpatku: {stringPozpatku} ");


/*
String str = f;
Char value = '1';
StringComparison comp = StringComparison.OrdinalIgnoreCase;
Boolean result = str.Contains(value, comp);
Console.WriteLine($"Počet jedniček v n: {result}");
*/
