using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorScript : MonoBehaviour
{
    int MyNumber = 5;

    // Start is called before the first frame update
    void Start()
    {
        MyNumber = 7;
    }

    // Update is called once per frame
    void Update()
    {
        MyNumber = 10;    
    }
}
