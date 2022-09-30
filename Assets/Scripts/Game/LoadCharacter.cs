using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] charaterPrefabs;
    public Transform spawnPoint;
    public TMP_Text label;
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefabs = charaterPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefabs, spawnPoint.position, Quaternion.identity);
    }
}
