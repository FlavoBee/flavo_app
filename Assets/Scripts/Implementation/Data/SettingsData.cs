using UnityEngine;

namespace Flavo
{
    [System.Serializable]
    public class SettingsData : ISettingsData
    {
        private const bool DEFAULT_AUDIO_MUTE_VALUE = false;
        private const float DEFAULT_AUDIO_VOLUME_VALUE = 0.8f;

        public bool AudioMute
        {
            get => _audioMute;
            set => _audioMute = value;
        }

        public float AudioVolume
        {
            get => _audioVolume;
            set => _audioVolume = value;
        }

        [SerializeField]
        private bool _audioMute = DEFAULT_AUDIO_MUTE_VALUE;

        [SerializeField, Range(0f, 1f)]
        private float _audioVolume = DEFAULT_AUDIO_VOLUME_VALUE;
    }
}
