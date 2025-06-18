using BepInEx;
using UnityEngine;

namespace WindowedMonke {
    [BepInPlugin("com.squid.windowedmonke", "WindowedMonke", "1.0.0")]
    public class WindowedMonke : BaseUnityPlugin
    {
        void Start()
        {
            Screen.SetResolution(1280, 720, false);
        }
    }
}
