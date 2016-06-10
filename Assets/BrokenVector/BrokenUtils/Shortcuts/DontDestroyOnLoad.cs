using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BrokenVector.BrokenUtils.Shortcuts
{
    /// <summary>
    /// Prevent that this GameObject, gets destroyed when loading a new scene.
    /// </summary>
	public class DontDestroyOnLoad : MonoBehaviour 
	{
	    void Start()
	    {
	        DontDestroyOnLoad(this.gameObject);
	    }
    }
}