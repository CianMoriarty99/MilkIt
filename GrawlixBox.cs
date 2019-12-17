using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrawlixBox : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;

    public Sprite[] sprites;
    public int decider;

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        int decider = Random.Range(1,7);

        if (decider == 1)
        {
            m_SpriteRenderer.sprite = sprites[0];
        }

        else if (decider == 2)
        {
            m_SpriteRenderer.sprite = sprites[1];
        }

        else if (decider == 3)
        {
            m_SpriteRenderer.sprite = sprites[2];
        }

        else if (decider == 4)
        {
            m_SpriteRenderer.sprite = sprites[3];
        }
        else if (decider == 5)
        {
            m_SpriteRenderer.sprite = sprites[4];
        }
        else if (decider == 6)
        {
            m_SpriteRenderer.sprite = sprites[5];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
