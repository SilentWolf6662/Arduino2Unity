#region Copyright Notice
// ******************************************************************************************************************
// 
// Frogger (Clone).Assembly-CSharp.A2U_Up.cs © SilentWolf6662 - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// 
// This work is licensed under the Creative Commons Attribution-NonCommercial-NoDerivs 3.0 Unported License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-nd/3.0/
// 
// Created & Copyrighted @ 2022-08-29
// 
// ******************************************************************************************************************
#endregion
using UnityEngine;
namespace Froggy
{
	public class A2U_Left : MonoBehaviour
	{
		[SerializeField] private Arduino2Unity a2u;
		private void Update()
		{
			if (a2u.sp.IsOpen)
				try
				{
					if (a2u.sp.ReadByte() == 4) a2u.player.rb.MovePosition(a2u.player.rb.position + Vector2.left);
				}
				catch (System.Exception) { /* ignored */ }
		}
	}
}
