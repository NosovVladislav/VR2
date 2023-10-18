using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ForSphere : MonoBehaviour
{
    
    public int c;
    public GameObject Sphere1;
    public Text qwe;
    public float Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    
    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        c--;
 
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnCollisionStay(Collision collision)
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
    }

    void FixedUpdate()
    {
        if (c <= 0)
        {
            this.gameObject.SetActive(false);
            qwe.text = "Game Over";
        }
        else
        {
            qwe.text =  c.ToString();
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }




    }

}
