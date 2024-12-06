using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour

{
    public GameObject Doorway;
    public GameObject trigger;




    // Update is called once per frame
    void Update()
    {
        
        if(!trigger.activeSelf)
        {
            Doorway.SetActive(false);
        }

    }
}
