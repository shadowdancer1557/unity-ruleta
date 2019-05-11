using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class controladorElementos : MonoBehaviour
{
    public InputField elefield;

    private string cantelement;

    public void countelement()
    {
        cantelement = elefield.text;

        switch (cantelement)
        {
            case "2":
                SceneManager.LoadScene("Nombrar 2 elementos");
                break;
            case "3":
                SceneManager.LoadScene("Nombrar 3 elementos");
                break;
            case "4":
                SceneManager.LoadScene("Nombrar 4 elementos");
                break;
            case "5":
                SceneManager.LoadScene("Nombrar 5 elementos");
                break;
            case "6":
                SceneManager.LoadScene("Nombrar 6 elementos");
                break;
            case "7":
                SceneManager.LoadScene("Nombrar 7 elementos");
                break;
            case "8":
                SceneManager.LoadScene("Nombrar 8 elementos");
                break;
            case "9":
                SceneManager.LoadScene("Nombrar 9 elementos");
                break;
            case "10":
                SceneManager.LoadScene("Nombrar 10 elementos");
                break;
            case "11":
                SceneManager.LoadScene("11-1");
                break;
            case "12":
                SceneManager.LoadScene("12-1");
                break;
            case "13":
                SceneManager.LoadScene("13-1");
                break;
            case "14":
                SceneManager.LoadScene("14-1");
                break;
            case "15":
                SceneManager.LoadScene("15-1");
                break;
            case "16":
                SceneManager.LoadScene("16-1");
                break;
            case "17":
                SceneManager.LoadScene("17-1");
                break;
            case "18":
                SceneManager.LoadScene("18-1");
                break;
            case "19":
                SceneManager.LoadScene("19-1");
                break;
            case "20":
                SceneManager.LoadScene("20-1");
                break;
            case "21":
                SceneManager.LoadScene("21-1");
                break;
            case "22":
                SceneManager.LoadScene("22-1");
                break;
            case "23":
                SceneManager.LoadScene("23-1");
                break;
            case "24":
                SceneManager.LoadScene("24-1");
                break;
            case "25":
                SceneManager.LoadScene("25-1");
                break;
            case "26":
                SceneManager.LoadScene("26-1");
                break;
            case "27":
                SceneManager.LoadScene("27-1");
                break;
            case "28":
                SceneManager.LoadScene("28-1");
                break;
            case "29":
                SceneManager.LoadScene("29-1");
                break;
            case "30":
                SceneManager.LoadScene("30-1");
                break;
            case "31":
                SceneManager.LoadScene("31-1");
                break;
            case "32":
                SceneManager.LoadScene("32-1");
                break;
            case "33":
                SceneManager.LoadScene("33-1");
                break;
            case "34":
                SceneManager.LoadScene("34-1");
                break;
            case "35":
                SceneManager.LoadScene("35-1");
                break;
            case "36":
                SceneManager.LoadScene("36-1");
                break;
            case "37":
                SceneManager.LoadScene("37-1");
                break;
            case "38":
                SceneManager.LoadScene("38-1");
                break;
            case "39":
                SceneManager.LoadScene("39-1");
                break;
            case "40":
                SceneManager.LoadScene("40-1");
                break;
        }

    }
}
