using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpace : MonoBehaviour
{
  public AudioSource source;
  void Update()
  {
    if (Input.GetKey(KeyCode.R))
    {
      if (!source.isPlaying)
      {
        source.Play();
      }
    }
    else
    {
      source.Pause();
    }
  }
}
