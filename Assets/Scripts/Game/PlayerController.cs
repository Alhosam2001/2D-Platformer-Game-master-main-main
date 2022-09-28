﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed, jumpPower;

    public Animator anim;

    public Transform keyFollowPoint;
    public Transform Information;

    public Transform firstPosition;
    public Transform secondPosition;
    public Transform thirdPosition;
    public Transform forthPosition;

    public Key followingKey;

    public Information followInfo;

    public TomatoSign firstPos;
    public TomatoSign2 secondPos;
    public TomatoSign3 thirdPos;
    public TomatoSign4 forthPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { }
}
