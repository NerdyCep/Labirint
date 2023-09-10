using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip backgroundMusic; // ����� �� ������ ��������� ��������� ��� ������� ������
    private AudioSource audioSource;

    private void Start()
    {
        // ������� ��������� AudioSource �� ���� �������, ���� ��� ��� ���
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // ����������� ��������� ��� ������� ������
        audioSource.clip = backgroundMusic;

        // ����������� ��������� ����� (�� �������)
        audioSource.volume = 0.5f; // ��������� ������ (�� 0 �� 1)
        audioSource.loop = true; // �������������� ������ � �����

        // ������������� ������
        audioSource.Play();
    }

    // �� ������ �������� ������ ������ ��� ���������� �������, ����� ��� �����, ��������� � ��.
    // ������ ������ ��� ������������ ������:
    public void PauseMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    // ������ ������ ��� ������������� ������ ����� �����:
    public void ResumeMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.UnPause();
        }
    }
}
