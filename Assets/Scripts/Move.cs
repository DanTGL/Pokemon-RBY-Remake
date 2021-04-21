using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Move {

    public byte id;
    public String name;
    public byte effect;
    public byte type;
    public byte power;
    public byte accuracy;
    public byte pp;
    
    public Move(byte power) {
        this.power = power;
    }

    float GetEffectiveness(Pokemon enemy) {
        // TODO: Implement effectiveness check
        return 1;
    }

    ushort CalculateDamage(Pokemon user, Pokemon enemy) {
        return (ushort) ((((2 * user.level) / 5 + 2) * power * (user.attack / enemy.defense) / 50 + 2) * GetEffectiveness(enemy));
    }

    public bool UseMove(Pokemon user, Pokemon enemy) {
        bool defeatedEnemy = false;
        ushort damage = CalculateDamage(user, enemy);

        if (damage >= enemy.hp) {
            defeatedEnemy = true;
        }

        enemy.Damage(damage);

        return defeatedEnemy;
    }
}
