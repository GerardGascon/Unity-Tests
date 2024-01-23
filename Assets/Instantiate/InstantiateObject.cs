using UnityEngine;

namespace Instantiate {
	public class InstantiateObject : MonoBehaviour {
		private void Awake() {
			Debug.Log("Awake");
		}

		private void Start() {
			Debug.Log("Start");
		}

		private void OnEnable() {
			Debug.Log("OnEnable");
		}

		public void Method() {
			Debug.Log("Method");
		}
	}
}