using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomStat : MonoBehaviour
{
    public delegate void RandomStatDelegate();
    public static event RandomStatDelegate randomStatEvent;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomStats()
    {
        randomStatEvent();
    }
}
