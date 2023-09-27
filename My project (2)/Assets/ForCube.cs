using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
   
    public GameObject sphere;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            a = Random.Range(0, 255);
            b= Random.Range(0, 255);
            c = Random.Range(0, 255);
            this.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 1);
        }
       

    }
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnMouseEnter()
    {
        sphere.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
    private void OnMouseExit()
    {
        sphere.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

}
