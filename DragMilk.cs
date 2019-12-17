using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMilk : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;

    public GameObject milkParticle;

    void FixedUpdate()
    {
        if(isBeingHeld == true)
        {
            
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);

            if (this.gameObject.transform.position.x > -5) {
                Instantiate(milkParticle, this.gameObject.transform.localPosition, Quaternion.identity);
                Instantiate(milkParticle, this.gameObject.transform.localPosition, Quaternion.identity);
                Instantiate(milkParticle, this.gameObject.transform.localPosition, Quaternion.identity);
                Instantiate(milkParticle, this.gameObject.transform.localPosition, Quaternion.identity);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}

