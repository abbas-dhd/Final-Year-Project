using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoRotation : MonoBehaviour
{
    // Start is called before the first frame update
    private Touch touch;
    private Vector2 touch_position;
    private Quaternion rot_y;
    public float rot_speed;
    public float touch_rot_speed;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved){
                rot_y = Quaternion.Euler(0f,-touch.deltaPosition.x * touch_rot_speed,0f);
                transform.rotation = rot_y * transform.rotation;
            }
        }
        else{
            transform.Rotate(Vector3.up * rot_speed * Time.deltaTime);
        }
    }
}
