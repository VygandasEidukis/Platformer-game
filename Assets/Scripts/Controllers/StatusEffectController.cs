using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Collider2D))]
public class StatusEffectController : MonoBehaviour
{
    [SerializeField] GameObject _self;
    private Collider2D _collider;
    private List<StatusEffect> _statusEffects;
    

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<Collider2D>();
        _statusEffects = new List<StatusEffect>();
        foreach(var comp in GetComponents<StatusEffect>())
        {
            _statusEffects.Add(comp);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        for(int i = 0; i < _statusEffects.Count; i++)
        {
            _statusEffects[i].Process();
        }
        CleanObject();
    }

    private void CleanObject()
    {
        Destroy(_self);
    }
}
