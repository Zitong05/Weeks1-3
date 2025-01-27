using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdmove : MonoBehaviour
{
    float Xspeed = 0.0005f;
    float Yspeed = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Xspeed;
        pos.y += Yspeed;

        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeInTheWorld = new Vector2();
        screenSizeInTheWorld = Camera.main.ScreenToWorldPoint(screenSize);

        //this is what we test on the left
        Vector2 screenZeroInTheWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x < screenZeroInTheWorld.x || pos.x > screenSizeInTheWorld.x)
        {
            Xspeed = Xspeed * -1;
        }
        if (pos.y < 2.75f || pos.y > 3.25f)
        {
            Yspeed = Yspeed * -1;
        }

        transform.position = pos;
    }
}
