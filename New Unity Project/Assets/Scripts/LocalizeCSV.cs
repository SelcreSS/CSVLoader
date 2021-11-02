public class LocalizeCSV : BaseCSVLoader<LocalizeCSV>
{
    protected override void Awake()
    {
        Path = "localize";
    }

    // Œp³æ‚Åƒf[ƒ^‚Í‚Ç‚¤ˆµ‚¤‚©—¿—
    public string GetDataByID(string id,bool isJP)
    {
        var data = csvDatas[id];
        return isJP ? data[0] : data[1];
    }
}
