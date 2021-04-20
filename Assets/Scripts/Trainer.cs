using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : Enemy {

    public byte curPokemon = 0;

    public Pokemon[] pokemon;

    void Start() {
        pokemon = new Pokemon[1];
        pokemon[0] = new Pokemon(100, 15, 10, 13, 25);
    }

    public override Pokemon GetPokemon() {
        return pokemon[curPokemon];
    }

    void Mod1() {

    }

    public override Move ChooseMove(Pokemon enemy) {
        return pokemon[curPokemon].moves[0];
    }

}
