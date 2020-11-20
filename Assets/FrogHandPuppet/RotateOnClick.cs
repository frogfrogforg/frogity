using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnClick : MonoBehaviour
{
  public Vector3 TargetRotation;
  private Vector3 initialRotation;
  public float smooth;
  public KeyCode key;

  // Start is called before the first frame update
  void Start()
  {
    initialRotation = transform.rotation.eulerAngles;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(key))
    {
      transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, TargetRotation, smooth * Time.deltaTime);
    }
    else
    {
      transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, initialRotation, smooth * Time.deltaTime);
    }
  }
}
