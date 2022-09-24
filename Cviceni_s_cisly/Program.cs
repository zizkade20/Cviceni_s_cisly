
Random rnd = new Random();
int n = rnd.Next(10, 13);

string f = n.ToString();


int soucet = 0;
int faktorial = 1;
int odmocnina;
int cifsou = 0;
int jedna;
int pozpatku;

// SOUCET --------------
for (int j = 1; j < n; j++)
{
    soucet += n;
}

// FAKTORIAL --------------

for (int i = 1; i <= n; i++)
{
    faktorial = faktorial * i;
}

Console.WriteLine("n = " + f);
Console.WriteLine("soucet: " + soucet);
Console.WriteLine("Faktorial: " + faktorial);



// POZPATKU

string stringPozpatku = string.Empty;
for (int i = f.Length - 1; i >= 0; i--)
{
    stringPozpatku += f[i];
}



// CIFERNY SOUCET --------------

int suma = 0;
while (n != 0)
{
    suma += n % 10;
    n /= 10;
}
Console.WriteLine("ciferný součet: " + suma);

Console.Write($"Pozpatku: {stringPozpatku} ");




