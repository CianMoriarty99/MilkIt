using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderContainerSpawn : GameFlow
{
    SpriteRenderer m_SpriteRenderer;

    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.sprite = sprites[numberOfTeas];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
