using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public float velocidadGiro = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject proyectilTemporal = Instantiate(proyectilPrefab, transform.position, transform.rotation);
            Destroy(proyectilTemporal, 3);
        }

        transform.Rotate(Vector3.up, Time.deltaTime * velocidadGiro * movimientoHorizontal);

    }
}
