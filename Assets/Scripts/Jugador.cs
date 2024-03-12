using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour

{
    public Rigidbody rb;
    public float fuerzaSalto = 500f;
    private bool puedeSaltar = true;
    
    void Start()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Meta")
        {
            this.enabled = false;
            return;
        }
        
        if(collision.gameObject.tag == "pared")
        {
            this.enabled = false;
            SceneManager.LoadScene(0);
        }

         if (collision.gameObject.CompareTag("Piso")) 
        {
            puedeSaltar = true;
        }
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "pared")
        {
            this.enabled = false;
            SceneManager.LoadScene(0);
        }
    }

    private void Saltar()
    {
        rb.AddForce(Vector3.up * fuerzaSalto);
        puedeSaltar = false;
    }

    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 500 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 500 * Time.deltaTime);
        }

        transform.Translate(Vector3.forward * 5 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && puedeSaltar)
        {
            Saltar();
        }
    }
}
