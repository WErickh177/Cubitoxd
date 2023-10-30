using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public float speed;
    Point pointsScript;
    Hp hpScript;

    private void Start()
    {
        pointsScript = FindObjectOfType<Point>();
        hpScript = FindObjectOfType<Hp>();

    }
    private void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            hpScript.hp = hpScript.hp - 1;

            if (hpScript.hp == 0)
            {
                Destroy(collision.gameObject);
            }

            Destroy(gameObject);

        }
        else
        {
            pointsScript = pointsScript.puntos + 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //Eliminame o matame :3 
        }

    }
}
