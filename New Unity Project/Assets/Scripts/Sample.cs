using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    [SerializeField, Header("ƒTƒ“ƒvƒ‹TestUI")]
    private Text text;

    public bool isJapanese;

    void Start()
    {
        text.text = LocalizeCSV.Instance.GetDataByID("ID_TEST", isJapanese);
    }
}
