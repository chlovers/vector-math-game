using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour
{

    public GameObject player;
    public GameObject winscreen;

    // Start is called before the first frame update
    void Start()
    {
        winscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if ((player.transform.position - transform.position).magnitude < 3.5)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                winscreen.SetActive(true);
                Time.timeScale = 0;
            }

        }


    }
}
