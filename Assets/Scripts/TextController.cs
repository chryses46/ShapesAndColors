using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    void Awake()
    {
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

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
            welcomeText.font = arial;
            welcomeText.fontSize = 60;
            welcomeText.color = new Color(255, 0, 0);
            welcomeText.alignment = TextAnchor.UpperCenter;

            RectTransform welcomeRectTransform;
            welcomeRectTransform = welcomeText.GetComponent<RectTransform>();
            welcomeRectTransform.localPosition = new Vector3(0,300,0);
            welcomeRectTransform.sizeDelta = new Vector2(600,200);

        //Create the 'Shapes' text
            GameObject shapesTextGO = new GameObject();
            shapesTextGO.name = "ShapesText";
            shapesTextGO.transform.parent = canvasGO.transform;
            shapesTextGO.AddComponent<Text>();

            Text shapesText;
            shapesText = shapesTextGO.GetComponent<Text>();
            shapesText.text = "Shapes";
            shapesText.font = arial;
            shapesText.fontSize = 65;
            shapesText.color = new Color(0, 255, 0);
            shapesText.alignment = TextAnchor.UpperLeft;

            RectTransform shapesRectTransform;
            shapesRectTransform = shapesText.GetComponent<RectTransform>();
            shapesRectTransform.localPosition = new Vector3(-1,250,0);
            shapesRectTransform.sizeDelta = new Vector2(600,200);

        //Create the '&' text
            GameObject ampTextGO = new GameObject();
            ampTextGO.name = "AmpersandText";
            ampTextGO.transform.parent = canvasGO.transform;
            ampTextGO.AddComponent<Text>();

            Text ampText;
            ampText = ampTextGO.GetComponent<Text>();
            ampText.text = "&";
            ampText.font = arial;
            ampText.fontSize = 65;
            ampText.color = new Color(0, 0, 255);
            ampText.alignment = TextAnchor.UpperCenter;

            RectTransform ampRectTransform;
            ampRectTransform = ampText.GetComponent<RectTransform>();
            ampRectTransform.localPosition = new Vector3(0,250,0);
            ampRectTransform.sizeDelta = new Vector2(600,200);

        //Create the 'Colors!' text
            GameObject colorsTextGO = new GameObject();
            colorsTextGO.name = "ColorsText";
            colorsTextGO.transform.parent = canvasGO.transform;
            colorsTextGO.AddComponent<Text>();

            Text colorsText;
            colorsText = colorsTextGO.GetComponent<Text>();
            colorsText.text = "Colors!";
            colorsText.font = arial;
            colorsText.fontSize = 65;
            colorsText.color = new Color(255, 255, 0);
            colorsText.alignment = TextAnchor.UpperRight;

            RectTransform colorsRectTransform;
            colorsRectTransform = colorsText.GetComponent<RectTransform>();
            colorsRectTransform.localPosition = new Vector3(0,250,1);
            colorsRectTransform.sizeDelta = new Vector2(600,200);

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
            startButtonRectTransform.sizeDelta = new Vector2(300,100);

            ColorBlock startButtonColors;
            startButtonColors = startButtonGO.GetComponent<Button>().colors;
            startButtonColors.normalColor = new Color(255,0,0);
            startButtonColors.highlightedColor = new Color(0,255,0);
            startButtonColors.pressedColor = new Color(0,0,255);

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
            startButtonTextRectTransform.anchorMin = new Vector2(0,0);
            startButtonTextRectTransform.anchorMax = new Vector2(1,1);
            startButtonTextRectTransform.pivot = new Vector2(0.5f, 0.5f);
            startButtonTextRectTransform.anchoredPosition = new Vector2(0,0);

            Text startButtonText;
            startButtonText = startButtonTextGO.GetComponent<Text>();
            startButtonText.text = "Start!";
            startButtonText.font = arial;
            startButtonText.fontSize = 60;
            startButtonText.alignment = TextAnchor.MiddleCenter;
            startButtonText.color = new Color(0,0,0);

            


        Debug.Log("Welcome to Shapes & Colors!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
