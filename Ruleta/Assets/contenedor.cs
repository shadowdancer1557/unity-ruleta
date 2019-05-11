using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contenedor : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public InputField elemento1;
    public InputField elemento2;
    public InputField elemento3;
    public InputField elemento4;
    public InputField elemento5;
    public InputField elemento6;
    public InputField elemento7;
    public InputField elemento8;
    public InputField elemento9;
    public InputField elemento10;
    

    public string contenedor1;
    public string contenedor2;
    public string contenedor3;
    public string contenedor4;
    public string contenedor5;
    public string contenedor6;
    public string contenedor7;
    public string contenedor8;
    public string contenedor9;
    public string contenedor10;
    

   
   

    // Update is called once per frame
    public void llenado()
    {
        contenedor1 = elemento1.text;
        contenedor2 = elemento2.text;
        contenedor3 = elemento3.text;
        contenedor4 = elemento4.text;
        contenedor5 = elemento5.text;
        contenedor6 = elemento6.text;
        contenedor7 = elemento7.text;
        contenedor8 = elemento8.text;
        contenedor9 = elemento9.text;
        contenedor10 = elemento10.text;
        
    }

 
}
