﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBehaviour : MonoBehaviour
{
    [SerializeField] private LayerMask ground;
    private Animator myAnimator;
    public float BumpValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (ground == (ground | (1 << other.gameObject.layer)) && other.contacts[0].normal.y >= 0.9f)
        {
            myAnimator.SetBool("Death", true);
        }
        else
        {
            //Debug.Log(other.contacts[0].normal);
        }
    }
}
