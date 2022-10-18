using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Quest : MonoBehaviour
{
    public TextAsset frase;
    public TextAsset fruits;
    public TMPro.TextMeshPro TEXT;
    private List<string> frases,fruitses;
    // Start is called before the first frame update
    void Start()
    {
        TextChange();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void TextChange()
    {
        var splitFile = new string[] { "\r\n", "\r", "\n" };
        var FrasesLines = frase.text.Split(splitFile, System.StringSplitOptions.None);
        var FruitsLines = fruits.text.Split(splitFile, System.StringSplitOptions.None);
        TEXT.text = FrasesLines[Random.Range(0, 4)] + " " + FruitsLines[Random.Range(0, 24)];
    }
}
