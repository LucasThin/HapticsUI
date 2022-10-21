using System.Collections;
using System.Collections.Generic;
using Bhaptics.SDK2;
using UnityEngine;

public class hapticsUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonHover()
    {
        BhapticsLibrary.Play("button");
    }

    public void ScrollRight()
    {
        BhapticsLibrary.Play("scrollright");
    }

    public void ScrollDown()
    {
        BhapticsLibrary.Play("scrolldown");
    }
}
