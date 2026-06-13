/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  LineSizeToTarget.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/14/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.AdaptiveBehaviour
{
    [RequireComponent(typeof(LineRenderer))]
    public class LineSizeToTarget : AdaptiveBehaviourPro
    {
        [Tooltip("Visual angle (rad)")]
        public float angle = 0.05f;
        protected LineRenderer lineRenderer;
        protected float startWidth;
        protected float endWidth;

        protected override void Awake()
        {
            base.Awake();

            lineRenderer = GetComponent<LineRenderer>();
            startWidth = lineRenderer.startWidth;
            endWidth = lineRenderer.endWidth;
        }

        public override void Adapt()
        {
            if (lineRenderer.positionCount > 0)
            {
                lineRenderer.startWidth = startWidth * GetVisualHeight(0);
            }
            if (lineRenderer.positionCount > 1)
            {
                lineRenderer.endWidth = endWidth * GetVisualHeight(lineRenderer.positionCount - 1);
            }
        }

        float GetVisualHeight(int index)
        {
            var position = GetWorldPosition(index);
            var distance = Vector3.Distance(position, target.position);
            return VisualUtility.CalculateHeight(distance, angle);
        }

        Vector3 GetWorldPosition(int index)
        {
            var position = lineRenderer.GetPosition(index);
            if (!lineRenderer.useWorldSpace)
            {
                position = transform.TransformPoint(position);
            }
            return position;
        }
    }
}