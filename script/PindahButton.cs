using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PindahButton : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("UIMenu");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("AboutUs");
    }
}
