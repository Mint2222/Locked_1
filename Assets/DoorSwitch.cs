
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{

    public GameObject Door;
    public bool doorIsOpening;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.right * Time.deltaTime * 80);
          
        }
        if (Door.transform.position.x > -30f)
        {
            doorIsOpening = false;
            
        }
    }
    void OnMouseDown()
    {
        doorIsOpening = true;
       
    }

}