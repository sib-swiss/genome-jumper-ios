using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleBarFix : MonoBehaviour {

	private RectTransform rectTransform;

	void Update() {
		rectTransform = this.GetComponent<RectTransform> ();
		rectTransform.offsetMin = new Vector2 (-10f, -10f);
		rectTransform.offsetMax = new Vector2 (-10f, -10f);
	}
}
