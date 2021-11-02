using System.Collections.Generic;
using UnityEngine;
using System.IO;

/// <summary>
/// UTF-8 CSVLoader
/// </summary>
public class BaseCSVLoader<T> : GenelicSingleton<T> where T : GenelicSingletonInitializer
{
    protected string Path;

    private TextAsset csvFile;
    protected static Dictionary<string,string[]> csvDatas = new Dictionary<string, string[]>();

    protected override void Start()
    {
        csvFile = Resources.Load(Path) as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        int indexCount = 0;
        bool isTagCheckEnd = false;
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            // �������ꂽ1�s�̃f�[�^
            var addline = line.Split(',');

            // @���f�[�^�Ɋ܂܂Ȃ��u�e���^�O�v�Ƃ��Đݒ�B��ԏ�̗�͊܂܂Ȃ��B
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

            // CSV���ID�ȊO�̃f�[�^�𔲂��o��
            // �K��index0��IDkey�ɂȂ��Ă���\���O��
            List<string> data = new List<string>();
            for(int index = 1; index < indexCount;index++)
            {
                data.Add(addline[index]);
            }
            csvDatas[addline[0]] = data.ToArray();
        }
    }
}