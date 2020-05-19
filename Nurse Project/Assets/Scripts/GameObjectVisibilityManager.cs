using System.Collections;
using UnityEngine;

public class GameObjectVisibilityManager : MonoBehaviour
{
    public GameObject correct;
    public GameObject incorrect;
    private void Awake() {
        ScenarioButtonInteraction.inputGiven += CallActivateGameObjectForaWhile;
    }
    private void OnDisable() {
        ScenarioButtonInteraction.inputGiven -= CallActivateGameObjectForaWhile;
    }
    public void CallActivateGameObjectForaWhile(int num){
        StartCoroutine(ActivateGameObjectForaWhile(num));
    }
     private IEnumerator ActivateGameObjectForaWhile(int num){
        correct.SetActive(false);
        incorrect.SetActive(false);
        GameObject go = num == 1 ? correct : incorrect;
        go.SetActive(true);
        yield return new WaitForSeconds(1);
        go.SetActive(false);
    }
}
