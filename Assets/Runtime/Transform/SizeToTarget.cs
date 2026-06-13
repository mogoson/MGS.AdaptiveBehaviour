/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SizeToTarget.cs
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
    public class SizeToTarget : AdaptiveBehaviourPro
    {
        [Tooltip("Visual angle (rad)")]
        public float angle = 0.05f;
        protected Vector3 localScale;

        protected override void Awake()
        {
            base.Awake();
            localScale = transform.localScale;
        }

        public override void Adapt()
        {
            var distance = Vector3.Distance(transform.position, target.position);
            var height = VisualUtility.CalculateHeight(distance, angle);
            transform.localScale = localScale * height;
        }
    }
}