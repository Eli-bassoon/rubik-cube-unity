using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CubeNumber : MonoBehaviour
{
    [SerializeField] Color[] numColors;
    TextMeshPro text;

    private void Awake()
    {
        text = GetComponent<TextMeshPro>();
        SetNumber(1);
    }

    public void SetNumber(int n)
    {
        text.text = n.ToString();
        if (n == 6 || n == 9)
        {
            text.text = $"<u>{text.text}</u>";
        }

        if (n-1 < numColors.Length)
        {
            text.color = numColors[n-1];
        }
        else
        {
            text.color = new Color(1, 0, 1);
        }
    }
}
