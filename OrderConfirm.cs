using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderConfirm : MonoBehaviour
{
    public GameObject[] playerOrders;
    public GameObject[] customerOrders;
    public GameObject customerSpeechBox;
    public GameObject[] containers;

    
    public Transform containerSpawn;
    public Transform orderSpawn;

    public float orderGap = 0.8f;

    public int numberOfGrawlixes;

    public bool disableScreenSwitch;

    public GameObject grawlixBox;
    public List<int> milkStrengthP; // (1 to 5)
    public List<int> milkStrengthC; // (1 to 5)


    void Update()
    {
        if (disableScreenSwitch)
        {
            FindObjectOfType<CameraController>().ResetCamera();
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckOrder();
        }
    }

    private void CheckOrder()
    {

        disableScreenSwitch = true;
        milkStrengthC.Clear();
        milkStrengthP.Clear();
        playerOrders = GameObject.FindGameObjectsWithTag("Tea");
        for (int i = 0; i < playerOrders.Length -1; i++) //Ommitting the last mug 
        {
            
            MilkCollision playerMilk = playerOrders[i].GetComponent<MilkCollision>();

            if (playerMilk.milkCounter < 50)
            {
               milkStrengthP.Add(1);
            }
            else if (playerMilk.milkCounter < 100)
            {
               milkStrengthP.Add(2);
            }
            else if (playerMilk.milkCounter < 150)
            {
               milkStrengthP.Add(3);
            }
            else if (playerMilk.milkCounter >= 200)
            {
                milkStrengthP.Add(4);
            }

            Debug.Log(milkStrengthP[i]);
        }

        customerOrders = GameObject.FindGameObjectsWithTag("OrderBox");
        customerSpeechBox = GameObject.FindGameObjectWithTag("Bubble");
        for (int i = 0; i < customerOrders.Length; i++)
        {
            
            OrderBox customerMilk = customerOrders[i].GetComponent<OrderBox>();

            milkStrengthC.Add(customerMilk.milkLevel);
            Debug.Log(milkStrengthC[i]);
        }

        

        int NumMatches = CountMatches(milkStrengthC,milkStrengthP);
        if( NumMatches == milkStrengthC.Count )
        {
            Debug.Log("YOU GOT IT RIGHT");
            //Segue into Happy customer mode - Add a pop up
        }
        else 
        {
            Debug.Log("YOU GOT" + (milkStrengthC.Count - NumMatches ) + "WRONG");
            numberOfGrawlixes = milkStrengthC.Count - NumMatches;
            Debug.Log("YOURE BAD");
            //Segue into DDR BATTLE MODE - Add a pop up
            //Destroy order boxes and speech bubble
            for (int i = 0; i < customerOrders.Length; i++) 
            {
                Destroy(customerOrders[i]);
            }
            Destroy(customerSpeechBox);

            
            //Instantiate DDR BOX based on how many matches you got wrong
            Instantiate(containers[numberOfGrawlixes-1], new Vector3 (containerSpawn.position.x + (0.4f * (numberOfGrawlixes -1)), containerSpawn.position.y, containerSpawn.position.z) , Quaternion.identity);

            for (int n = 0; n < numberOfGrawlixes; n++)
            {
            Instantiate(grawlixBox, new Vector3 (orderSpawn.position.x + (orderGap*n), orderSpawn.position.y, orderSpawn.position.z), Quaternion.identity);
            }
        }
    }

    static public int CountMatches(List<int> required, List<int> taken )
     {
         int numMatches = 0;
         int idx = 0;
 
         while( idx < required.Count && idx < taken.Count )
         {
             if( required[idx] == taken[idx] )
             {
                 numMatches++;
                 idx++;
             }
             else
             {
                 break;
             }
         }
 
         return numMatches;
     }

     static void DDRGen(int size)
     {

     }




}







