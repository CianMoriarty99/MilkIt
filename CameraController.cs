using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform position1;
    public Transform position2;

    public GameObject playerCamera;

    public bool screenPos = true;
    
    void Start()
    {
    }

    
    void Update()
    {   

        if (screenPos)
        {
            playerCamera.transform.position = position1.transform.position; 
        }
        else   
        {
            playerCamera.transform.position = position2.transform.position;
        }
      

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            screenPos = !screenPos;
        }
    }

    public void ResetCamera()
    {
        screenPos = true;
    }






}
