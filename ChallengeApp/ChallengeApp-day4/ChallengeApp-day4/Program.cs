//Deklaracja zmiennych
string name = "Ewa";
string sex = "Kobieta";
int age = 29;

if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa,lat 33");
}

else if (sex == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

else if (name == "Mirek" && sex == "mężczyzna" && age == 41)
{
    Console.WriteLine("Mirek jest wysokim meżczyzną");
}