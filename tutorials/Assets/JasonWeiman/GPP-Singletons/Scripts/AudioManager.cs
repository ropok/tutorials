using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
        _audioSource = GetComponent<AudioSource>();
    }

    private Queue<AudioSource> _audioSources = new Queue<AudioSource>();
    private AudioSource _audioSource;

    public void PlayClipAtPoint(AudioSource clip, Vector3 point)
    {
        // Some implementation here using the queue
    }

    private void OnEnable()
    {
        if (transform.childCount > 0)
        {
            return;
        }

        for (int i = 0; i < 10; i++)
        {
            var audioSourceGameObject = new GameObject("AudioSource " + i);
            audioSourceGameObject.transform.SetParent(transform);
            var audioSource = audioSourceGameObject.AddComponent<AudioSource>();
            _audioSources.Enqueue(audioSource);
        }
    }
}

public class LazyInstantiatedSingleton<T> : MonoBehaviour
{

}