using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, ICanMove
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HorizontalMovement(float input)
    {
        Debug.Log(input);
    }

    public void Jump()
    {
        Debug.Log("Jump");
    }
}
