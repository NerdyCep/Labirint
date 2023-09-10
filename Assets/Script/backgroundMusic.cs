using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip backgroundMusic; // Здесь вы можете присвоить аудиоклип для фоновой музыки
    private AudioSource audioSource;

    private void Start()
    {
        // Создаем компонент AudioSource на этом объекте, если его еще нет
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Присваиваем аудиоклип для фоновой музыки
        audioSource.clip = backgroundMusic;

        // Настраиваем параметры аудио (по желанию)
        audioSource.volume = 0.5f; // Громкость музыки (от 0 до 1)
        audioSource.loop = true; // Воспроизводить музыку в цикле

        // Воспроизводим музыку
        audioSource.Play();
    }

    // Вы можете добавить другие методы для управления музыкой, такие как пауза, остановка и др.
    // Пример метода для приостановки музыки:
    public void PauseMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    // Пример метода для возобновления музыки после паузы:
    public void ResumeMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.UnPause();
        }
    }
}
