using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.13
/// </summary>

public class PopulationManager : MonoBehaviour
{
    public GameObject personPrefabe;
    public int populationSize = 10;
    List<GameObject> population = new List<GameObject>();
    public static float elapsed = 0;

    int trialTime = 10;
    int generation = 1;

    GUIStyle gUI = new GUIStyle();
     void OnGUI()
    {
        gUI.fontSize = 50;
        gUI.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 100, 20), "Generation " + generation, gUI);
        GUI.Label(new Rect(10, 65, 100, 20), "Trail Time " + (int)elapsed, gUI);
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < populationSize; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-9, 9), Random.Range(-4.5f, 4.5f), 0);
            GameObject go = Instantiate(personPrefabe, pos, Quaternion.identity);
            go.GetComponent<DNA>().r = Random.Range(0.0f, 1.0f);
            go.GetComponent<DNA>().g = Random.Range(0.0f, 1.0f);
            go.GetComponent<DNA>().b = Random.Range(0.0f, 1.0f);
            population.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if(elapsed > trialTime)
        {
            BreeadNewPopulation();
            elapsed = 0;
        }
    }

    private void BreeadNewPopulation()
    {
        throw new System.NotImplementedException();
    }
}
