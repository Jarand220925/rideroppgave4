using rideroppgave4.models.Classes;
using rideroppgave4.models.records;

namespace rideroppgave4;

class Program
{
    static void Main(string[] args)
    {
        /*string filename = Path.GetFileName("nope.txt");
        string filepath = Path.GetFullPath(filename);
        Console.WriteLine(filepath);*/
        Reader mainReader = new();
        //mainReader.ReadAndMake(@"rideroppgave4\csv\lego\sets.csv", LegoSetListClass.Generate);
        //mainReader.ReadAndMake("rideroppgave4\\csv\\lego\\themes.csv", GenerateLegoThemes.Generate);
        mainReader.MakeList(@"rideroppgave4\csv\lego\sets.csv", LegoSetListClass.Generate);
        mainReader.MakeList(@"rideroppgave4\csv\lego\themes.csv", GenerateLegoThemes.Generate);
        //Console.WriteLine(LegoSetListClass.LegoSetsList[25].name);

        /*string anførselTest =
            "{1}{R}{R},\"The Minotaurs of the Hurloon Mountains are known for their love of battle. They are also known for their hymns to the dead, sung for friend and foe alike. These hymns can last for days, filling the mountain valleys with their low, haunting sounds.\",2,3";
        string[] test = anførselTest.Split();
        Console.WriteLine(test[0]);*/
        //List<string> kommandoliste = new();
        
        Console.WriteLine($"Her er kommandoene:\n renons \n showthemes \n select \n where");
        var input = Console.ReadLine(); 
        switch (input)
        {
            case "renons" :
                Console.WriteLine("Jeg er renons");
                break;
            case "showthemes":
                break;
            //Tar ut en egenskap fra hvert objekt i LegoSetsList, lager en ny liste med egenskaper, og skriver ut alt fra den nye listen i terminalen.
            case "select":
                //var selectinput = Console.ReadLine();
                List<string> names = LegoSetListClass.LegoSetsList.Select(LegoSet => LegoSet.name).ToList();
                names.ForEach(LegoSet => Console.WriteLine(LegoSet));
                break;
            //Plukker ut alle LegoSet som fyller kriteriene og legger dem i en egen liste.
            //Skriver ut alle LegoSet fra ny liste.
            case "where":
                List<LegoSet> wherelist = LegoSetListClass.LegoSetsList.Where(LegoSet => LegoSet.year < 2000 & LegoSet.year != 0).ToList();
                wherelist.ForEach(LegoSet => Console.WriteLine(LegoSet));
                break;
        }

        
        //Console.WriteLine("(They can't be blocked as long as defending player controls a Swamp.) \nOther Zombies have \"\"{B}: Regenerate this permanent.\"");

    }
}