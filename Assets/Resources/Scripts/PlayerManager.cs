using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    static private PlayerManager _inst;
    static public PlayerManager Inst
    {
        get { return _inst; }
    }

    private GameObject _player;
    public GameObject player
    {
        get { return _player; }
    }

    private void Awake()
    {
        _inst = this;
    }

    /// <summary>
    /// Fonction permettant de récupérer le sous-objet du prefab effectuant le tracking de la main,
    /// déterminée par le booléen passé en paramètre. Par défaut, la main droite est renvoyée.
    /// </summary>
    /// <param name="side">Booléen déterminant la main à récupérer.
    /// True: la main droite est renvoyée.
    /// False: la main gauche est renvoyée.</param>
    /// <returns></returns>
    public GameObject GetPlayerHand(bool rightHand=true)
    {
        GameObject trackingSpace = transform.GetChild(1).GetChild(0).gameObject;

        if (rightHand)
            return trackingSpace.transform
                .GetChild(5)    // RightHandAnchor
                .gameObject;
        else
            return trackingSpace.transform
                .GetChild(4)    // LeftHandAnchor
                .gameObject;
    }
}
