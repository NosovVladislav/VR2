using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    // Start is called before t
    // he first frame update
    public Text text;
    public string a ="Это сверлильный станок";
    private void Start()
    {

    }
    public void Butclick()
    {
        text.text = a;
        Debug.Log(1);
    }
}
