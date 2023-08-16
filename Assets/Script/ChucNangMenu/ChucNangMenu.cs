using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChucNangMenu : MonoBehaviour
{
   public void Choi(){
        SceneManager.LoadScene(1);
   }
   public void CaiDat(){
        SceneManager.LoadScene(2);
   }
   public void Thoat(){
        Application.Quit();
   }
}
