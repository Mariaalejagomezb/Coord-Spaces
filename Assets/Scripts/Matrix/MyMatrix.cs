using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMatrix : MonoBehaviour
{
    [SerializeField]
    float rotationZ = 0;
    [SerializeField]
    Vector2 scale = Vector2.one;
    [SerializeField]
    Vector2 pos = Vector2.right;

    [SerializeField]
    private Transform someObject;
  
    // Update is called once per frame
    void Update()
    {
       
            //someObject.position = Vector2.right * 4;
            someObject.position = new Vector2(4, 0);
            var myMatrix = Matrix4x4.TRS(pos, Quaternion.Euler(0f, 0f, rotationZ), scale);
            var newPos = myMatrix.MultiplyVector(someObject.position);
            someObject.position = newPos;
        
        


    }
}
