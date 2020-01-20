using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingStatusEffect : StatusEffect
{
    public override void GrantStatusEffect()
    {
        Debug.Log("works");
    }

    public override void PlayAnimation()
    {
        Debug.Log("play animations");
    }
}
