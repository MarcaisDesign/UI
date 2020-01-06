// =======================================================================================
// UIRoot
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using wovencode;
using UnityEngine;

namespace wovencode
{

	// ===================================================================================
	// UIRoot
	// ===================================================================================
	public abstract partial class UIRoot : UIBase
	{
	
		[Header("UI Throttle")]
		[Range(0.01f, 3f)]
		public float updateInterval = 0.25f;
		
		protected float fInterval;
		
		// -------------------------------------------------------------------------------
		// Update is called every frame
		// Private to prevent child classes from using it
		// -------------------------------------------------------------------------------
		void Update()
		{
			if (Time.time > fInterval || fInterval <= 0)
			{
				ThrottledUpdate();
				fInterval = Time.time + updateInterval;
			}
		}
		
		// -------------------------------------------------------------------------------
		// ThrottledUpdated is called once per updateInterval
		// Protected to allow child classes to use it 
		// -------------------------------------------------------------------------------
		protected virtual void ThrottledUpdate() {}
        
        // -------------------------------------------------------------------------------
        
	}

}