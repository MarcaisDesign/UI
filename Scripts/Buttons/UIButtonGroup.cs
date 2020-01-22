// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Wovencode;
using Wovencode.UI;

namespace Wovencode.UI
{
	
	// ===================================================================================
	// UIButtonGroup
	// ===================================================================================
	public partial class UIButtonGroup : MonoBehaviour
	{
	
		[HideInInspector] public List<UIButton> buttons = new List<UIButton>();
		
		// -------------------------------------------------------------------------------
		public void Clear()
		{
			buttons.Clear();
		}
		
		// -------------------------------------------------------------------------------	
		public void Add(UIButton button)
		{
			buttons.Add(button);
		}
		
		// -------------------------------------------------------------------------------
		public void OnPressed(UIButton _button)
		{
			foreach (UIButton button in buttons)
				button.OnPressed(button != _button);
		}
		
		// -------------------------------------------------------------------------------
		public void HideOthers(GameObject keepActive)
		{
		
		}
		
		// -------------------------------------------------------------------------------
	}

}

// =======================================================================================
