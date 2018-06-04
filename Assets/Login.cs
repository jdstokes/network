using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{

    public string inputUserName = "jaredUnity";
    public string inputPassword = "123456";
//    private string LoginURL = "http://localhost/Cool_YT_RPG/Login.php";
    private string LoginURL = "https://stokesjd.000webhostapp.com/InsertUser.php";

	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.L)) StartCoroutine(LoginToDB(inputUserName, inputPassword));

    }

    IEnumerator LoginToDB(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(LoginURL, form);

        yield return www;

        Debug.Log(www.text);
    }
}
