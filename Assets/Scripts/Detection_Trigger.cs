using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection_Trigger : MonoBehaviour
{

    public AudioSource Sonido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string name;
        string tag;

        name = other.gameObject.name;
        tag = other.gameObject.tag;

        Debug.Log("Trigger Enter - Nombre: " + name + " Tag: " + tag);

        if (other.gameObject.tag == "Player")
        {
            Sonido.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        string name;
        string tag;

        name = other.gameObject.name;
        tag = other.gameObject.tag;

        Debug.Log("Trigger Exit - Nombre: " + name + " Tag: " + tag);

        if (other.gameObject.tag == "Player")
        {
            Sonido.Stop();
        }
    }
}
