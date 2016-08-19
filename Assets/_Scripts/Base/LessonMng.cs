using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LessonMng {

	private static List<Lesson> _lessons;


	public static List<Lesson> GetLessons()
	{
		if (_lessons == null) {
			_lessons = new List<Lesson> ();

			_lessons.Add (new Lesson(){ Index=1 , SceneName="", Title="Binary Numbers" });
			_lessons.Add (new Lesson(){ Index=2 , SceneName="", Title="Image Representation" });
			_lessons.Add (new Lesson(){ Index=3 , SceneName="", Title="Text Compression" });
			_lessons.Add (new Lesson(){ Index=4 , SceneName="", Title="Error Detection" });

			_lessons.Add (new Lesson(){ Index=5 , SceneName="", Title="Information Theory" });
			_lessons.Add (new Lesson(){ Index=6 , SceneName="", Title="Searching Algorithms" });
			_lessons.Add (new Lesson(){ Index=7 , SceneName="", Title="Sorting Algorithms" });
			_lessons.Add (new Lesson(){ Index=8 , SceneName="", Title="Sorting Networks" });
			_lessons.Add (new Lesson(){ Index=9 , SceneName="", Title="Minimal Spanning Trees" });
			_lessons.Add (new Lesson(){ Index=10 , SceneName="", Title="Routing and Deadlock" });
			_lessons.Add (new Lesson(){ Index=11 , SceneName="", Title="Network Protocols" });

			_lessons.Add (new Lesson(){ Index=12 , SceneName="", Title="Finite State Automata" });
			_lessons.Add (new Lesson(){ Index=13 , SceneName="", Title="Programming Languages" });
			_lessons.Add (new Lesson(){ Index=14 , SceneName="", Title="Graph Colouring" });
			_lessons.Add (new Lesson(){ Index=15 , SceneName="", Title="Dominating Sets" });
			_lessons.Add (new Lesson(){ Index=16 , SceneName="", Title="Steiner Trees" });
			_lessons.Add (new Lesson(){ Index=17 , SceneName="", Title="Information Hiding" });
			_lessons.Add (new Lesson(){ Index=18 , SceneName="", Title="Cryptographic Protocols" });
			_lessons.Add (new Lesson(){ Index=19 , SceneName="", Title="Public Key Encryption" });
			_lessons.Add (new Lesson(){ Index=20 , SceneName="", Title="The Turing Test" });

		}
		return _lessons;
	}
}
