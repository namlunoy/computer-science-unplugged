using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class A_MenuItem : MonoBehaviour
{

	private A_Lesson lesson;
	private Text text;

	public event System.Action<int> onClick;

	public void Set(A_Lesson lesson)
	{
		this.lesson = lesson;
	}

	void Awake()
	{
		text = this.transform.GetChild(0).GetComponent<Text>();
		GetComponent<Button>().onClick.AddListener(
			() =>
			{
				if(onClick != null)
					onClick(this.lesson.Index);
			}
		);
	}

	// Use this for initialization
	void Start()
	{
		text.text = this.lesson.Title;
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
}
