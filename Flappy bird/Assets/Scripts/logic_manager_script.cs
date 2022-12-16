using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic_manager_script : MonoBehaviour
{
    public int score;
    public Text score_text;
    public GameObject game_over_screen;
    public bool bird_alive = true;

    [ContextMenu("Increase Score")]
    public void add_score(int score_to_add)
    {
        if (bird_alive == true)
        {
            score += score_to_add;
            score_text.text = score.ToString();
        }
    }

    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void game_over_function()
    {
        bird_alive = false;
        game_over_screen.SetActive(true);
    }

}
