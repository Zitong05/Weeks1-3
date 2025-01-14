using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveDemo : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0,1)]
    public float t = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * curve.Evaluate(t);
        t += 0.001f;
        if (t >= 1)
        {
            t = t * -0.01f;
        }
    }
}
