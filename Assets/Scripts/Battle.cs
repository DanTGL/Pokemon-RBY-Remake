using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour {

    public Player player;
    public Enemy enemy;

    public HealthBar playerHealth;
    public HealthBar enemyHealth;

    void Start() {
        playerHealth.pokemon = player.GetPokemon();
        enemyHealth.pokemon = enemy.GetPokemon();
    }

    bool battleOver = false;

    void EndBattle() {
        battleOver = true;
    }

    public void PlayerLost() {
        Debug.Log("You lost!");

        EndBattle();
    }

    public void PlayerWon() {
        Debug.Log("You won!");

        EndBattle();
    }

    private bool pressed = false;

    void UpdateHealthBars() {
        playerHealth.UpdateHealthBar();
        enemyHealth.UpdateHealthBar();
    }

    public IEnumerator PlayerChooseMove(Move move) {
        if (pressed || battleOver) yield break;
        pressed = true;

        Move trainerMove = enemy.ChooseMove(player.GetPokemon());
        
        if (enemy.GetPokemon().speed > player.GetPokemon().speed) {
            bool defeated = trainerMove.UseMove(enemy.GetPokemon(), player.GetPokemon());

            Debug.Log("Enemy HP: " + enemy.GetPokemon().hp);

            UpdateHealthBars();

            yield return new WaitForSeconds(2.0f);

            if (defeated) {
                PlayerLost();
            } else {
                defeated = move.UseMove(player.GetPokemon(), enemy.GetPokemon());

                Debug.Log("Player HP: " + player.GetPokemon().hp);
                UpdateHealthBars();

                if (defeated) {
                    PlayerWon();
                }
            }
            
        } else {
            bool defeated = move.UseMove(player.GetPokemon(), enemy.GetPokemon());

            Debug.Log("Player HP: " + player.GetPokemon().hp);
            UpdateHealthBars();

            yield return new WaitForSeconds(2.0f);

            if (defeated) {
                PlayerWon();
            } else {
                defeated = trainerMove.UseMove(enemy.GetPokemon(), player.GetPokemon());
                
                Debug.Log("Enemy HP: " + enemy.GetPokemon().hp);
                UpdateHealthBars();

                if (defeated) {
                    PlayerLost();
                }
            }
        }

        pressed = false;
    }

    public void MoveButton(int moveIndex) {

        StartCoroutine(PlayerChooseMove(player.GetPokemon().moves[moveIndex]));
    }

}
