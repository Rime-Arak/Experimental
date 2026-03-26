using Unity.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject targetPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnTargets();
    }

    // Update is called once per frame
    void Update()
    {
        var targets = FindObjectsByType<TargetBehavior>(FindObjectsSortMode.None);

        if (targets.Length == 0 && !IsInvoking("SpawnTargets"))
        {
            Invoke("SpawnTargets", 1.0f);
        }
    }
    void SpawnTargets()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-9, 9), 1, 6);
        Instantiate(targetPrefab, spawnPos, targetPrefab.transform.rotation);
    }
}
