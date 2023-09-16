using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class characterSpawn : MonoBehaviour
{
    public GameObject playerChar;
    private Transform _playerTransform;
    private const float RespawnHeight = 0.1f;

    public UpdateUI updateUI;

    public int spawnTimer;
    public bool isDied;

    private Vector3 _chaunirSpawnLocation = new Vector3(9.43f, 2.76f, 17.17f);
    // Start is called before the first frame update
    void Start()
    {
        //playerChar = GameObject.Find("Player");
        _playerTransform = playerChar.transform;

        updateUI = GameObject.FindObjectOfType<UpdateUI>();
        //spawnTimer = 300;
        //isDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_playerTransform.position);
        if (isDied)
        {
           if (spawnTimer > 0f)
           {
              Debug.Log("1");
              spawnTimer -= 1;
           } else
           {
              Debug.Log("2");
              spawnTimer = 0;
              updateUI.CancelDie();
              _playerTransform.position = _chaunirSpawnLocation;
              playerChar.GetComponent<CharacterController>().enabled = true;
              isDied = false;
           }
        }

        if (transform.position.y < RespawnHeight)
        {
            Debug.Log("die");
            if (!isDied)
            {
               updateUI.DisplayDie();
               isDied = true;
               spawnTimer = 300;
               playerChar.GetComponent<CharacterController>().enabled = false;
            }
            //playerChar.transform.position = new Vector3(12.22f, 1.1f, 16.65f);
        }
    }
}
