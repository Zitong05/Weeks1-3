using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels = new Sprite[3];
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
        //spriteRenderer.sprite = mySprite;
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            //PickARandomColour();
            PickARandomSprite();
        }

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is the mouse over the sprite
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y set the colour to our col variable
            spriteRenderer.color = col; 
        }
        else
        {
            //N set the colour to white
            spriteRenderer.color = Color.white; 
        }
        
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //pick a random number
        randomNumber = Random.Range(0, barrels.Length);
        //assign that sprite
        spriteRenderer.sprite = barrels[randomNumber];
    }

}
