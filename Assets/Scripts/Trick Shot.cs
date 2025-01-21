using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TrickShot : MonoBehaviour
{
    //Timer
    
    
    public bool Startcounting = false;

    float speed = 0.01f;
    // Start is called before the first frame update
    public AnimationCurve curve;

    [Range(1, 2)]
    public float t = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        //this is what we test on the right
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeInTheWorld = new Vector2();
        screenSizeInTheWorld = Camera.main.ScreenToWorldPoint(screenSize);

        //this is what we test on the left
        Vector2 screenZeroInTheWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x < screenZeroInTheWorld.x || pos.x > screenSizeInTheWorld.x)
        {
            speed = speed * -1;
        }

        transform.position = pos;

        //"Jump"
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Startcounting = true;
        }

        if (Startcounting == true)
        {
            t += Time.deltaTime;

            transform.localScale = Vector2.one + (Vector2.one * curve.Evaluate(t));
            
           

            if (t>1)
            {
                Startcounting = false;
                t = 0;
                transform.localScale = Vector2.one;
            }

        }



    }
}
