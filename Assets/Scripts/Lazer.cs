using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Lazer : MonoBehaviour
{
    public int bounce;
    public float howlong;

    private LineRenderer lineRenderer;
    private Ray ray;
    private RaycastHit hit;
    private Vector3 direction;


    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        ray = new Ray(transform.position, transform.forward);

        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        float leftover = howlong;

        for (int i = 0; i < bounce; i++)
        {
           if(Physics.Raycast(ray.origin, ray.direction, out hit, leftover))
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
                leftover -= Vector3.Distance(ray.origin, hit.point);   
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
                if (hit.collider.tag != "Mirror")
                    break;
            }
           else
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount -1, ray.origin + ray.direction * leftover);

            }

        }
    }
}
