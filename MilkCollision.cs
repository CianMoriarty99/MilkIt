using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkCollision : MonoBehaviour
{
    public int milkCounter;

    SpriteRenderer m_SpriteRenderer;

    public Sprite[] sprites;

    
    
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        milkCounter = 0;
    }

    void OnTriggerEnter2D(Collider2D info)
    {
        Debug.Log(info);
        if (info.tag == "Milk")
        {
            Destroy(info.gameObject);
            milkCounter += 1;
        }
    }

    void Update()
    {
        if (milkCounter < 50)
        {
            m_SpriteRenderer.sprite = sprites[0];
        }

        else if (milkCounter < 100)
        {
            m_SpriteRenderer.sprite = sprites[1];
        }

        else if (milkCounter < 150)
        {
            m_SpriteRenderer.sprite = sprites[2];
        }

        else if (milkCounter >= 150)
        {
            m_SpriteRenderer.sprite = sprites[3];
        }
        
    }
}