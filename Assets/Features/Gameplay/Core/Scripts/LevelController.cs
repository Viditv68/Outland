using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public string levelName;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            LevelManager.Instance.MarkCurrentLevelComplete();
            UiManager.instance.OpenScene(levelName);
        }
    }
}

