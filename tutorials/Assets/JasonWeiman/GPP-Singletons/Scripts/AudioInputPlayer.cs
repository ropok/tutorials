using UnityEngine;

public class AudioInputPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioClip;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            AudioManager.Instance.PlayClipAtPoint(_audioClip, Vector3.zero);
    }
}
