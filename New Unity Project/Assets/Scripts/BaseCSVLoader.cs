using System.Collections.Generic;
using UnityEngine;
using System.IO;

/// <summary>
/// UTF-8 CSVLoader
/// </summary>
public class BaseCSVLoader<T> : GenelicSingleton<T> where T : Initializer
{
    protected string Path;

    private TextAsset csvFile;
    protected static Dictionary<string,string[]> csvDatas2 = new Dictionary<string, string[]>();

    protected override void Start()
    {
        csvFile = Resources.Load(Path) as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        int indexCount = 0;
        bool isTagCheckEnd = false;
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            // 分割された1行のデータ
            var addline = line.Split(',');

            // @を弾くタグとしてCSV上確認。データにはいらないので一番上は飛ばす。
            // タグが何個あるか
            if (!isTagCheckEnd)
            {
                foreach (var tag in addline)
                {
                    if (tag.Contains("@"))
                    {
                        ++indexCount;
                    }
                }
                isTagCheckEnd = true;
                continue;
            }

            // CSV上でID以外のデータを抜き出し
            // 必ずindex0はIDkeyになっている構成前提
            List<string> data = new List<string>();
            for(int index = 1; index < indexCount;index++)
            {
                data.Add(addline[index]);
            }
            csvDatas2[addline[0]] = data.ToArray();
        }
    }
}