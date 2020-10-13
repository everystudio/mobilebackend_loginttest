using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class LoginTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        // クラスのNCMBObjectを作成
        NCMBObject testClass = new NCMBObject("TestClass");

        // オブジェクトに値を設定

        testClass["message"] = "Hello, NCMB!";
        // データストアへの登録
        testClass.SaveAsync();
        */
    }


    public void Register()
    {
        //　Userインスタンスの生成
        NCMBUser user = new NCMBUser();

        // ユーザー名・パスワードを設定
        user.UserName = "Yamada Tarou"; /* ユーザー名 */
        user.Password = "password"; /* パスワード */
        user.Add("phone", "987-654-3210"); /* 任意フィールドも追加可能 */

        // ユーザーの新規登録処理
        user.SignUpAsync((NCMBException e) => {
            if (e != null)
            {
                UnityEngine.Debug.Log("ユーザーの新規登録に失敗: " + e.ErrorMessage);
            }
            else
            {
                UnityEngine.Debug.Log("ユーザーの新規登録に成功");
            }
        });
    }

    public void Login()
    {
        // ユーザー名とパスワードでログイン
        NCMBUser.LogInAsync("Yamada Tarou", "password", (NCMBException e) => {
            if (e != null)
            {
                UnityEngine.Debug.Log("ログインに失敗: " + e.ErrorMessage);
            }
            else
            {
                UnityEngine.Debug.Log("ログインに成功！");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
