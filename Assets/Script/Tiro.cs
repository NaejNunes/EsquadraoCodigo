﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{

    GameObject player;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * vel);
    }

    private void OnTriggerEnter2D(Collider2D playerCol)
    {
        if (playerCol.gameObject.CompareTag("Playerr"))
        {
            Destroy(this.gameObject);
        }
        if (playerCol.gameObject.tag == "Barril")
        {
            Destroy(this.gameObject);
        }
        if (playerCol.gameObject.tag == "Alvo")
        {
            Destroy(this.gameObject);
        }
    }
}
