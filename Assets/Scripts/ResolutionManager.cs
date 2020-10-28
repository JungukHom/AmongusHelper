namespace Marucorp.AmongusHelper
{
    // C#
    using System.Collections;
    using System.Collections.Generic;

    // Unity
    using UnityEngine;

    // Project
    // Alias

    public class ResolutionManager : MonoBehaviour
    {
        private void Awake()
        {
            Screen.SetResolution(1600, 900, false);
            Screen.fullScreen = false;
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
    }
}