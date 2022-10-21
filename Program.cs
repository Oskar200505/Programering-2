// See https://aka.ms/new-console-template for more information
using lösenord;
/*
using Punkter;

Console.WriteLine("Hello, World!");
// Skapar en loop som skriver ut x och y siffrorna och säkerställer att de inte finns dubbletter,fördjupning 1

Random rnd = new Random();
int x_Kordinaten;
int y_Kordinaten;


for (int x = 0; x < 10; x++)
{

    
    x_Kordinaten = rnd.Next(-10, 10);
    y_Kordinaten = rnd.Next(-10, 10);
    Console.WriteLine("X = " + x_Kordinaten);
    Console.WriteLine("Y = " + y_Kordinaten);
    Console.WriteLine(" ");

    
}

//fördjupning 1

// skapar kordinater
Punkt punkt = new Punkt();
punkt.setX(0);
punkt.setY(0);
Random random = new Random();

// Skapar Array och ställer in stolek 10
Punkt[] arrayPunkter = new Punkt[10];  

// lägger in random i array
for( int i = 0; i < arrayPunkter.Length; i++)
{
    arrayPunkter[i] = new Punkt();
    arrayPunkter[i].setX(random.Next(-10, 10));
    arrayPunkter[i].setY(random.Next(-10, 10));
}

// jämnför x och y med andra x och y 
for(int i = 0; i < arrayPunkter.Length; i++)
{
    for(int u = i+1; u < arrayPunkter.Length; u++)
    {
        if (arrayPunkter[i].getX == arrayPunkter[u].getX)
            arrayPunkter[i].setX(arrayPunkter[i].getX() + 1);
        if (arrayPunkter[i].getY == arrayPunkter[u].getY)
            arrayPunkter[i].setY(arrayPunkter[i].getY() + 1);
    }

    Console.WriteLine("(" + arrayPunkter[i].getX() + "," + arrayPunkter[i].getY() + ")");

}



// här printas siffrorna ut till kordinater 
for (int x = 0; x < 10; x++)
{

    x_Kordinaten = rnd.Next(-10, 10);
    y_Kordinaten = rnd.Next(-10, 10);
    Console.WriteLine("[" + x_Kordinaten +","+ y_Kordinaten + "]");
    Console.WriteLine(" ");

}
// FÖrdjupning 2
// gör så att man själv bestämmer antalet punkter
static void genereraPunkter()
{
    //registerar mängden siffror som ska skrivas ut
    Console.WriteLine("Nummer: ");

    string nummer = Console.ReadLine();
    int a = 0;
    a =int.Parse(nummer);


    Random rnd = new Random();
    int x_Kordinaten;
    int y_Kordinaten;   

    for (int x = 0; x < a; x++)
    {
        x_Kordinaten = rnd.Next(-10, 10);
        y_Kordinaten = rnd.Next(-10, 10);
        Console.WriteLine("[" + y_Kordinaten + "," + x_Kordinaten + "]");
        Console.WriteLine(" ");
    }
}


// förbjupning 3
static void generaraPunkter()
{
    //registerar antal siffror som skrivs ut
    Console.WriteLine("X och Y Gräns värden");
    string antalNummer = Console.ReadLine();
    int x = 0;
    x = int.Parse(antalNummer);

    Console.WriteLine("Ange nummer");

    string antalSiffror = Console.ReadLine();
    int y = 0;
    y = int.Parse(antalSiffror);

    Random rnd = new Random();
    int xPunkter;
    int yPunkter;

    for (int a = 0; a < x; a++)
    {
        xPunkter = rnd.Next(-x, x);
        yPunkter = rnd.Next(-x, x);
        Console.WriteLine("[" + yPunkter + "," + xPunkter + "]");
        Console.WriteLine(" ");
    }

}
generaraPunkter();
*/

//Uppgift 2
void Lösenord()
{
    // variabel
    string input = ",";
    // skapar en ny variabel 
    info.lösenordinfo sparatlösenord = new info.lösenordinfo();
    Console.WriteLine("Välj lösen, 4 till 10 tecken");
    
    //loopar så att de blir möjligt att forstätta efter input och senare se sitt sparade lösenord
    while (input != "ex")
    {
        input = Console.ReadLine();
        if (input.Length > 4 && input.Length < 10)
        {
            sparatlösenord.setlösenord(input);
            Console.WriteLine("Lösenord klart, önskar du att se lösenordet tryck JA");

        }
        if (input == "JA")
        {

            Console.WriteLine(sparatlösenord.visalösenord()); 

        }

    }
}
Lösenord();

//Uppgift 3

    /*
    Punkt alpha = new Punkt();
    alpha.setX(0);
    alpha.setY(0);

    Punkt[] arrayPunkter = new Punkt[10];

    for (int i = 0; i < arrayPunkter.Length; i++)
    {
        arrayPunkter[i] = new Punkt();
    }

    Punkt punkt5 = new Punkt();
    punkt5.setX(5);
    punkt5.setY(5);
    punkt5.IncreaseX();

    Console.WriteLine(


}*/
