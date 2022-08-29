#region Copyright Notice
// ******************************************************************************************************************
// 
// Frogger (Clone).Assembly-CSharp.ArduinoController.cs © SilentWolf6662 - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// 
// This work is licensed under the Creative Commons Attribution-NonCommercial-NoDerivs 3.0 Unported License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-nd/3.0/
// 
// Created & Copyrighted @ 2022-08-26
// 
// ******************************************************************************************************************
#endregion
using UnityEngine;
namespace Froggy
{
	public class ArduinoBridgeController : SerialController
	{
		[SerializeField] private Player player;
		[SerializeField] private bool alreadyGotInput;
		// Invoked when a line of data is received from the serial device.
		private void OnMessageArrived(string msg)
		{
			if (!player.movePlayer) alreadyGotInput = false;
			if (!alreadyGotInput && msg != "0")
			{
				alreadyGotInput = true;
				//Debug.Log($"Message arrived: {msg}");
				
				// Trigger Move Function
				//player.moveDirection = msg;

				//print($"moveDirection arrived: {player.moveDirection}");
			}
		}

		// Invoked when a connect/disconnect event occurs. The parameter 'success'
		// will be 'true' upon connection, and 'false' upon disconnection or
		// failure to connect.
		private void OnConnectionEvent(bool success) => Debug.Log(success ? "Connection established" : "Connection attempt failed or disconnection detected");
	}
}
