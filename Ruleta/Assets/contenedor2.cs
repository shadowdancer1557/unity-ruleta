using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contenedor2 : MonoBehaviour
{
    public InputField elemento11;

    public string elemento1copia;
    public string elemento2copia;
    public string elemento3copia;
    public string elemento4copia;
    public string elemento5copia;
    public string elemento6copia;
    public string elemento7copia;
    public string elemento8copia;
    public string elemento9copia;
    public string elemento10copia;
    public string contenedor11;

    
    public void finalizado()
    {
        contenedor11 = elemento11.text;
        contenedor elementos = GetComponent<contenedor>();
        elemento1copia = elementos.contenedor1;
        elemento2copia = elementos.contenedor2;
        elemento3copia = elementos.contenedor3;
        elemento4copia = elementos.contenedor4;
        elemento5copia = elementos.contenedor5;
        elemento6copia = elementos.contenedor6;
        elemento7copia = elementos.contenedor7;
        elemento8copia = elementos.contenedor8;
        elemento9copia = elementos.contenedor9;
        elemento10copia = elementos.contenedor10;
    }
    public void report()
    {
        print(elemento1copia);
        print(elemento2copia);
        print(elemento3copia);
        print(elemento4copia);
        print(elemento5copia);
        print(elemento6copia);
        print(elemento7copia);
        print(elemento8copia);
        print(elemento9copia);
        print(elemento10copia);
        print(elemento11);
    }
}
