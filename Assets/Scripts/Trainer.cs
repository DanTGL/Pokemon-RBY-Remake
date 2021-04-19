using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : Enemy {

    public byte curPokemon = 0;

    public Pokemon[] pokemon;

    public override Pokemon GetPokemon() {
        return pokemon[curPokemon];
    }

    void Mod1() {

    }

    public override Move ChooseMove(Pokemon enemy) {
        return pokemon[curPokemon].moves[0];
    }

}
