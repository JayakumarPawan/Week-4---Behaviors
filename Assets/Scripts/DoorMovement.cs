using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 open_pos;
    [SerializeField] Vector3 close_pos;
    bool open;
    bool close;
    int animation_frames = 50;
    float cur_frame = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(open){
            gameObject.transform.localPosition = Vector3.Lerp(close_pos,open_pos, cur_frame/animation_frames);
            cur_frame++;
            if(gameObject.transform.localPosition == open_pos){
                cur_frame = 0;
                open = false;
            }
        }
        if(close){
            gameObject.transform.localPosition = Vector3.Lerp(open_pos, close_pos, cur_frame/animation_frames);
            cur_frame++;
            if(gameObject.transform.localPosition == close_pos){
                cur_frame = 0;
                close = false;
            }
        }   
    }

    void OnTriggerEnter(Collider other) {
         if (other == player.GetComponent<Collider>()) {
            open = true;
            //gameObject.transform.localPosition = open_pos;
         }
     }
     
     void OnTriggerExit(Collider other) {
         if (other == player.GetComponent<Collider>()) {
            close = true;
            //gameObject.transform.localPosition = close_pos;
         }
     }
}
