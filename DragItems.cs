using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragItems : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;

    public GameObject item;

    void Update()
    {
        if(isBeingHeld == true)
        {
           
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(item != null) {
            Instantiate(item, this.gameObject.transform.localPosition, Quaternion.identity);
            }

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            item = null;
            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {   
        isBeingHeld = false;
        if (this.gameObject.transform.position.x <= -5)
        {
            Destroy(this.gameObject);
        }

    }
}
