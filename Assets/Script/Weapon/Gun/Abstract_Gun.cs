using System;
using UnityEngine;
public abstract class Abstract_Gun : MonoBehaviour
{
    public event Action OnShoot;
    public event Action OnReload;

    public abstract void Shoot(Bullet bullet,Vector3 spawnPos);

}
