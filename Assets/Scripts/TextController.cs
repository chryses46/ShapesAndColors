using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityEngine.UI;

namespace ShapesAndColors{
    public class TextController : MonoBehaviour
    {
        public Font font;
        private Color GetshapesTextColor{ get; set; }
        private Color GetampTextColor{ get; set; }
        private Color GetcolorsTextColor{ get; set; }
        
        void Awake()
        {
            var welcomeFont = font;
            var welcomeFontSize = 100;

            //Create the UI Canvas
            GameObject canvasGO = new GameObject();
            canvasGO.name = "Canvas";
            canvasGO.AddComponent<Canvas>();
            canvasGO.AddComponent<CanvasScaler>();
            canvasGO.AddComponent<GraphicRaycaster>();

            Canvas canvas;
            canvas = canvasGO.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            //Create the 'Welcome to' text
            GameObject welcomeTextGO = new GameObject();
            welcomeTextGO.name = "WelcomeText";
            welcomeTextGO.transform.parent = canvasGO.transform;
            welcomeTextGO.AddComponent<Text>();

            Text welcomeText;
            welcomeText = welcomeTextGO.GetComponent<Text>();
            welcomeText.text = "Welcome to";
            welcomeText.font = welcomeFont;
            welcomeText.fontSize = welcomeFontSize;
            welcomeText.color = new Color(255, 0, 0);
            welcomeText.alignment = TextAnchor.UpperCenter;

            RectTransform welcomeRectTransform;
            welcomeRectTransform = welcomeText.GetComponent<RectTransform>();
            welcomeRectTransform.localPosition = new Vector3(0, 300, 0);
            welcomeRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the 'Shapes' text
            GameObject shapesTextGO = new GameObject();
            shapesTextGO.name = "ShapesText";
            shapesTextGO.transform.parent = canvasGO.transform;
            shapesTextGO.AddComponent<Text>();

            Text shapesText;
            shapesText = shapesTextGO.GetComponent<Text>();
            shapesText.text = "Shapes";
            shapesText.font = welcomeFont;
            shapesText.fontSize = welcomeFontSize + 5;
            shapesText.color = new Color(0, 255, 0);
            shapesText.alignment = TextAnchor.UpperLeft;

            RectTransform shapesRectTransform;
            shapesRectTransform = shapesText.GetComponent<RectTransform>();
            shapesRectTransform.localPosition = new Vector3(-183.5f, 200f, 0f);
            shapesRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the '&' text
            GameObject ampTextGO = new GameObject();
            ampTextGO.name = "AmpersandText";
            ampTextGO.transform.parent = canvasGO.transform;
            ampTextGO.AddComponent<Text>();

            Text ampText;
            ampText = ampTextGO.GetComponent<Text>();
            ampText.text = "&";
            ampText.font = welcomeFont;
            ampText.fontSize = welcomeFontSize + 5;
            ampText.color = new Color(0, 0, 255);
            ampText.alignment = TextAnchor.UpperCenter;

            RectTransform ampRectTransform;
            ampRectTransform = ampText.GetComponent<RectTransform>();
            ampRectTransform.localPosition = new Vector3(0, 200, 0);
            ampRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the 'Colors!' text
            GameObject colorsTextGO = new GameObject();
            colorsTextGO.name = "ColorsText";
            colorsTextGO.transform.parent = canvasGO.transform;
            colorsTextGO.AddComponent<Text>();

            Text colorsText;
            colorsText = colorsTextGO.GetComponent<Text>();
            colorsText.text = "Colors!";
            colorsText.font = welcomeFont;
            colorsText.fontSize = welcomeFontSize + 5;
            colorsText.color = new Color(255, 255, 0);
            colorsText.alignment = TextAnchor.UpperRight;

            RectTransform colorsRectTransform;
            colorsRectTransform = colorsText.GetComponent<RectTransform>();
            colorsRectTransform.localPosition = new Vector3(172, 200, 1);
            colorsRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the 'Start!' button
            GameObject startButtonGO = new GameObject();
            startButtonGO.name = "StartButton";
            startButtonGO.transform.parent = canvasGO.transform;
            startButtonGO.AddComponent<RectTransform>();
            startButtonGO.AddComponent<Image>();
            startButtonGO.AddComponent<Button>();

            RectTransform startButtonRectTransform;
            startButtonRectTransform = startButtonGO.GetComponent<RectTransform>();
            startButtonRectTransform.localPosition = new Vector3(0, -1, 0);
            startButtonRectTransform.sizeDelta = new Vector2(300, 100);

            ColorBlock startButtonColors;
            startButtonColors = startButtonGO.GetComponent<Button>().colors;
            startButtonColors.normalColor = new Color(255, 0, 0);
            startButtonColors.highlightedColor = new Color(0, 255, 0);
            startButtonColors.pressedColor = new Color(0, 0, 255);

            Button startButton;
            startButton = startButtonGO.GetComponent<Button>();
            startButton.targetGraphic = startButtonGO.GetComponent<Image>();
            startButton.colors = startButtonColors;

            //Create the 'Start!' text in the 'Start!' button
            GameObject startButtonTextGO = new GameObject();
            startButtonTextGO.name = "StartButtonText";
            startButtonTextGO.transform.parent = startButtonGO.transform;
            startButtonTextGO.AddComponent<RectTransform>();
            startButtonTextGO.AddComponent<Text>();

            RectTransform startButtonTextRectTransform;
            startButtonTextRectTransform = startButtonTextGO.GetComponent<RectTransform>();
            startButtonTextRectTransform.anchorMin = new Vector2(0, 0);
            startButtonTextRectTransform.anchorMax = new Vector2(1, 1);
            startButtonTextRectTransform.pivot = new Vector2(0.5f, 0.5f);
            startButtonTextRectTransform.anchoredPosition = new Vector2(0, 0);

            Text startButtonText;
            startButtonText = startButtonTextGO.GetComponent<Text>();
            startButtonText.text = "Start!";
            startButtonText.font = welcomeFont;
            startButtonText.fontSize = welcomeFontSize;
            startButtonText.alignment = TextAnchor.MiddleCenter;
            startButtonText.color = new Color(0, 0, 0);

            //Create the 'Stickers!' button
            GameObject stickersButtonGO = new GameObject();
            stickersButtonGO.name = "StickersButton";
            stickersButtonGO.transform.parent = canvasGO.transform;
            stickersButtonGO.AddComponent<RectTransform>();
            stickersButtonGO.AddComponent<Image>();
            stickersButtonGO.AddComponent<Button>();

            RectTransform stickersButtonRectTransform;
            stickersButtonRectTransform = stickersButtonGO.GetComponent<RectTransform>();
            stickersButtonRectTransform.localPosition = new Vector3(0, -170, 0);
            stickersButtonRectTransform.sizeDelta = new Vector2(450, 100);

            ColorBlock stickersButtonColors;
            stickersButtonColors = stickersButtonGO.GetComponent<Button>().colors;
            stickersButtonColors.normalColor = new Color(0, 0, 255);
            stickersButtonColors.highlightedColor = new Color(0, 255, 0);
            stickersButtonColors.pressedColor = new Color(255, 0, 0);

            Button stickersButton;
            stickersButton = stickersButtonGO.GetComponent<Button>();
            stickersButton.targetGraphic = stickersButtonGO.GetComponent<Image>();
            stickersButton.colors = stickersButtonColors;

            //Create the 'Stickers!' text in the 'Stickers!' button
            GameObject stickersButtonTextGO = new GameObject();
            stickersButtonTextGO.name = "StickersButtonText";
            stickersButtonTextGO.transform.parent = stickersButtonGO.transform;
            stickersButtonTextGO.AddComponent<RectTransform>();
            stickersButtonTextGO.AddComponent<Text>();

            RectTransform stickersButtonTextRectTransform;
            stickersButtonTextRectTransform = stickersButtonTextGO.GetComponent<RectTransform>();
            stickersButtonTextRectTransform.anchorMin = new Vector2(0, 0);
            stickersButtonTextRectTransform.anchorMax = new Vector2(1, 1);
            stickersButtonTextRectTransform.pivot = new Vector2(0.5f, 0.5f);
            stickersButtonTextRectTransform.anchoredPosition = new Vector2(0, 0);

            Text stickersButtonText;
            stickersButtonText = stickersButtonTextGO.GetComponent<Text>();
            stickersButtonText.text = "Stickers!";
            stickersButtonText.font = welcomeFont;
            stickersButtonText.fontSize = welcomeFontSize;
            stickersButtonText.alignment = TextAnchor.MiddleCenter;
            stickersButtonText.color = new Color(0, 0, 0);

            Debug.Log("Welcome to Shapes & Colors!");
        }

        void Update()
        {
        }
    }
}