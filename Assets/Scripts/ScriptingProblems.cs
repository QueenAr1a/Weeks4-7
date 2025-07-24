using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingProblems : MonoBehaviour
{
	public TMPro.TMP_Text premiseText;
	public TMPro.TMP_Text resultText;

	private void Start()
	{
		//SwapNumbers();
		//FindHighestNumber();
		IncreaseAge();
		//MovePosition();
	}

	public void SwapNumbers()
	{
		premiseText.text = "Swapping numbers: 5 and 3";
		int firstNumber = 5;
		int secondNumber = 3;
		int firstBackup = 5;
		int secondBackup = 3;

		//use a placeholder variable to store the number so it doesnt change

		firstNumber = secondBackup;
 
        secondNumber = firstBackup;

  

        resultText.text = "First number["+firstNumber.ToString()+"], Second number["+secondNumber.ToString()+"]";
    }

	public void FindHighestNumber()
	{
		premiseText.text = "Finding the highest number out of 4, 3, 5, 1, 12, 6, 2";
		List<int> numbers = new List<int>() { 4, 3, 5, 1, 12, 6, 2 };
		int highestNumber = 0;
		for (int i = 0; i < numbers.Count; i++) //originally the node was just starting at zero and counting up the amount of items in the list
			//but we want it to count each item individually and stor them so instead we use the list[i] (which checks the individual items of the list as the i increases
		{
			if (numbers[i] > highestNumber)
			{
				highestNumber = numbers[i];
			}
		}
		resultText.text = "Highest number["+highestNumber.ToString()+"]";
	}

	class Person
	{
		public int age = 0;
		public string name = "";

		public Person()
		{
		}

		public Person(int inAge, string inName)
		{
		}
	}

	public void IncreaseAge()
	{
		Person alice = new Person(32, "Alice");
		Person thomas = new Person(24, "Thomas");
        

        int ageIncrease = 3;
		premiseText.text = "Increasing age of Alice and Thomas";
		
		alice.age += ageIncrease;
		thomas.age += ageIncrease;
		Debug.Log(alice.age.ToString());
        Debug.Log(thomas.age.ToString());
        resultText.text = "Alice is now "+alice.age.ToString()+" years old and Thomas is now "+thomas.age.ToString()+" years old.";
	}

	public void MovePosition()
	{
		Vector3 currentPosition = new Vector3(1.5f, 2.5f, 3.5f);
		premiseText.text = "Moving the position " + currentPosition.ToString();
		int shiftedX = 3 + (int)currentPosition.x;
		currentPosition.x = shiftedX;
		resultText.text = "Position is now " + currentPosition.ToString();
	}

}
