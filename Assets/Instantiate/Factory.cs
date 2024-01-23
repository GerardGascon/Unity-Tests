using UnityEngine;

namespace Instantiate {
	public class Factory : MonoBehaviour {

		[SerializeField] private InstantiateObject instantiateObject;

		private void Update() {
			if (!Input.GetKeyDown(KeyCode.Space)) return;
		
			InstantiateObject obj = Instantiate(instantiateObject);
			obj.Method();
		}
	}
}