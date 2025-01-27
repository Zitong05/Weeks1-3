using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeepAnimationcurve : MonoBehaviour
{
    public AnimationCurve curve; // AnimationCurve


    public float scaleTime = 0f; // time of changing the scale of the object
    public Vector3 originalScale; // original scale

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale; // get original scale
    }

    // Update is called once per frame
    void Update()
    {
        scaleTime = Mathf.Clamp01(scaleTime); // Limit the time between 0 and 1
        // increase or decrease when hoding or releasing W
        if (Input.GetKey(KeyCode.W))
        {
            scaleTime += Time.deltaTime; // increase scaleTime
        }
        else
        {
            scaleTime -= Time.deltaTime; // decrease scaleTime
        }

        

        // change object scale
        transform.localScale = originalScale * (1 - curve.Evaluate(scaleTime) * 0.5f);
    }
}
