using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour {

    public Player player;
    public Enemy enemy;

    public int playerChosenMove = -1;

    public void PlayerLost() {
        Debug.Log("You lost!");
    }

    public void PlayerWon() {
        Debug.Log("You won!");
    }

    public IEnumerator PlayerChooseMove(Move move) {
        Move trainerMove = enemy.ChooseMove(player.GetPokemon());
        
        if (enemy.GetPokemon().speed > player.GetPokemon().speed) {
            bool defeated = trainerMove.UseMove(enemy.GetPokemon(), player.GetPokemon());

            yield return new WaitForSeconds(2.0f);

            if (defeated) {
                PlayerLost();
            } else {
                defeated = move.UseMove(player.GetPokemon(), enemy.GetPokemon());

                if (defeated) {
                    PlayerWon();
                }
            }
            
        } else {
            bool defeated = move.UseMove(player.GetPokemon(), enemy.GetPokemon());

            yield return new WaitForSeconds(2.0f);

            if (defeated) {
                PlayerWon();
            } else {
                defeated = trainerMove.UseMove(enemy.GetPokemon(), player.GetPokemon());
                
                if (defeated) {
                    PlayerLost();
                }
            }
        }
    }

}
