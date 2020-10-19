using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crystal : MonoBehaviour
{
    public Text CHPOutput = null;

    private int hp = 100;
    void Start()
    {
        CHPOutput.text = "" + hp; 
    }

    
    void Update()
    {
        
    }
}
