using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour
{
    public float speed;



    void Update()
    {
        transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime * speed);
    }
}
