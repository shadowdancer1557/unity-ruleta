using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controlbtn : MonoBehaviour
{
    public void segundapestaña()
    {
        SceneManager.LoadScene("11-2");
    }

    public void primerapestaña()
    {
        SceneManager.LoadScene("11-1");
    }

    public void ruleta11()
    {
        SceneManager.LoadScene("rueleta11");
    }
}
