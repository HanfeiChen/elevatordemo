using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject TheElevator;
    
        public int height;
    public float speed;
 

    public static int DestFloor;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestFloor = Highlighting.DestFloor;
        if (TheElevator.transform.position.y < height * (DestFloor - 1) - 0.01F)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        else if (TheElevator.transform.position.y > height * (DestFloor - 1) + 0.01F)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
       
        
         
        
    }
}
