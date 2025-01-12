using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GambleWheel : MonoBehaviour
{
    public float rotatePower;
    public float stopPower;
    
    
    
    public GameObject wheel;
    // Start is called before the first frame update
    void Start()
    {
        wheel.transform.Rotate(0, 0, 400 * Time.deltaTime);
        //wheel.transform.rotation(0, 0, 90);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
