using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMoveScript : MonoBehaviour
{
    GameObject MainCanvas;
    //[SerializeField] GameObject Fade_start;
    [SerializeField] GameObject Fade_end;
    string btn_name;
    // Start is called before the first frame update
    void Start()
    {
        MainCanvas = GameObject.Find("MainMenu_Canvas");
        if (MainCanvas == null)
        {
            MainCanvas = GameObject.Find("Shop_Canvas");

        }
        if (this.gameObject.name.Equals("BackBtn"))
        {

            btn_name = "BackBtn";
        }
        btn_name = this.gameObject.name;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneMoveMethod()
    {

        StartCoroutine("fade_method");

    }
    private IEnumerator fade_method()
    {
       

        GameObject obj = Instantiate(Fade_end, this.transform.position, Quaternion.identity) as GameObject;
        obj.transform.parent = MainCanvas.transform;
        yield return new WaitForSeconds(0.25f);

        switch (btn_name)
        {
            case "EquipmentBtn":

               
                //UnityEngine.SceneManagement.SceneManager.LoadScene();
                Debug.Log("Equipment");

                break;

            case "UnitBtn":

               
                //UnityEngine.SceneManagement.SceneManager.LoadScene();

                Debug.Log("Unit");

                break;

            case "ShopBtn":
                
                UnityEngine.SceneManagement.SceneManager.LoadScene("CyberGame_Shop");
                Debug.Log("Shop");

                break;

            case "BattleBtn":
                
                //UnityEngine.SceneManagement.SceneManager.LoadScene();
                Debug.Log("Battle");

                break;
            case "BackBtn":

                UnityEngine.SceneManagement.SceneManager.LoadScene("CyberGame_UI");
                Debug.Log("Back");

                break;
            default:

                Debug.Log("Default");

                break;
        }
    }
}
