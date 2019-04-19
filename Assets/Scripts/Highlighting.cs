using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighting : MonoBehaviour
{
    public GameObject button;
    public int FloorNumber;
    public static int DestFloor;
        // Start is called before the first frame update
    void Start()
    {
        DestFloor = 1;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("1"))
        {
            button.GetComponent<Renderer>().material.color = new Color32(255, 189, 0, 255);
            DestFloor = 1;
        }
        if (Input.GetKeyDown("2"))
        {
            button.GetComponent<Renderer>().material.color = new Color32(255, 255, , 255);
            DestFloor = 2;
        }*/
    }


    
    void OnTriggerEnter(Collider other)
    {
        button.GetComponent<Renderer>().material.color = new Color32(255, 189, 0, 255);
        DestFloor = FloorNumber;
    }

}
