using UnityEngine;

public class Teleport : MonoBehaviour
{
    int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 0)
        {

        }
        Vector2 newposition = transform.position;
        newposition = Random.insideUnitCircle;
    }
}
