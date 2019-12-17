using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public Sprite[] faces;
    public Sprite[] bodies;
    public Color[] tones;
    public Color[] clothes;

    public Sprite faceSprite;
    public Sprite bodySprite;
    public Color toneColor;
    public Color clothesColor;

    public List<int> orderList;

    void Start()
    {
        faceSprite = faces[Random.Range(1, faces.Length)];
        bodySprite = bodies[Random.Range(1, bodies.Length)];
        toneColor = tones[Random.Range(1, tones.Length)];
        clothesColor = clothes[Random.Range(1, clothes.Length)];

        int numberOfCoffees = Random.Range(1,6);
        Debug.Log(numberOfCoffees);
        for (int i = 0; i < numberOfCoffees; i++ )
        {
            orderList.Add(Random.Range(1,6)); 
        }

        
    }


}
