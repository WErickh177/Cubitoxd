using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;
    public bool isAlive = true;
    public bool variableDePrueba;
    public Jugador Pl;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            print("Me Morí");
            isAlive = false;
            Destroy(Pl);
        }

    }
}
