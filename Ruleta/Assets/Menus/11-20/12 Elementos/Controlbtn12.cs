using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controlbtn12 : MonoBehaviour
{
    public void segundapestaña()
    {
        SceneManager.LoadScene("12-2");
    }

    public void primerapestaña()
    {
        SceneManager.LoadScene("12-1");
    }

    public void ruleta12()
    {
        SceneManager.LoadScene("rueleta12");
    }
}
