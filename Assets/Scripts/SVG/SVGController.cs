using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SVGController : MonoBehaviour {

    public TextMeshProUGUI valueText;

    public void SetZoom(float value) {
        gameObject.transform.localScale = Vector3.one * value;
        valueText.text = value.ToString("F2");
    }
}
