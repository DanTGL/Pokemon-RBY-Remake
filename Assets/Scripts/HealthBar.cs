using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Pokemon pokemon;

    Image image;

    private int prevHp;

    void Start() {
        image = GetComponent<Image>();
    }

    public void UpdateHealthBar() {
        if (pokemon.hp == prevHp) return;
        //Debug.Log(pokemon.hp / pokemon.maxHp);
        image.fillAmount = Mathf.Max(0.0f, (float) pokemon.hp / (float) pokemon.maxHp);
        prevHp = pokemon.hp;
    }
}
