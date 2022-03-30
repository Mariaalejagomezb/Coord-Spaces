using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscilacionSimple2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Range(0, 10)]
    float amplitud = 1;
    [SerializeField]
    [Range(0, 10)]
    float periodo = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(0, amplitud * Mathf.Sin(Time.time * periodo)) ;
    }
}
