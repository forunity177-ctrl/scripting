using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nps : MonoBehaviour
{   
    //здоровье нпс
    int health = 2;
    // уровень нпс
    int level = 4;
    //скорость нпс
    float speed = 1.9f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Здоровье игрока:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
