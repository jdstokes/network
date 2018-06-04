using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class DataInserter : MonoBehaviour
{

    public string inputUserName;
    public string inputPassword;
    public string inputEmail;

    //private string CreateUserURL = "http://localhost/Cool_YT_RPG/InsertUser.php";

    private string CreateUserURL = "https://stokesjd.000webhostapp.com/InsertUser.php";

    void Start () {


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(CreateUser(inputUserName, inputPassword, inputEmail));
            Debug.Log("create user");
        }
    }
	

    public IEnumerator CreateUser(string username, string email, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost",username);
        form.AddField("emailPost", email);
        form.AddField("passwordPost", password);

        WWW www = new WWW(CreateUserURL, form);
        yield return www;
        Debug.Log(www.text);


    }
}
