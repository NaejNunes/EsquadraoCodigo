using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public  int vida;
    public  float velH, velV, velPulo;
    float scaleX, scaleY, scaleZ;
    public static float X, Y;
    public static bool direcao;
    public GameObject tiro1, tiro2;
    public bool pulo;

    // Start is called before the first frame update
    void Start()
    {
        vida = 10;
        direcao = true;
        velV = 0.15f;
        velH = 0.05f;
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        scaleZ = transform.localScale.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        X = transform.position.x;
        Y = transform.position.y;

        if (Input.GetAxis("Direita2") > 0)
        {
            transform.Translate(Vector3.left * velH);
            transform.localScale = new Vector3(-scaleX, scaleY, scaleZ);

            direcao = false;
        }

        if (Input.GetAxis("Direita2") < 0)
        {
            transform.Translate(Vector3.right * velH);
            transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

            direcao = true;
        }
        if (Input.GetAxis("Cima2") > 0 && pulo == true)
        {
            pulo = false;

            transform.Translate(Vector3.up * velPulo);
        }

        if (Input.GetKeyDown(KeyCode.RightControl) && direcao == false)
        {
            Instantiate(this.tiro1, new Vector2(Player2.X + 0.5f, Player2.Y - 0.2f), Quaternion.identity);

        }

        else if (Input.GetKeyDown(KeyCode.RightControl) && direcao == true)
        {
            Instantiate(this.tiro2, new Vector2(Player2.X - 0.5f, Player2.Y - 0.2f), Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D playerCol)
    {
        if (playerCol.gameObject.CompareTag("Tiro"))
        {
            vida = vida - 1;

            if (vida == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D Pulo)
    {
        if (Pulo.gameObject.tag == "ground" || Pulo.gameObject.tag == "Barril" || (Pulo.gameObject.tag == "TopoBarril" && Pulo.gameObject.tag == "Barril"))
        {
            pulo = true;
        }
    }
}
