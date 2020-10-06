using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MoveWithPlayerHand : NetworkBehaviour
{
    private GameObject playerHand;

    private void Awake()
    {
        playerHand = PlayerManager.Inst.GetPlayerHand();
    }

    private void Update()
    {
        if (!localPlayerAuthority)
            return;

        if (playerHand.transform.position.z < 1.125 && playerHand.transform.position.z > -1.125)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerHand.transform.position.z);
        }
    }
}
