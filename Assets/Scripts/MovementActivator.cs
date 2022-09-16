using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
         if (other == player.GetComponent<Collider>()) {
            objectToActivate.GetComponent<MoveObject>().enabled = true;
            objectToActivate.GetComponent<RotateObject>().enabled = false;
         }
     }
     
     void OnTriggerExit(Collider other) {
         if (other == player.GetComponent<Collider>()) {
            objectToActivate.GetComponent<MoveObject>().enabled = false;
            objectToActivate.GetComponent<RotateObject>().enabled = true;
         }
     }
}
