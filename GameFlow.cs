using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public GameObject orderBox;
    public GameObject customer;
    public int numberOfTeas;


    public GameObject[] containers;

    public float orderGap = 0.8f;

    public Transform orderSpawn;
    public Transform customerSpawn;
    public Transform containerSpawn;
    void Start()
    {
        numberOfTeas = Random.Range(1,6);
        Instantiate(customer, customerSpawn.position, Quaternion.identity);
        Instantiate(containers[numberOfTeas - 1], new Vector3 (containerSpawn.position.x + (0.4f * (numberOfTeas -1)), containerSpawn.position.y, containerSpawn.position.z) , Quaternion.identity);

        for (int n = 0; n < numberOfTeas; n++)
        {
            Instantiate(orderBox, new Vector3 (orderSpawn.position.x + (orderGap*n), orderSpawn.position.y, orderSpawn.position.z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
