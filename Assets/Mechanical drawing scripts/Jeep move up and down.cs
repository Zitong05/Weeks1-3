using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 0.0005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y += speed;

        if (pos.y < -0.1f || pos.y > 0.1f)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
