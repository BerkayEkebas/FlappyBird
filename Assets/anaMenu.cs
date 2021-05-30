using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class anaMenu : MonoBehaviour {

	public Text puanText;
	public Text puan;

	void Start () 
	{
		int enYuksekPuan = PlayerPrefs.GetInt ("enYuksekPuanKayit");
		int puanGelen = PlayerPrefs.GetInt ("puankayit");
		puanText.text = "En Yuksek Puan =" + enYuksekPuan;
		puan.text = "Puan =" + puanGelen;
	}
	

	void Update () 
	{
		
	}
	public void oyunaGit()
	{
		SceneManager.LoadScene("level");
	}
	public void oyundanCik()
	{
		Application.Quit ();
	}
}
