﻿// UltEvents // Copyright 2020 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> lifecycle events:
    /// <see cref="Awake"/>, <see cref="Start"/>, <see cref="OnEnable"/>, <see cref="OnDisable"/>, and
    /// <see cref="OnDestroy"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Once Life Cycle Events")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/LifeCycleEvents")]
    [DisallowMultipleComponent]
    public class OnceLifeCycleEvents : MonoBehaviour
    {
        /************************************************************************************************************************/

        [SerializeField]
        private UltEvent _AwakeEvent;

        /// <summary>Invoked by <see cref="Awake"/>.</summary>
        public UltEvent AwakeEvent
        {
            get
            {
                if (_AwakeEvent == null)
                    _AwakeEvent = new UltEvent();
                return _AwakeEvent;
            }
            set { _AwakeEvent = value; }
        }

        /// <summary>Invokes <see cref="AwakeEvent"/>.</summary>
        public virtual void Awake()
        {
            if (_AwakeEvent != null)
                _AwakeEvent.Invoke();
        }

        /************************************************************************************************************************/

        [SerializeField]
        private UltEvent _StartEvent;

        /// <summary>Invoked by <see cref="Start"/>.</summary>
        public UltEvent StartEvent
        {
            get
            {
                if (_StartEvent == null)
                    _StartEvent = new UltEvent();
                return _StartEvent;
            }
            set { _StartEvent = value; }
        }

        /// <summary>Invokes <see cref="StartEvent"/>.</summary>
        public virtual void Start()
        {
            if (_StartEvent != null)
                _StartEvent.Invoke();
        }

        /************************************************************************************************************************/

        [SerializeField]
        private UltEvent _DestroyEvent;

        /// <summary>Invoked by <see cref="OnDestroy"/>.</summary>
        public UltEvent DestroyEvent
        {
            get
            {
                if (_DestroyEvent == null)
                    _DestroyEvent = new UltEvent();
                return _DestroyEvent;
            }
            set { _DestroyEvent = value; }
        }

        /// <summary>Invokes <see cref="DestroyEvent"/>.</summary>
        public virtual void OnDestroy()
        {
            if (_DestroyEvent != null)
                _DestroyEvent.Invoke();
        }

        /************************************************************************************************************************/
    }
}