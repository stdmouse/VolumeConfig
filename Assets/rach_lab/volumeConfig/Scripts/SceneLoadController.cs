using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace rachLab
{
    public class SceneLoadController : MonoBehaviour
    {
        [SerializeField]
        string sceneName;
        [SerializeField]
        LoadSceneMode mode;

        public void Load() {
            Scene scene = SceneManager.GetSceneByName(sceneName);
            if (!scene.isLoaded) {
                SceneManager.LoadSceneAsync(sceneName, mode);
            }
        }

        public void UnLoad() {
            SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}