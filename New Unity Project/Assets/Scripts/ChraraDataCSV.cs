public class ChraraDataCSV : BaseCSVLoader<ChraraDataCSV>
{
    protected override void Awake()
    {
        Path = "charadata";
    }

    // Œp³æ‚Åƒf[ƒ^‚Í‚Ç‚¤ˆµ‚¤‚©Œˆ‚ß‚é
    public CharaData GetDataByID(string id)
    {
        var data = csvDatas[id];
        return new CharaData(data[0],data[1], data[2], data[3], data[4], data[5]);
    }
}

public class CharaData
{
    public string name;
    public int hp;
    public int atk;
    public int def;
    public int spd;
    public int mgc;

    public CharaData(string name, string hp, string atk, string def, string spd, string mgc)
    {
        this.name = name;
        this.hp = int.Parse(hp);
        this.atk = int.Parse(atk);
        this.def = int.Parse(def);
        this.spd = int.Parse(spd);
        this.mgc = int.Parse(mgc);
    }
}
