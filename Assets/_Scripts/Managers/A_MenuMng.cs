using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class A_MenuMng : MonoBehaviour {

	public GameObject itemGO;
	public GameObject listGO;
	public ScrollRect scroll;

	// Use this for initialization
	void Start () {
		var lessons = A_LessonMng.GetLessons();

		foreach (var item in lessons)
		{
			GameObject newItem = (GameObject)Instantiate (itemGO,listGO.transform);
			newItem.transform.localScale = new Vector3 (1, 1, 1);
			newItem.GetComponent<A_MenuItem>().Set(item);
			newItem.GetComponent<A_MenuItem>().onClick += OnClick_Item;
		}

		scroll.verticalNormalizedPosition = 1;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick_Item(int index)
	{
		Debug.Log(index);
	}


	public void Click_Start()
	{
		
	}

	public void Click_About()
	{}

	public void Click_Quit()
	{
		Application.Quit ();
	}
}
