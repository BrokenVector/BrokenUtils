using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace BrokenVector.BrokenUtils.Shortcuts
{
    /// <summary>
    /// Loads an scene when the current scene is started.
    /// </summary>
	public class LoadSceneOnLoad : MonoBehaviour 
	{

        public bool Additive = false;
        public string Name;

        void Start()
        {
            SceneManager.LoadScene(Name, Additive ? LoadSceneMode.Additive : LoadSceneMode.Single);
        }

	}
}