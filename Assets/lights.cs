using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{

    public GameObject PointLight;
    private bool on = false;

    private void OnTriggerStay(Collider plyr)
    {
        if(plyr.tag == "Player" && Input.GetKeyDown(KeyCode.F) && !on)
        {
            PointLight.SetActive(true);
            on = true;
        }

        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.F) && on)
        {
            PointLight.SetActive(false);
            on = false;
        }
    }
}
