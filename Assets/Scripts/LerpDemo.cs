using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    
    [Range(0, 1)]
    public float t;

    public Transform start;
    public Transform end;
    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        t += 0.01f;
        if(t>=1)
        {
            t = t * -1f;
        }

    }
}
