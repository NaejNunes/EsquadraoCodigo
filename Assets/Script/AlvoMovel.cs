using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlvoMovel : MonoBehaviour
{

    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * velocidade * Time.deltaTime);

        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Up"))
        {
            velocidade = -3;
        }
        if (collision.gameObject.CompareTag("Down"))
        {
            velocidade = 3;
        }      
}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fogo"))
        {
            SceneManager.LoadScene("Fase3");
        }
    }
}
