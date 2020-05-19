using UnityEngine;

public class LineManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] labels;
    [SerializeField]
	private GameObject[] buttons;

	void Update () {
		for(int i = 0; i < buttons.Length; i++)
			DrawLine(labels[i].transform.position, buttons[i].transform.position);
    }
	public void DrawLine(Vector3 start, Vector3 end, float duration = 0.018f){
		Color color = Color.black;
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.material = new Material(Shader.Find("Sprites/Default"));
		lr.SetColors(color, color);
		lr.SetWidth(0.0025f, 0.0025f);
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
		GameObject.Destroy(myLine, duration);
	}
}
