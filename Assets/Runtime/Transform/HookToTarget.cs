/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  HookToTarget.cs
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
    public class HookToTarget : AdaptiveBehaviourPro
    {
        public Vector3 posOffset;
        public Vector3 rotOffset;

        public override void Adapt()
        {
            transform.position = target.position + target.rotation * posOffset;
            transform.rotation = target.rotation * Quaternion.Euler(rotOffset);
        }
    }
}