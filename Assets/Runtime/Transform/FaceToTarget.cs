/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  FaceToTarget.cs
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
    public class FaceToTarget : LookToTarget
    {
        public Vector3 posOffset;

        public override void Adapt()
        {
            var faceDir = target.forward;
            if (mode == LookMode.Yaw)
            {
                faceDir.y = 0;
            }
            else if (mode == LookMode.Pitch)
            {
                faceDir.x = 0;
            }
            var faceRot = Quaternion.LookRotation(faceDir);
            transform.position = target.position + faceRot * posOffset;
            base.Adapt();
        }
    }
}