using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizeCSV : BaseCSVLoader<LocalizeCSV>
{
    protected override void Awake()
    {
        Path = "localize";
    }

    // �p����Ńf�[�^�͂ǂ�����������
    public string GetDataByID(string id,bool isJP)
    {
        var data = csvDatas2[id];
        return isJP ? data[0] : data[1];
    }
}
