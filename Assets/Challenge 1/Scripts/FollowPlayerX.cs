﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    // было ...  private Vector3 offset;
    private Vector3 offset = new Vector3(40, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    
    void LateUpdate()   // было... void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
