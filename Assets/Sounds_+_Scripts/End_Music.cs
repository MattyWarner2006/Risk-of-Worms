using UnityEngine;

public class End_Music : MonoBehaviour
{
   public Audio_Manager music;


   public void Start()
   {
      // play end screen music
      music.EndMusic();
   }
}
