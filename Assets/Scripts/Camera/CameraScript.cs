using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float dragSpeed = 2;
    private Vector3 dragOrigin;
 
 
    void Update()
    {
        // dont move if there is a popup
        if (GameObject.FindGameObjectWithTag("Popup"))return;
        
        // dont move if shift is down
        if (Input.GetKey(KeyCode.LeftShift)) return;



        
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }
 
        if (!Input.GetMouseButton(0)) return;
 
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);
 
        transform.Translate(move, Space.World);
    }

}
