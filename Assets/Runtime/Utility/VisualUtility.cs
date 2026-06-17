/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  VisualUtility.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/14/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Adaptive
{
    public sealed class VisualUtility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="distance">Distance (m)</param>
        /// <param name="angle">Visual angle (rad)</param>
        /// <returns></returns>
        public static float CalculateHeight(float distance, float angle)
        {
            //h=2d⋅tan(θ/2)
            return 2 * distance * Mathf.Tan(angle * 0.5f);
        }
    }
}