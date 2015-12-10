using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BrokenVector.BrokenUtils
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
            if (!Additive)
                Application.LoadLevel(Name);
            else
                Application.LoadLevelAdditive(Name);
        }

	}
}