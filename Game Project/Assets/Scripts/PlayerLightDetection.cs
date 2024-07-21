using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLightDetection : MonoBehaviour {
  public GameObject[] playerColliders;
  public Light light;
    // Start is called before the first frame update
    private void Start() {
        //light = FindObjectOfType<Light>();
    }

    // Update is called once per frame
    private void Update() {
        bool isHit = false;

        for (int i = 0; i < playerColliders.Length; i++) {
          RaycastHit hit;
          LayerMask mask = 1 << 8;
          Ray ray = new Ray(playerColliders[i].transform.position, light.transform.position - playerColliders[i].transform.position);
          Debug.DrawRay(playerColliders[i].transform.position, light.transform.position - playerColliders[i].transform.position);
          // if (Physics.Raycast(ray, out hit, 100f, mask)){
          //   Debug.Log(hit.collider.gameObject);
          // }
        }
    }
   
}
