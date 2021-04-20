using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Pokemon[] pokemon;
    public int curPokemon = 0;

    void Start() {
        pokemon = new Pokemon[1];
        pokemon[0] = new Pokemon(100, 15, 10, 13, 25);
    }

    public Pokemon GetPokemon() {
        return pokemon[curPokemon];
    }
    
}
