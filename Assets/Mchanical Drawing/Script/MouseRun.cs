using UnityEngine;
using UnityEngine.InputSystem;

public class MouseRun : MonoBehaviour
{
    public Transform cat;           //cat object
    public float RunDis = 5;       //distance to run away
    public AnimationCurve curve;
    public float t;                 // t value for running
    Vector3 originPosition;

    public float DisToOrigin;       // distance to origin position

    public Transform mouse;         //mouse object
    public float amplitude = 0.05f;  // eating amplitude
    public float speed = 4;        // speed for eating

    //Vector3 startPos;
    float t2 = 0f;                  // t value for eating
    int dir = 1;                   // eating direction


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float t = curve.Evaluate(Time.deltaTime);

        float distanceToCat = Vector3.Distance(transform.position, cat.position);

        DisToOrigin = Vector3.Distance(transform.position, originPosition);

        if (distanceToCat < RunDis)
        {
            Vector3 direction = transform.position - cat.position;
            Vector3 endPos = transform.position + direction;


            transform.position = Vector3.Lerp(transform.position,endPos, t);
        }
        else
        {
            //return to start position
            transform.position = Vector3.Lerp(transform.position, originPosition, t);

            if(DisToOrigin < 0.2f)
            {
                t2 += Time.deltaTime * speed * dir;

                // move left and right
                if (t2 >= 1f)
                {
                    t2 = 1f;
                    dir = -1;
                }
                else if (t2 <= 0f)
                {
                    t2 = 0f;
                    dir = 1;
                }

                Vector3 left = originPosition + Vector3.left * amplitude;
                Vector3 right = originPosition + Vector3.right * amplitude;
                mouse.position = Vector3.Lerp(left, right, t2);
            }
        }
    }
}
