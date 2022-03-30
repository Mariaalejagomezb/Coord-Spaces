using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilations : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The prefab that will be instantiated a lot")]
    GameObject prefab;
    [SerializeField]
    [Tooltip("The total instances")]
    int nSamples = 300;
    [SerializeField]
    [Range(0, 1)]
    float separationFactor = 1;
    [SerializeField]
    [Range(0, 10)]
    float amplitud = 1;
    [SerializeField]
    [Range(0, 10)]
    float periodo = 1;
    
    // Start is called before the first frame update
    private void Start()
    { for (int i = 0; i < nSamples; i++)
        {
            var child = Instantiate(prefab, transform);
            child.transform.localPosition = new Vector2(0, 0);
            child.transform.localPosition = new Vector2(i / 8f, Mathf.Sin(i / 8f));
        }


    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach (Transform child in transform)

        {
            float x = i * separationFactor;
            child.localPosition = new Vector2(x, amplitud * Mathf.Sin((x*2*Mathf.PI/periodo)+Time.time));
            ++i;
        }        
       
    }
}
