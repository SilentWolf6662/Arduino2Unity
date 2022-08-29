using UnityEngine;
using System.IO.Ports;

// make sure to name your C# file the same as your class name. In this case Move.cs 

namespace Froggy
{
	public class Arduino2Unity : MonoBehaviour
	{
		[SerializeField] public Player player;
		private const string port = "COM3";
		// change your serial port
		public readonly SerialPort sp = new SerialPort($"\\\\.\\{port}", 38400);

		private void OnEnable()
		{
			sp.Open();
			sp.ReadTimeout = 100;
		}

		private void OnDisable() => sp.Close();
	}
}