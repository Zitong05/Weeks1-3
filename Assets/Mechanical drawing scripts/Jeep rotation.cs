using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeeprotation : MonoBehaviour
{
    float rotationSpeed = 80f; // rotation speed
    float Angle = 0f; // set angle degres
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))//if press A
        {
            if (Angle == 0)//set to 30 degrees when it's 0
            {
                Angle = 30f;
            }
            else//set to 0 degrees when it's 30
            {
                Angle = 0f;
            }
        }
        float currentAngle = transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(0, 0, Mathf.MoveTowardsAngle(currentAngle, Angle, rotationSpeed * Time.deltaTime));
        //https://docs.unity3d.com/2022.3/Documentation/ScriptReference/Mathf.MoveTowardsAngle.html
    }
}
