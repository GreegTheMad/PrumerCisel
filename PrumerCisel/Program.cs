string val;
int res;
bool stop = false;
List<int> cisla = new List<int>();

while (stop == false)
    {
    Console.WriteLine("Dej mi cislo (Zadej -STOP- pro výsledek ");
    val = Console.ReadLine();

    if (val == "STOP")
    {
       stop = true;
       break;
    }
    res = Convert.ToInt32(val);
    cisla.Add(res);
}

if (stop == true)
{
    double avg = Queryable.Average(cisla.AsQueryable());
    Console.WriteLine("Průměr = " + avg);
}

Console.ReadKey();
