using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menubittons : MonoBehaviour
{

  public void  startover()
    {
        SceneManager.LoadScene("VectorGame");
        Time.timeScale = 1;
    }

    public void quitgame()
    {

        Application.Quit();
    }

}
