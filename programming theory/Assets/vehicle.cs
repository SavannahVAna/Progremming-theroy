using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    private int _year = 1;
    public int year
    {
        get { return _year;}
        set {
            if (value >= 0)
            {
                _year = value;
            }
        }
    }
    // Start is called before the first frame update

    public virtual void Move(){}
}
