using TMPro;
using UnityEngine;

public class Health_UI : MonoBehaviour
{
   
public Player_Movement player;
public TextMeshProUGUI healthText;

   private void Update()
   {
      healthText.text = player.playerHealth.ToString() + " : Health";
   }
}
