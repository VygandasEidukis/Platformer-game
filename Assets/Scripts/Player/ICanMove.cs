using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanMove 
{
    void HorizontalMovement(float input);
    void Jump();
}
