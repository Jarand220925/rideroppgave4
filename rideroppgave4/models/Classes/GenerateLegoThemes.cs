using rideroppgave4.models.records;

namespace rideroppgave4.models.Classes;

public static class GenerateLegoThemes
{
    public static List<LegoTheme> LegoThemesList = new();
    
    public static void Generate(string[] list)
    {
        int.TryParse(list[0], out int id);
        int.TryParse(list[2], out int parent_id);
        LegoTheme legoTheme = new(id,list[1],parent_id);
        LegoThemesList.Add(legoTheme);
    }
}