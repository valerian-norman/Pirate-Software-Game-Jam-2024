using UnityEngine;

public class PlayerLightDetection : MonoBehaviour {
    public GameObject[] playerColliders;
    public Light lightSource;
    private LayerMask mask = 1 << 8;

    private void Update() {
        bool isHit = false;

        for (int i = 0; i < playerColliders.Length; i++) {
            RaycastHit hit;
            Ray ray = new Ray(playerColliders[i].transform.position, lightSource.transform.position - playerColliders[i].transform.position);

            if (Physics.Raycast(ray, out hit, 100f, ~mask)){
                Debug.DrawRay(playerColliders[i].transform.position, lightSource.transform.position - playerColliders[i].transform.position, Color.red);
                isHit = true;
                Debug.Log(hit.collider.gameObject);
            }
            else {
                Debug.DrawRay(playerColliders[i].transform.position, lightSource.transform.position - playerColliders[i].transform.position, Color.blue);
            }
        }

        Debug.Log(isHit);
    }
}
