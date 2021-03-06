﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected float health;

    public bool canBeJuggled; 

    protected float stunTime;
    protected float startStunTime = 0;

    protected float knockUpstunTime;
    protected float knockUptartStunTme = 0;

    protected Animator _animator;
    protected CharacterController _controller;

    protected bool useGravity = true;

    protected bool isDead = false;
    public bool knockedUp;

    //Static variables are shared across all instances
    //of a class.
    public static int enemyCount = 0;

   protected virtual void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();
    }

    public Enemy()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        enemyCount++;
    }

    void OnDestroy() 
    {
        enemyCount--;
    }


    public void Damage(int damage, Vector3 hitPos)
    {
     
      
        OnDamage(damage, hitPos);


    }


    public void AirDamage(int damage, Vector3 hitPos, float stunLength, float knockUpForce)
    {

       // print("ONAIRDAMAGE");
        OnKnockUpDamage(  damage, hitPos, stunLength,  knockUpForce);

       

      
    }


    protected virtual void OnDamage(int damage, Vector3 hitPos)
    {


        //play effects
    }


    protected virtual void OnKnockUpDamage(int damage, Vector3 hitPos, float stunLenth, float KnockUpHeight)
    {



        //knockup
    }

}
