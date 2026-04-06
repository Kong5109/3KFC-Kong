using UnityEngine;

public abstract class Abstrac_SO_BasicGun : ScriptableObject
{
    [field: Header("Bullet Attribute")]
    [field: SerializeField] public Bullet Bullet { get; protected set; }
    [field: SerializeField] public float Speed { get; protected set; }
    [field: SerializeField] public float Damage { get; protected set; }

    [field: Header("Gun Attribute")]
    [field: SerializeField] public float Reload { get; protected set; }
}
