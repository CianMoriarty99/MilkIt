using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderBox : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    public int milkLevel;

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        milkLevel = Random.Range(1,5);

        if (milkLevel == 1)
        {
            m_SpriteRenderer.sprite = sprites[0];
        }

        else if (milkLevel == 2)
        {
            m_SpriteRenderer.sprite = sprites[1];
        }

        else if (milkLevel == 3)
        {
            m_SpriteRenderer.sprite = sprites[2];
        }

        else if (milkLevel == 4)
        {
            m_SpriteRenderer.sprite = sprites[3];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
