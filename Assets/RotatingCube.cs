using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingCube : MonoBehaviour
{
  public Vector3 editRotation;
  public Keyboard keyboard;


    // Start is called before the first frame update
    void Start()
    {
      keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
    if (keyboard == null)
    {
      Debug.Log("no keyboard");
      return;

    }
    if (keyboard.wKey.isPressed)
    {
      transform.Rotate(editRotation * Time.deltaTime);
      Debug.Log("UPdate after wKey pressed");
    }
  //  transform.Rotate(editRotation); // will rotate for every frame in the scene
    //Debug.Log("Position:" + transform.position);
    }

 

  // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
  private void FixedUpdate()
  {

  }

}
