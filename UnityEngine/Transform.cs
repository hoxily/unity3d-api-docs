using System;
using System.Collections;
using UnityEngine.Internal;

namespace UnityEngine
{
    public class Transform : Component, IEnumerable
    {
        protected Transform() { }

        public int childCount { get { return default(int); } }
        public Vector3 eulerAngles { get; set; }
        public Vector3 forward { get; set; }
        public bool hasChanged { get; set; }
        public Vector3 localEulerAngles { get; set; }
        public Vector3 localPosition { get; set; }
        public Quaternion localRotation { get; set; }
        public Vector3 localScale { get; set; }
        public Matrix4x4 localToWorldMatrix { get { return default(Matrix4x4); } }
        public Vector3 lossyScale { get { return default(Vector3); } }
        public Transform parent { get; set; }
        public Vector3 position { get; set; }
        public Vector3 right { get; set; }
        public Transform root { get { return default(Transform); } }
        public Quaternion rotation { get; set; }
        public Vector3 up { get; set; }
        public Matrix4x4 worldToLocalMatrix { get { return default(Matrix4x4); } }

        public void DetachChildren() { }
        public Transform Find(string name) { return default(Transform); }
        public Transform FindChild(string name) { return default(Transform); }
        public Transform GetChild(int index) { return default(Transform); }
        [Obsolete("use Transform.childCount instead.")]
        public int GetChildCount() { return default(int); }
        public IEnumerator GetEnumerator() { return default(IEnumerator); }
        public int GetSiblingIndex() { return default(int); }
        public Vector3 InverseTransformDirection(Vector3 direction) { return default(Vector3); }
        public Vector3 InverseTransformDirection(float x, float y, float z) { return default(Vector3); }
        public Vector3 InverseTransformPoint(Vector3 position) { return default(Vector3); }
        public Vector3 InverseTransformPoint(float x, float y, float z) { return default(Vector3); }
        public Vector3 InverseTransformVector(Vector3 vector) { return default(Vector3); }
        public Vector3 InverseTransformVector(float x, float y, float z) { return default(Vector3); }
        public bool IsChildOf(Transform parent) { return default(bool); }
        [ExcludeFromDocs]
        public void LookAt(Transform target) { }
        [ExcludeFromDocs]
        public void LookAt(Vector3 worldPosition) { }
        public void LookAt(Transform target, Vector3 worldUp) { }
        public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }
        [ExcludeFromDocs]
        public void Rotate(Vector3 eulerAngles) { }
        [ExcludeFromDocs]
        public void Rotate(Vector3 axis, float angle) { }
        public void Rotate(Vector3 eulerAngles, Space relativeTo) { }
        [ExcludeFromDocs]
        public void Rotate(float xAngle, float yAngle, float zAngle) { }
        public void Rotate(Vector3 axis, float angle, Space relativeTo) { }
        public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }
        [Obsolete("use Transform.Rotate instead.")]
        public void RotateAround(Vector3 axis, float angle) { }
        public void RotateAround(Vector3 point, Vector3 axis, float angle) { }
        [Obsolete("use Transform.Rotate instead.")]
        public void RotateAroundLocal(Vector3 axis, float angle) { }
        public void SetAsFirstSibling() { }
        public void SetAsLastSibling() { }
        public void SetParent(Transform parent) { }
        public void SetParent(Transform parent, bool worldPositionStays) { }
        public void SetSiblingIndex(int index) { }
        public Vector3 TransformDirection(Vector3 direction) { return default(Vector3); }
        public Vector3 TransformDirection(float x, float y, float z) { return default(Vector3); }
        public Vector3 TransformPoint(Vector3 position) { return default(Vector3); }
        public Vector3 TransformPoint(float x, float y, float z) { return default(Vector3); }
        public Vector3 TransformVector(Vector3 vector) { return default(Vector3); }
        public Vector3 TransformVector(float x, float y, float z) { return default(Vector3); }
        [ExcludeFromDocs]
        public void Translate(Vector3 translation) { }
        public void Translate(Vector3 translation, Space relativeTo) { }
        public void Translate(Vector3 translation, Transform relativeTo) { }
        [ExcludeFromDocs]
        public void Translate(float x, float y, float z) { }
        public void Translate(float x, float y, float z, Space relativeTo) { }
        public void Translate(float x, float y, float z, Transform relativeTo) { }
    }
}