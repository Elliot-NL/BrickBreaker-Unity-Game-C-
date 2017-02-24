using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{

    public UIManager ui;

    // Use this for initialization
    void Start()
    {
        ui = GameObject.FindWithTag("UI").GetComponent<UIManager>();

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            ui.IncrementScore();
            Destroy(gameObject);

        }
    }
}

