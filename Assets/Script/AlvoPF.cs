using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlvoPF : MonoBehaviour
{
    public GameObject alvo;
    int numeros;
    public static float X, Y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X = transform.position.x;
        Y = transform.position.y;
    }
    public void SpownAlvo()
    {
        numeros = Random.Range(0, 3);
        Debug.Log(numeros);
        switch (numeros)
        {
            case 0:
                Instantiate(this.alvo, new Vector2(AlvoPF.X + 0f, AlvoController.Y + 4f), Quaternion.identity);
                break;

            case 1:
                Instantiate(this.alvo, new Vector2(AlvoPF.X + 0f, AlvoController.Y - 4f), Quaternion.identity);
                break;

            case 2:
                Instantiate(this.alvo, new Vector2(AlvoPF.X + 0f, AlvoController.Y - 0f), Quaternion.identity);
                break;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {      
            if (collision.gameObject.CompareTag("Fogo"))
            {
                SpownAlvo();
                GameController.pontos = GameController.pontos + 1;
                Destroy(gameObject);
                
            }
    }

}
