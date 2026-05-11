using UnityEngine;

public class Menu_Music : MonoBehaviour
{
    public Audio_Manager music;
    
    public void Start()
    {
        music.MainMenu();
    }
}
