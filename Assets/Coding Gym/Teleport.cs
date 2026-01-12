using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newposition = transform.position;

        counter += Time.deltaTime;

        if(counter >= 3)
        {
            counter = 0;
            
            newposition = Random.insideUnitCircle;
        }     
    }
}
