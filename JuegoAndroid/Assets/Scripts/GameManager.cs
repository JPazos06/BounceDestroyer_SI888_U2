using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //Asignación de botones y variable de puntaje

    public GameObject btnEmpezar;
    public GameObject winText;
    public GameObject btnReiniciar;
    public GameObject btnInicio;
    int puntaje = 0;

    // Update is called once per frame
    void Update()
    {
        
    }

    //Verifica el "puntaje", en este caso cuando el puntaje llega a 0
    //(todas las bolas son destruidas) significa que ganaste

    public void PuntajeUp()
    {
        puntaje++;
        if (GameObject.FindGameObjectsWithTag("Ball").Length <= 1)
        {
            Ganar();
        }
    }

    //Cuando ganas se activa el texto que dice
    //GANASTE y los botones de Reinicio o Inicio

    void Ganar()
    {
        winText.SetActive(true);
        btnReiniciar.SetActive(true);
        btnInicio.SetActive(true);
    }

    //Metodos

    //Cambia la escena del Menú al inicio del juego

    public void Empezar()
    {
        SceneManager.LoadScene("Juego");
    }

    //Reinicia el juego

    public void Reiniciar()
    {
        SceneManager.LoadScene("Juego");
    }

    //Te devuelve al Menú de inicio

    public void Inicio()
    {
        SceneManager.LoadScene("Menu");
    }
}
