using rideroppgave4.models.records;

namespace rideroppgave4.models.Classes;

public static class LegoSetListClass
{
    public static List<LegoSet> LegoSetsList= new();
    public static void Generate(string[] list)
    {
        int.TryParse(list[2], out int year);
        int.TryParse(list[3], out int theme_id);
        int.TryParse(list[4], out int numOfParts);
        LegoSet set = new(list[0],list[1],year,theme_id,numOfParts);
        LegoSetsList.Add(set);
    }
    
    
}