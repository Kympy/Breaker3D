using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    private int index;
    void Start()
    {
        index = SceneChecker.sceneIndex;

        if (index == 0) StartCoroutine(LoadScene(2)); // 시작화면 > 난이도 선택
        if (index == 2)
        {
            StartCoroutine(LoadScene(3)); // 난이도 선택 >> 이지모드
        }
    }

    IEnumerator LoadScene(int number)
    {
        yield return null;

        AsyncOperation operation = SceneManager.LoadSceneAsync(number);
        operation.allowSceneActivation = false;

        yield return new WaitForSeconds(2f);
        operation.allowSceneActivation = true;
    }
}
