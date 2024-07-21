using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Vector3 offSet;
    public float lookOffset;
    public GameObject player;
    private Vector3 playerPos;
    public float DistToPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

        transform.position = playerPos + offSet;

        transform.LookAt(playerPos);
    }
}
