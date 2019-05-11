using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controlvar : MonoBehaviour
{
    public string escenasiguiente;
    public string escenaanterior;
    public string ruleta;

    public void segundapestaña()
    {
        SceneManager.LoadScene(escenasiguiente);
    }

    public void primerapestaña()
    {
        SceneManager.LoadScene(escenaanterior);
    }

    public void ruleta11()
    {
        SceneManager.LoadScene(ruleta);
    }
}
