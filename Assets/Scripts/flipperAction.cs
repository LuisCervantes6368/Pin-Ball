using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperAction : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;

  

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;


    }

    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName)==1){
            spring.targetPosition = pressedPosition;
            
        }   
        else{
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
