using UnityEngine;

/// <summary>
///  Used as interface for any component that could be controlled.
/// </summary>
public class ControllableBehaviour : MonoBehaviour
{
		/// <summary>
		/// Moves the horizontal.
		/// </summary>
		/// <param name="movementValue">Movement value.</param>
		public virtual void MoveHorizontal (float movementValue)
		{
				Debug.Log ("Horizontal movement is not implemented");
		}

		/// <summary>
		/// Moves the vertical.
		/// </summary>
		/// <param name="movementValue">Movement value.</param>
		public virtual void MoveVertical (float movementValue)
		{
				Debug.Log ("Vertical movement is not implemented");
		}

		/// <summary>
		/// Does the action.
		/// </summary>
		public virtual void DoAction ()
		{
				Debug.Log ("Action is not implemented");
		}

		/// <summary>
		/// Does the jump.
		/// </summary>
		public virtual void DoJump ()
		{
				Debug.Log ("Jumping is not implemented");
		}
}
