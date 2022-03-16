using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject target;
    int r1;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 
            
            Vector3 my_pos1 = new Vector3(transform.position.x + 8, transform.position.y + r1 , 0);
            Instantiate(target,my_pos1, transform.rotation);
             
        
    }
}
