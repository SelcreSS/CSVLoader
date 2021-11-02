public class LocalizeCSV : BaseCSVLoader<LocalizeCSV>
{
    protected override void Awake()
    {
        Path = "localize";
    }

    // �p����Ńf�[�^�͂ǂ�����������
    public string GetDataByID(string id,bool isJP)
    {
        var data = csvDatas[id];
        return isJP ? data[0] : data[1];
    }
}
