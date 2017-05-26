﻿using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace CreateThis.Factory {
    public class BaseFactory : MonoBehaviour {
        public bool useVRTK;

        protected T SafeAddComponent<T>(GameObject target) where T : Component {
#if UNITY_EDITOR
            return Undo.AddComponent<T>(target);
#else
            return target.AddComponent<T>();
#endif
        }

        protected GameObject EmptyChild(GameObject parent, string name, Vector3 localScale = new Vector3()) {
            GameObject instance = new GameObject();
#if UNITY_EDITOR
            Undo.RegisterCreatedObjectUndo(instance, "Empty Child " + name);
#endif
            instance.name = name;
            instance.transform.localScale = localScale == Vector3.zero ? Vector3.one : localScale;
            instance.transform.parent = parent.transform;
            instance.transform.localPosition = Vector3.zero;
            instance.transform.localRotation = Quaternion.identity;
            return instance;
        }

        public virtual GameObject Generate() {
            return null;
        }
    }
}