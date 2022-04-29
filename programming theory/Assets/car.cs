using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : vehicle
{
    private Vector3 bruh= new Vector3(0, 0, 0);

    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("ChangeVector", 0.5f, 3f);
        InvokeRepeating("Move", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move()
    {
        rb.AddForce(bruh*20,ForceMode.Impulse);
    }
    
    private void ChangeVector()//ABSTRACTION
    {
        var posX = Random.Range(-1f, 1f);
        var posZ = Random.Range(-1f, 1f);
        bruh = new Vector3(posX, 0, posZ);
    }
}
