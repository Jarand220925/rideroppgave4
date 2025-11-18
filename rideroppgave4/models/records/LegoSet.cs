namespace rideroppgave4.models.records;

public record LegoSet(
    string setnumber,
    string name,
    int year,
    int theme_id,
    int numOfParts
    );