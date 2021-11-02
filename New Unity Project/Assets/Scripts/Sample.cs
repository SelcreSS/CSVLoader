using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    [SerializeField, Header("�T���v��TestUI")]
    private Text text;

    public bool isJapanese;

    void Start()
    {
        text.text = LocalizeCSV.Instance.GetDataByID("ID_TEST", isJapanese);
    }
}
