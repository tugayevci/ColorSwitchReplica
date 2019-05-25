using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoButtonsController : MonoBehaviour
{
    public SpriteRenderer sr;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;




    public void ColorCyan()
    {
        PlayerPiano.currentColor = "Cyan";
        sr.color = colorCyan;
    }

    public void ColorYellow()
    {
        PlayerPiano.currentColor = "Yellow";
        sr.color = colorYellow;
    }

    public void ColorMagenta()
    {
        PlayerPiano.currentColor = "Magenta";
        sr.color = colorMagenta;
    }

    public void ColorPink()
    {
        PlayerPiano.currentColor = "Pink";
        sr.color = colorPink;

    }
}
