using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeedTest : MonoBehaviour {
    
    public string seed = "";
    public float min;
    public float max;
    private float clicks = 0;

    public TextMeshPro boxText;
    public TextMeshProUGUI clickText;


	void Start () {
        ChangeSeed(seed);
	}

    private void OnMouseDown()
    {
        clicks++;
        float num = Random.Range(min, max);
        boxText.text = "" + num;
        clickText.text = "Clicks: " + clicks;
    }

    public void ChangeSeed(string newSeed) {
        seed = newSeed;
        clicks = 0;
        Random.InitState(seed.GetHashCode());
        boxText.text = "Click Me!";
        clickText.text = "Clicks: " + clicks;
    }
}
