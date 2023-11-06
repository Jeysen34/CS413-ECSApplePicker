using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = Unity.Mathematics.Random;
using Unity.Entities;


public class AppleSpawnAuthoring : MonoBehaviour
{
    public GameObject applePrefab;
    public Random Random;
    public float appleDropDelay = 1f;

    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

}
