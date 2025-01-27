using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeepAnimationcurve : MonoBehaviour
{
    public AnimationCurve curve; // AnimationCurve


    public float durationTime = 0f; // duration time
    public Vector3 originalScale; // original scale

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale; // get original scale
    }

    // Update is called once per frame
    void Update()
    {
        // 根据是否按住 W 键调整 scaleTime
        if (Input.GetKey(KeyCode.W))
        {
            durationTime += Time.deltaTime; // increasing time
        }
        else
        {
            durationTime -= Time.deltaTime; // decreasing time
        }


        // change object scale
        transform.localScale = originalScale * (1 - curve.Evaluate(durationTime) * 0.5f);
    }
}
