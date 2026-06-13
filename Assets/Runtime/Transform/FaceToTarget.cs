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

namespace MGS.AdaptiveBehaviour
{
    public enum FaceMode
    {
        Yaw,
        Pitch,
        All
    }

    public class FaceToTarget : AdaptiveBehaviourPro
    {
        public FaceMode mode;

        public override void Adapt()
        {
            var faceDir = (target.position - transform.position).normalized;
            if (mode == FaceMode.Yaw)
            {
                faceDir.y = 0;
            }
            else if (mode == FaceMode.Pitch)
            {
                faceDir.x = 0;
            }
            var faceRot = Quaternion.LookRotation(faceDir);
            transform.rotation = faceRot;
        }
    }
}