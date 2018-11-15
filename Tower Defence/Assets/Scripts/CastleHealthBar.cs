using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleHealthBar : MonoBehaviour {

    public float fullHealthBar = 100;
    public float castleHealth;
    public Image castlehealthBar;

    void Start()
    {
        castlehealthBar = GameObject.Find("CastleHealthBar").GetComponent<Image>();

        castleHealth = fullHealthBar;


    }


    void Update()
    {

        castlehealthBar.fillAmount = castleHealth / fullHealthBar;

    }
}
