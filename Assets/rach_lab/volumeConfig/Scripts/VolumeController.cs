using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace rachLab
{
    public class VolumeController : MonoBehaviour
    {
        [SerializeField]
        string paramaterName;

        [SerializeField]
        AudioMixer audioMixer;

        Slider slider;

        private void Awake() {
            slider = gameObject.GetComponent<Slider>();

            // ミキサーの初期値でスライダーを初期化する
            float initValue;
            if (audioMixer.GetFloat(paramaterName, out initValue)) {
                slider.value = ConvertDecibelToLinear(initValue);
            }
        }

        public float SetVolume
        {
            set { audioMixer.SetFloat(paramaterName, ConvertLinearToDecibel(value)); }
        }

        /// <summary>
        /// リニアな値からデシベル値に変換する
        /// </summary>
        /// <param name="linear">リニアな値</param>
        /// <returns>デシベル値</returns>
        float ConvertLinearToDecibel(float linear) {
            return 20.0f * Mathf.Log10(linear);
        }

        /// <summary>
        /// デシベル値からリニアな値に変換する
        /// </summary>
        /// <param name="decibel">デシベル値</param>
        /// <returns>リニアな値</returns>
        float ConvertDecibelToLinear(float decibel) {
            return Mathf.Pow(10.0f, decibel / 20.0f);
        }
    }
}
