using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class plane : vehicle //INHERITANCE
{
    private Vector3 bruh= new Vector3(0, 0, 0);

    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("ChangeVector", 0.5f, 3f);
        InvokeRepeating("Move", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void ChangeVector()//ABSTRACTION
    {
        var posX = Random.Range(-1f, 1f);
        var posY = Random.Range(-1f, 1f);
        var posZ = Random.Range(-1f, 1f);
        bruh = new Vector3(posX, posY, posZ);
    }

    public override void Move() //POLYMORPHISM
    {
        rb.AddForce(bruh*10,ForceMode.Force);
    }
}
