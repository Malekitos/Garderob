using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class objektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private RectTransform transformKomponente;
	public Canvas kanva;

	void Start ()
	{
		transformKomponente = GetComponent<RectTransform>();
	}

	public void OnPointerDown(PointerEventData notikums) {
		Debug.Log("Izdarits kliskis");
	}

	public void OnBeginDrag(PointerEventData notikums) {
		Debug.Log("Uzsakta vilksana");
	}

	public void OnDrag(PointerEventData notikums) {
		Debug.Log("Notiek objekta parvietosana");
		transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums) {
		Debug.Log("Objektu vilksana pabeigta");
	}


}
