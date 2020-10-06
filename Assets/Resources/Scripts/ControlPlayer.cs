using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ControlPlayer : NetworkBehaviour
{
    void Update()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z - .5f);
                transform.position = pos;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + .5f);
                transform.position = pos;
            }
        }
    }
}
