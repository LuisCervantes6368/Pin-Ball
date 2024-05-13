using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoLuz : MonoBehaviour
{
    // Start is called before the first frame update
    public Light luz;
    //public AudioSource audioSource; // Referencia al AudioSource que contiene el sonido a reproducir
    public AudioClip sonido; 
    public float duracion = 5f; 
    private float apagar;
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Luuuuuuz");
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Luz");
            luz.enabled = true;
            if (sonido != null)
            {
                AudioSource.PlayClipAtPoint(sonido, transform.position);
            }
            apagar = Time.time + duracion;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (luz.enabled && Time.time >= apagar)
        {
            luz.enabled = false;
        }
    }
}
