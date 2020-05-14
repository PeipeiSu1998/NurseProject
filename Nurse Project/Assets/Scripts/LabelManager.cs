using UnityEngine;

public class LabelManager : MonoBehaviour
{
    void Update(){
        transform.LookAt(Camera.main.gameObject.transform);
    }
}
