using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método para destruir las bolas al contacto con el mouse/touch

    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().PuntajeUp();
        Destroy(gameObject);
    }
}
