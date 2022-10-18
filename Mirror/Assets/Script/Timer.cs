using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float time;
    public GameObject Yes;
    public Quest change;
    public TMPro.TextMeshPro TEXT;
    // Start is called before the first frame update
    void Start()
    {
        time = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 5.0f && time > 4.0f)
        {
            TEXT.text = "5";
        }
        if (time<4.0f && time> 3.0f){
            TEXT.text = "4";
        }
        if (time > 2.0f && time<3.0f)
        {
            TEXT.text = "3";
        }
        if(time<2.0f && time >1.0f)
        {
            TEXT.text = "2";
        }
        if (time < 1.0f && time > 0.0f)
        {
            TEXT.text = "1";
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended && Yes.transform.position.y <= -1.2f)
            {
                time = 5;
            }
            if (touch.phase == TouchPhase.Ended && Yes.transform.position.y > 4.5f)
            {
                time = 5;
            }

        }
        if (time < 0.0f)
        {
            change.TextChange();
            time = 5;
        }
    }
}
