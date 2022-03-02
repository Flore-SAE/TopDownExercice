using UnityEngine;

[CreateAssetMenu(menuName = "Collections/Sound", fileName = "Sound Collection")]
public class SoundCollection : ScriptableObject
{
    public AudioClip[] clips;

    private int clipIndex;

    private void OnEnable()
    {
        clipIndex = 0;
    }

    public AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    public AudioClip GetNextClip()
    {
        clipIndex = clipIndex++ % clips.Length;
        return GetCurrentClip();
    }

    private AudioClip GetCurrentClip()
    {
        return clips[clipIndex];
    }
}
