using UnityEngine;
public class PrintObjectsInfo : MonoBehaviour
{
    void Start()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.tag != "Untagged")
            {
                Debug.Log($"Objeto: {obj.name} | Tag: {obj.tag} | Posición: {obj.transform.position}");
            }
        }
    }
}
