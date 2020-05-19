using UnityEngine;

public class LabelManager : MonoBehaviour
{
    private void Update(){
        transform.LookAt(Camera.main.gameObject.transform);
    }
}
