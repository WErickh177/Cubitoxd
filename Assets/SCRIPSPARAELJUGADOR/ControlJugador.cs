using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float sensibilidadRaton = 120f;
    Camera camara;
    // Start is called before the first frame update
    void Start()
    {
        camara = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float xR = Input.GetAxis("Mouse X") * sensibilidadRaton * Time.deltaTime;
        float yR = Input.GetAxis("Mouse Y") * sensibilidadRaton * Time.deltaTime;


        transform.Rotate(0, xR, 0);
        camara.transform.Rotate(-yR, 0, 0);

    }
}
