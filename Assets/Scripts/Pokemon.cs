using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon {

    public Move[] moves;
    public int hp;
    public int maxHp;
    public int attack;
    public int defense;
    public int speed = 5;

    public int level = 1;

    public Pokemon(int hp, int attack, int defense, int speed, int level) {
        this.hp = hp;
        this.maxHp = hp;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.level = level;

        moves = new Move[4];
        for (int i = 0; i < 4; i++) {
            moves[i] = new Move((byte)UnityEngine.Random.Range(1, 50));
        }
    }

    public void SetHP(int hp) {
        this.hp = hp;
    }

    public void Damage(int damage) {
        this.hp -= damage;
    }
}
