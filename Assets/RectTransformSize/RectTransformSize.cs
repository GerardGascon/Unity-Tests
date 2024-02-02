using UnityEngine;

namespace RectTransformSize {
	[RequireComponent(typeof(RectTransform))]
	public class RectTransformSize : MonoBehaviour {
		public void Start() {
			RectTransform rectTransform = GetComponent<RectTransform>();
		
			Debug.Log($"{name}: RectTransform.sizeDelta.y: {rectTransform.sizeDelta.y}");
			Debug.Log($"{name}: RectTransform.rect.height: {rectTransform.rect.height}");
			Debug.Log($"{name}: RectTransform.sizeDelta.x: {rectTransform.sizeDelta.x}");
			Debug.Log($"{name}: RectTransform.rect.width: {rectTransform.rect.width}");
		}
	}
}