﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScriptUno : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("JumpTrigger");
        }
    }
}
