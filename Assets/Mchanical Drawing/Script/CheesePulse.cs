using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChessPulse : MonoBehaviour
{
    public Transform mouse;         // 老鼠对象
   
    public float DisToOrigin;
    Vector3 originPosition;

    public AnimationCurve curve;
    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        originPosition = mouse.position;

        DisToOrigin = Vector3.Distance(transform.position, originPosition);

        if (DisToOrigin < 1)
        {
            t += Time.deltaTime;
            if (t > 1)
            {
                t = 0;
            }
            float y = curve.Evaluate(t);
            Vector3 newSize = Vector3.one * y;
            transform.localScale = Vector3.one * curve.Evaluate(t);
        } 
    }
}
