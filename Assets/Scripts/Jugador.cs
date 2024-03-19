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

    void update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released");
            if (GetComponent<Rigidbody>() != null){
                GetComponent<Rigidbody>().useGravity = true;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Meta")
        {
            this.enabled = false;
            SceneManager.LoadScene(3);
        }
        
        if(collision.gameObject.tag == "pared")
        {
            this.enabled = false;
            SceneManager.LoadScene(2);
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
            SceneManager.LoadScene(2);
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
            GetComponent<Rigidbody>().AddForce(Vector3.left * 600 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 600 * Time.deltaTime);
        }

        transform.Translate(Vector3.forward * 10 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && puedeSaltar)
        {
            Saltar();
        }
    }
}
