using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace BrokenVector.BrokenUtils.Editor
{
	public static class EditorGUIUtils
	{

	    public static GUIStyle GetEditorStyle(string name)
	    {
	        return EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector).GetStyle(name);
	    }

	}
}