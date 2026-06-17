/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ChildToTarget.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/13/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Adaptive
{
    public class ChildToTarget : Adaptive
    {
        public Vector3 posOffset;
        public Vector3 rotOffset;

        protected virtual void Start()
        {
            Adapt();
        }

        public override void Adapt()
        {
            transform.parent = target;
            transform.localPosition = posOffset;
            transform.localEulerAngles = rotOffset;
        }
    }
}