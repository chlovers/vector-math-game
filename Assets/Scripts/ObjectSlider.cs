using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSlider : MonoBehaviour
{
    
    public Transform pointA;
    public Transform pointB;

   
    public float moveSpeed = 2f;

    public GameObject player;
    private Transform targetPoint;
    private bool isMoving = false;

    void Start()
    {
        
        targetPoint = pointA;
    }

    void Update()
    {

        if ((player.transform.position - transform.position).magnitude < 3.5)
        {
            if (Input.GetKeyDown(KeyCode.E) && !isMoving)
            {

                isMoving = true;
                targetPoint = (targetPoint == pointA) ? pointB : pointA;
            }   
        }

       // Debug.Log($"distance is not bing enough{(player.transform.position - transform.position).magnitude}" );

        if (isMoving)
        {
            MoveObject();
        }
    }

    void MoveObject()
    {
        
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);

        
        if (transform.position == targetPoint.position)
        {
            isMoving = false;
        }
    }
}
