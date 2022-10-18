using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Collider2D touchCollider = Physics2D.OverlapPoint(touchPosition);
            if(touch.phase == TouchPhase.Ended)
            {
                if (touchCollider.name == "settings")
                {
                    SceneManager.LoadScene("MirrorMenu");
                }
            }
        }

    }
}
