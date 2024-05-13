using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour
{
    // Start is called before the first frame update
    public float intervalo = 0.1f; 
    private Light luces;
    private float time;
    void Start()
    {
        luces = GetComponent<Light>();
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time >= intervalo)
        {
            // Cambia el estado de la luz (encendido/apagado)
            luces.enabled = !luces.enabled;
            time = Time.time;
        }
    }
}
