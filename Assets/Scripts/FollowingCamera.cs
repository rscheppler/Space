using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [Tooltip("Drag the object from the hierarchy tab into this slot that you want the camera to follow")]
    public GameObject Target;
    [Tooltip("Set between 0 and one kinda how fast it moves to the target"), Range(0,1)]
    public float LerpVal = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //fixed update runs once per physics frame
    private void FixedUpdate()
    {
        if(Target != null)
        {
            //calculate where the camera is moving towards
            Vector3 newPos = Target.transform.position;
            newPos.z = transform.position.z;
            //lerp towards the target to make a smoothing effect in the movement
            transform.position = Vector3.Lerp(transform.position, newPos, LerpVal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
