using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscilacionRuido : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Range(0, 10)]
    float amplitud = 1;
    [SerializeField]
    [Range(0, 10)]
    float periodo = 1;
    
    float variablex, variabley;
    void Start()
    {
        variablex = Random.Range(-5,5);
        variabley = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time)*variablex, variabley*amplitud * Mathf.Sin(Time.time * periodo)+Mathf.Cos(periodo));
    }
}
