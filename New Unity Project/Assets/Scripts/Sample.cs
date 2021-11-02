using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    [SerializeField, Header("ƒTƒ“ƒvƒ‹TestUI")]
    private Text text;

    public bool isJapanese;

    // Start is called before the first frame update
    void Start()
    {
        text.text = LocalizeCSV.Instance.GetDataByID("ID_TEST", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
