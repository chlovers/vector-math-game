using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight : MonoBehaviour
{
    public Transform target; 
    public Light spotlight; 
    public GameObject gameOverScreen;
    public Color notseen = Color.green;
    public Color caught = Color.red;
   

    void Start()
    {
       
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
       
        Vector3 spotlightDirection = spotlight.transform.forward;
        Vector3 targetDirection = (target.position - spotlight.transform.position).normalized;

       
        float dotProduct = Vector3.Dot(spotlightDirection, targetDirection);

       
        if (dotProduct > 0.9f) 
        {
            spotlight.intensity = 500f;
            spotlight.color = caught;
            
            GameOver();
        }
        else
        {
            spotlight.intensity = 200f;
            spotlight.color = notseen;
        }
    }

    void GameOver()
    {
       
        Time.timeScale = 0;

       
        gameOverScreen.SetActive(true);

        Cursor.visible = true;
        

    }
}
