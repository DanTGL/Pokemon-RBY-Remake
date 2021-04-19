using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour {

    public Move[] moves;
    public int hp;
    public int attack;
    public int defense;
    public int speed = 5;

    public int level = 1;

    public void SetHP(int hp) {
        this.hp = hp;
    }

    public void Damage(int damage) {
        this.hp -= damage;
    }
}
