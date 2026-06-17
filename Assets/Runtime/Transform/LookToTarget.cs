/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  LookToTarget.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/15/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Adaptive
{
    public enum LookMode
    {
        Yaw,
        Pitch,
        All
    }

    public class LookToTarget : AdaptivePro
    {
        public LookMode mode;
        public bool inverse;

        public override void Adapt()
        {
            var lookDir = (target.position - transform.position).normalized;
            if (mode == LookMode.Yaw)
            {
                lookDir.y = 0;
            }
            else if (mode == LookMode.Pitch)
            {
                lookDir.x = 0;
            }
            if (inverse)
            {
                lookDir = -lookDir;
            }
            var lookRot = Quaternion.LookRotation(lookDir);
            transform.rotation = lookRot;
        }
    }
}