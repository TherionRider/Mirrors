using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class textarray : MonoBehaviour
{
    public TextAsset frase;
    public TextAsset fruits;
    private List<string> frases, fruitses;
    // Start is called before the first frame update
    void Start()
    {
        var splitFile = new string[] { "\r\n", "\r", "\n" };
        var NameLines = frase.text.Split(splitFile, System.StringSplitOptions.None);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
