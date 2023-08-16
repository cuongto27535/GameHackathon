using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChonMan : MonoBehaviour
{
    
  public void Back(){
       SceneManager.LoadScene(0);
  }
    public void Man1(){
        SceneManager.LoadScene(3);
    }
    public void Man2(){
        SceneManager.LoadScene(4);
    }
    public void Man3(){
        SceneManager.LoadScene(5);
    }
    public void Man4(){
        SceneManager.LoadScene(6);
    }
    public void Man5(){
        SceneManager.LoadScene(7);
    }
}
