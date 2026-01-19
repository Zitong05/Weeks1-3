using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Rollover : MonoBehaviour
{
    //public RotateMe rotateMe;
    public bool mouseIsOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //get the distance between the mouse and this transform position
        float distance = Vector2.Distance(mousePos, transform.position);
        
        if (distance < 1.0f)
        {
            mouseIsOver = true;
            //rotateMe.speed = 0;
        }
        else
        {
            mouseIsOver = false;
            //rotateMe.speed = 100;
        }
    }
}
