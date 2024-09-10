using UnityEngine;

public class SoundAssets : MonoBehaviour
{
    public AudioClip[] backgroundMusicClips;
    public AudioClip[] soundEffectClips;
    public AudioClip[] voiceLines;

    public AudioSource musicSource;
    public AudioSource effectsSource;
    public AudioSource voiceSource;

    // Method to create and play background music
    public void CreateBackgroundMusic()
    {
        if (backgroundMusicClips.Length > 0)
        {
            musicSource.clip = backgroundMusicClips[0]; // Just playing the first clip as an example
            musicSource.loop = true;
            musicSource.Play();
            Debug.Log("Background music started.");
        }
        else
        {
            Debug.LogWarning("No background music clips available.");
        }
    }

    // Method to create and play sound effects
    public void CreateSoundEffects(string effectName)
    {
        AudioClip clip = GetAudioClipByName(effectName, soundEffectClips);
        if (clip != null)
        {
            effectsSource.PlayOneShot(clip);
            Debug.Log("Sound effect played: " + effectName);
        }
        else
        {
            Debug.LogWarning("Sound effect not found: " + effectName);
        }
    }

    // Method to create and play voice lines
    public void RecordVoiceLines(string voiceLineName)
    {
        AudioClip clip = GetAudioClipByName(voiceLineName, voiceLines);
        if (clip != null)
        {
            voiceSource.PlayOneShot(clip);
            Debug.Log("Voice line played: " + voiceLineName);
        }
        else
        {
            Debug.LogWarning("Voice line not found: " + voiceLineName);
        }
    }

    // Helper method to find an AudioClip by name
    private AudioClip GetAudioClipByName(string name, AudioClip[] clips)
    {
        foreach (var clip in clips)
        {
            if (clip.name == name)
            {
                return clip;
            }
        }
        return null;
    }
}
