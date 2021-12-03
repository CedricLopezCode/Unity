using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{
    public bool monBool;
    public Material monMaterial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (monBool || monMaterial.color != Color.red) {
            monMaterial.color = Color.red;
        }else if (monBool == false && monMaterial.color == Color.red) {
            monMaterial.color = Color.green;
        }else{
            monMaterial.color = Color.blue;
        }
        
    }
    
}
