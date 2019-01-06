using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


[RequireComponent(typeof(RectTransform))]
public class ScreenStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [System.Serializable]
    public class StickMoveEvent : UnityEvent<Vector2> { }

    public int movementRange = 50;
    public UnityEvent onPointerDown;
    public StickMoveEvent onDrag;
    public StickMoveEvent onPointerUp;

    private RectTransform mRectTransform;
    private RectTransform mParentRectTransform;
    private Vector3 mStartPos;
    private Vector2 mPointerDownPos;


    private void Start()
    {
        mRectTransform = transform as RectTransform;
        mParentRectTransform = transform.parent.GetComponentInParent<RectTransform>();
        mStartPos = mRectTransform.anchoredPosition;
    }

    public void OnPointerDown(PointerEventData data)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(mParentRectTransform, data.position, data.pressEventCamera, out mPointerDownPos);
        onPointerDown?.Invoke();
    }

    public void OnDrag(PointerEventData data)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(mParentRectTransform, data.position, data.pressEventCamera, out Vector2 position);

        var delta = position - mPointerDownPos;
        delta = Vector2.ClampMagnitude(delta, movementRange);

        mRectTransform.anchoredPosition = mStartPos + (Vector3)delta;

        var newPos = new Vector2(delta.x / movementRange, delta.y / movementRange);
        onDrag?.Invoke(newPos);
    }

    public void OnPointerUp(PointerEventData data)
    {
        mRectTransform.anchoredPosition = mStartPos;
        onPointerUp?.Invoke(Vector2.zero);
    }
}
