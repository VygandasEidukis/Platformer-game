using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatusEffect : MonoBehaviour
{
    public void Process()
    {
        GrantStatusEffect();
        PlayAnimation();
    }

    public abstract void GrantStatusEffect();
    public abstract void PlayAnimation();
}
