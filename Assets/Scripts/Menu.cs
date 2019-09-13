using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField velocidad;
    public InputField masa;
    public InputField carga;

    public string Velocidad;
    public string Masa;
    public string Carga;
    
    public static int vel;
    public static int mas;
    public static int car;
    
    public Toggle lineal;
    public Toggle cuadratica;
    public Toggle cubica;
    public Toggle exponencial;
    public Toggle logaritmica;

    // Start is called before the first frame update
    void Start()
    {
        lineal.isOn = false;
        cuadratica.isOn = false;
        cubica.isOn = false;
        exponencial.isOn = false;
        logaritmica.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        Velocidad = velocidad.GetComponent<InputField>().text;
        Masa = masa.GetComponent<InputField>().text;
        Carga = carga.GetComponent<InputField>().text;
        
    }

    public void cambioEscena()
    {
        if (lineal.isOn && Velocidad != "" && Masa != "" && Carga != "")
        {
            vel = Convert.ToInt32(Velocidad);
            Debug.Log(vel + 1);
            mas = Convert.ToInt32(Masa);
            Debug.Log(mas + 1);
            car = Convert.ToInt32(Carga);
            Debug.Log(car + 1);
            SceneManager.LoadScene("lineal");
        }
        if (cuadratica.isOn && Velocidad != "" && Masa != "" && Carga != "")
        {
            SceneManager.LoadScene("cuadratica");
        }
        if (cubica.isOn && Velocidad != "" && Masa != "" && Carga != "")
        {
            SceneManager.LoadScene("cubica");
        }
        if (exponencial.isOn && Velocidad != "" && Masa != "" && Carga != "")
        {
            SceneManager.LoadScene("exponencial");
        }
        if (logaritmica.isOn && Velocidad != "" && Masa != "" && Carga != "")
        {
            SceneManager.LoadScene("logaritmica");
        }
    }
}
