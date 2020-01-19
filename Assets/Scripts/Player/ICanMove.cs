using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerMovement 
{
    void HorizontalMovement(float input);
    void Jump();
}
