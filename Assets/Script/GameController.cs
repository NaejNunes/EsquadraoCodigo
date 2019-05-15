using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
     int milesimos, segundos, minutos;
    public Text txtTempo, txtPontos;
    public static int  pontos;
    // Start is called before the first frame update
    void Start()
    {
        milesimos = 60;
        segundos = 40;
        
    }

    // Update is called once per frame
    void Update()
    {
        Tempo();

        txtTempo.text = "" + segundos;

        txtPontos.text = "Pontos: " + pontos;

        if (pontos >= 3)
        {
            SceneManager.LoadScene("Fase2");
        }

        if (segundos <= 1)
        {
            SceneManager.LoadScene("GameOver");          
        }
       

    }

    public void Tempo()
    {
        milesimos = milesimos - 1;

        if (milesimos == 0)
        {
            segundos = segundos - 1;
            milesimos = 60;
        }
    }
}
