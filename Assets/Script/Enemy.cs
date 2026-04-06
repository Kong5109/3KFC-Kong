using UnityEngine;

public class Enemy : MonoBehaviour
{
    //attributes
    float health = 100;
    float speed = 1;
    float strength = 10;
    bool isDead = false;

    //Public Property
    public float Health { get => health; private set => health = Mathf.Clamp(value, 0, 100); }
    public float Speed { get => speed; private set => speed = Mathf.Clamp(value, 0, 10); }
    public float Strength { get => strength; private set => strength = Mathf.Clamp(value, 0 ,100); }

}
