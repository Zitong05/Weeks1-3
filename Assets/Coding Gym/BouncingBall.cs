using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    //float speed = 1;
    Vector2 speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed += Random.insideUnitCircle*10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition += speed * Time.deltaTime;
        transform.position = newPosition;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed.x = speed.x * -1;
        }
        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speed.y = speed.y * -1;
        }
    }
}
