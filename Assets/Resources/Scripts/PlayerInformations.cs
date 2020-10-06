using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerInformations : NetworkBehaviour
{
    public string name;

    [Command]
    void CmdName () { }
}
