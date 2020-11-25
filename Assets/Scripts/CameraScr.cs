using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScr : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, 1.5f, -4);
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
