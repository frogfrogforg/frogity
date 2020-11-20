using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyRandomForce : MonoBehaviour
{
    public float AngleVariance;
    public float ForceIntensity;
    public KeyCode key = KeyCode.R;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(key)) {
            var randomAngle = Mathf.Deg2Rad * Random.Range(-AngleVariance/2, AngleVariance/2);
            GetComponent<Rigidbody2D>()
            .AddForce(new Vector2(0, 1) * ForceIntensity);
        }
    }
}
