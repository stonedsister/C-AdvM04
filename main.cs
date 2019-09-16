// Brenton Luty
// Module 04
// 9/16/2019

using System;
using static System.Console;

class MainClass {
	enum direction{NORTH, EAST, SOUTH, WEST};
	public static void Main (string[] args) {
		WriteLine("Module01 Exercises");
		module01();

		WriteLine("\n\nModule02 Exercises");
		module02();
		direction dir = direction.NORTH;
	}

	public static void module01(){
		WriteLine("Hello world");
		int one = 1;
		int two = 2;
		int result = one + two;
		WriteLine("One = " + one);
		WriteLine("Two = " + two);
		WriteLine("Result = " + result);

		if(result == 3){
			WriteLine("Result == 3 and if statement entered");
		}else{
			WriteLine("How did you reach this code?");
		}

		string interpole = "a place holder";
		WriteLine("String interpolation utilizes... {0}", interpole);
	}

	public static void module02(){
		person person1 = new person();

		person1.personInfo("John Doe", 37);

		WriteLine(person1.Name);
		WriteLine(person1.Age);
		person1.ageInfo();
		person1.Name = "Brittany";
		WriteLine(person1.Name);
		WriteLine();
		string[] words = new string[]{"An array ", "can hold ", "various objects of", " the same type"};

		for(int i = 0; i < words.Length; i++){
			Write(words[i]);
		}

		animal cheetah = new animal();

		cheetah.Species = "Cheetah";
		cheetah.Name = "Checkers";
		cheetah.Attack = "Speed and claws";
		WriteLine("\nStructs");
		WriteLine(cheetah.Species);
		WriteLine(cheetah.Name);
		WriteLine(cheetah.Attack);
	}

	public class person{
		private string name;
		private int age;
		public void personInfo(string n, int a){
			name = n;
			age = a;
		}
		
		public string Name{
			get{return name;}
			set{name = value;}
		}
		
		public int Age{
			get{return age;}
			set{age = value;}
		}

		public void ageInfo(){
			if(age < 16){
				WriteLine("You're a youngster!");
			}
			else{
				WriteLine("So you've lived a little bit, eh?");
			}
		}
		
	}

	public struct animal{
		private string _species;
		private string _name;
		private string _attack;

		public string Species{
			get{return _species;}
			set{_species = value;}
		}
		public string Name{
			get{return _name;}
			set{_name = value;}
		}
		public string Attack{
			get{return _attack;}
			set{_attack = value;}		
		}
	}


	

	
}