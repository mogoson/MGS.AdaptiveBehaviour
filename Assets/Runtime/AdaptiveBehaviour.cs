/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AdaptiveBehaviour.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/13/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.AdaptiveBehaviour
{
    public abstract class AdaptiveBehaviour : MonoBehaviour, IAdaptiveBehaviour
    {
        public Transform target;

        protected virtual void Awake()
        {
            if (target == null)
            {
                target = Camera.main?.transform;
            }
        }

        public abstract void Adapt();
    }

    public abstract class AdaptiveBehaviourPro : AdaptiveBehaviour
    {
        public bool always = true;

        protected virtual void OnEnable()
        {
            Adapt();
        }

        protected virtual void Update()
        {
            if (always)
            {
                Adapt();
            }
        }
    }
}