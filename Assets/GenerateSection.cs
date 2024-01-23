using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSection : MonoBehaviour
{
    public BoxCollider2D collider2D;
    public GameObject endSection;
    public List<GameObject> LevelSectons;

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Generate level");
            gameObject.SetActive(false);
            GenerateSection2(LevelSectons);
            endSection.SetActive(false);
        }
    }
    public void GenerateSection2(List<GameObject> levelSection)
    {
        int i = Random.Range(0, levelSection.Count);
        Instantiate(levelSection[i], endSection.transform.position + new Vector3(10, 0, 0), Quaternion.identity);
    }
}
