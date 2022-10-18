using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ye : MonoBehaviour
{
    public GameObject stand;
    public GameObject prot;
    public GameObject Yes;
    public Quest change;
    // Start is called before the first frame update
    Vector3 Ypos = new Vector3();
    Vector3 Yright = new Vector3();
    Quaternion Zstand = new Quaternion();
    Vector2 move = new Vector2();
    bool start = false;
    Collider2D col;
    
    
    void Start()
    {
        col = GetComponent<Collider2D>();
        Ypos = transform.position;
        Yright = prot.transform.position;
        Zstand = stand.transform.rotation;

    }
    // Update is called once per frame
    void Update()
    {
        Yes.transform.position = new Vector2(transform.position.x+1.054f, transform.position.y-5.26f);
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchCollider)
                {
                    if(touchCollider.name == "left_beam")
                    {
                        start = true;
                        move = touchPosition;
                    }
                }
            }
            if (touch.phase == TouchPhase.Moved && transform.position.y > -1.2f && start && transform.position.y <= 0.75f)
            {
                double zz = (move.y - touchPosition.y) * 28.125;
                stand.transform.rotation = Quaternion.Euler(Zstand.x, Zstand.y, (float)zz);
                prot.transform.position = new Vector2(Yright.x, Yright.y + (move.y - touchPosition.y) * 1.8f);
                transform.position = new Vector2(Ypos.x, Ypos.y - (move.y - touchPosition.y));
            }
            if (transform.position.y > 0.75f && start)
            {
                stand.transform.rotation = Quaternion.Euler(Zstand.x, Zstand.y, -1.52f);
                prot.transform.position = new Vector2(Yright.x, Yright.y + (-0.054039f) * 1.8f);
                transform.position = new Vector2(Ypos.x, 0.75f);
            }
            if (transform.position.y < -1.2f && start)
            {
                prot.transform.position = new Vector2(Yright.x, 4.516f);
                transform.position = new Vector2(Ypos.x, -1.2f);
                stand.transform.rotation = Quaternion.Euler(Zstand.x, Zstand.y, 54);
            }
            if (touch.phase == TouchPhase.Ended && start)
            {
                if (transform.position.y == -1.2f)
                {
                    change.TextChange();
                }
                prot.transform.position = new Vector2(Yright.x, Yright.y);
                transform.position = new Vector2(Ypos.x, Ypos.y);
                stand.transform.rotation = Zstand;
                start = false;
                
            }
        }

    }
}
