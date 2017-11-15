//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class positioncheck : MonoBehaviour
//{
//    public GameObject[] spheres;
//    public Button submitbutton;
//    public int j;
//    public static int position1;

//    Use this for initialization

//   void Start () {

//       submitbutton.gameObject.SetActive(false);
//    j = 1;
//    position1 = 0;
//    StartCoroutine("positionchecking");
//	}

//Update is called once per frame
//    void Update()
//{


//}
//IEnumerator positionchecking()
//{
//    while (j == 1)
//    {


//        for (int i = 0; i < 6; i++)
//        {
//            for (int k = i + 1; k < 6; k++)
//            {
//                if (k != i && spheres[i].gameObject.transform.position == spheres[i + 1].gameObject.transform.position)
//                {
//                    if (k != j && zipcodeList[k] == zipcodeList[j])
//                        duplicates = true;
//                    j = 1;
//                    Debug.Log("Collison");
//                    StartCoroutine("positionchecking");
//                    position1--;
//                    Debug.Log(position1);
//                    return;

//                }
//            }

//        }
//    }
//}

//}
