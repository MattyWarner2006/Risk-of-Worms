using TMPro;
using UnityEngine;

public class Score_UI : MonoBehaviour
{
    public Player_Movement player;
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = "Score : " + player.score.ToString();
    }
}
