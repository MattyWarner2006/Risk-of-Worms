using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource sfxSource;

    [Header("Audio Clip")]
    public AudioClip mainMenu;
    public AudioClip background;
    public AudioClip enemyEaten;
    public AudioClip endMusic;
    

    public void MainMenu()
    {
        musicSource.clip = mainMenu;
        musicSource.Play();
    }

    public void BackgroundMusic()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void EatEnemy()
    {
        sfxSource.clip = enemyEaten;
        sfxSource.Play();
    }

    public void EndMusic()
    {
        musicSource.clip = endMusic;
        musicSource.Play();
    }


}
