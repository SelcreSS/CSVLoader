public class LocalizeCSV : BaseCSVLoader<LocalizeCSV>
{
    protected override void Awake()
    {
        Path = "localize";
    }

    // 継承先でデータはどう扱うか料理
    public string GetDataByID(string id,bool isJP)
    {
        var data = csvDatas[id];
        return isJP ? data[0] : data[1];
    }
}
