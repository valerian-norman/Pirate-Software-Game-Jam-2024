using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AreaLightRaycast : MonoBehaviour
{
  public float range;

  public float iIncrement;
  public float iMax;
  public float dirY;
  public float dirX;
  
  public GameObject player;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate(){
      for(float i = 0; i < 1; i += 0.01f) {

        for(dirY = 0f; dirY < iMax;){
        Ray theRay = new Ray(transform.position, transform.TransformDirection(new Vector3(0, i, 1) * range));

        //Vector3 v = Quaternion.AngleAxis(-30, Vector3.up) * new Vector3(1,0,0);
        Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(i, dirY, dirX) * range));
        dirY += iIncrement;
        //dirX -= iIncrement;
      }
      }
      
      
    }
}
