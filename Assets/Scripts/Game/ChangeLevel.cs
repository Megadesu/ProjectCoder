using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
   public void ChangeScene()
    {
      var foo = transform.parent.gameObject;
      transform.parent = null;
      Destroy(foo);
    }
}
