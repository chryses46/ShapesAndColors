using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShapesAndColors{
    public class CameraColor : MonoBehaviour
    {
        Camera mainCam;
        List<Color> colorList = new List<Color>(){
            Color.magenta,
            Color.cyan
        };

        void Awake()
        {
            mainCam = GetComponent<Camera>();
            mainCam.clearFlags = CameraClearFlags.SolidColor;
        }

        void Update()
        {
            float duration = 3f;
            float t = Mathf.PingPong(Time.time, duration) / duration;
            mainCam.backgroundColor = Color.Lerp(colorList[0], colorList[1], t);
        }
    }
}
