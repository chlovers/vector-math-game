using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour
{
    public float rotationspeed = 20f; 
    

    void Update()
    {
        // Rotate the camera to simulate scanning behavior
        transform.Rotate(0, rotationspeed * Time.deltaTime, 0);
    }


}
