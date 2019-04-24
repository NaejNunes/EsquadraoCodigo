using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlvoController : MonoBehaviour
{
    public GameObject alvo1, alvo2, alvo3;
    int numeros;
    // Start is called before the first frame update
    void Start()
    {
        SpownAlvo();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SpownAlvo()
    {
       numeros =  Random.Range(1, 3);

        switch (numeros)
        {
            case 1:
            Instantiate(alvo1);
            break;

            case 2:
            Instantiate(alvo2);
            break;

            case 3:
            Instantiate(alvo3);
            break;
        }
    }
}
