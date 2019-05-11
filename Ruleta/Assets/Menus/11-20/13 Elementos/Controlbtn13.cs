using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controlbtn13 : MonoBehaviour
{
    public void segundapestaña()
    {
        SceneManager.LoadScene("13-2");
    }

    public void primerapestaña()
    {
        SceneManager.LoadScene("13-1");
    }

    public void ruleta13()
    {
        SceneManager.LoadScene("rueleta13");
    }
}
