using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    [SerializeField, Header("サンプルTestUI")]
    private Text text;
    [SerializeField, Header("サンプルTestUI2")]
    private Text[] charaDatas;

    public bool isJapanese;

    void Start()
    {
        text.text = LocalizeCSV.Instance.GetDataByID("ID_TEST", isJapanese);
        var csvCharaData = ChraraDataCSV.Instance.GetDataByID("ID_YUSHA");
        string[] strDatas = 
                {
                    csvCharaData.name,
                    csvCharaData.hp.ToString(),
                    csvCharaData.atk.ToString(),
                    csvCharaData.def.ToString(),
                    csvCharaData.spd.ToString(),
                    csvCharaData.mgc.ToString(),
                };
        for(int i = 0; i< strDatas.Length;i++)
        {
            charaDatas[i].text = strDatas[i];
        }
    }
}