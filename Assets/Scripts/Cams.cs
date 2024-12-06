using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour
{
    public float rotationspeed = 20f; 
    

    void Update()
    {
       
        transform.Rotate(0, rotationspeed * Time.deltaTime, 0);
    }


}
