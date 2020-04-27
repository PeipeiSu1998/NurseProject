using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] labels;
    [SerializeField]
	private GameObject[] buttons;

	void Update () {
		for(int i = 0; i < buttons.Length; i++)
			DrawLine(labels[i].transform.position, buttons[i].transform.position, Color.black);
    }
	void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.018f){
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.material = new Material(Shader.Find("Sprites/Default"));
		lr.SetColors(color, color);
		lr.SetWidth(0.005f, 0.005f);
        Vector3 startAdjusted = new Vector3(start.x, start.y + 2, start.z);
        		lr.SetPosition(0, start);
 //       lr.SetPosition(0, startAdjusted);
        lr.SetPosition(1, end);
		GameObject.Destroy(myLine, duration);
	}
}
