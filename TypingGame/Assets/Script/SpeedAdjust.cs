using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedAdjust : MonoBehaviour
{
    public Slider ChangeSpeed;

    public void wordSpeed (float value)
    {
        WordDisplay.fallSpeed = ChangeSpeed.value;
    }
}
