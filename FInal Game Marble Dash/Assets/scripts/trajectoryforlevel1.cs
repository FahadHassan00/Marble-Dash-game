using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trajectoryforlevel1 : MonoBehaviour
{
  
    public LineRenderer lr;

    private int linesegmentcount = 20;

    private List<Vector3> linepoints = new List<Vector3>();

    public static trajectory Instance;

    public int showpercentage = 50;
    private int linepointcount;
    //private void Awake()
    //{

    //    Instance = this;
    //}
    private void Start()
    {
        linepointcount = (int)(linesegmentcount * (showpercentage / 100f));
    }

    public void updatetrajectory(Vector3 forcevector, Rigidbody rb, Vector3 startingpoint)
    {
        Vector3 velocity = (forcevector / rb.mass) * Time.fixedDeltaTime;

        float flightduration = (2 * velocity.y) / Physics.gravity.y;

        float steptime = flightduration / linesegmentcount;

        linepoints.Clear();
        linepoints.Add(startingpoint);

        for (int i = 1; i < linepointcount; i++)
        //for (int i = 1; i < linesegmentcount; i++)
        {
            float steptimepassed = steptime * i;
            Vector3 movementvector = new Vector3(
                velocity.x * steptimepassed,
                //velocity.y * steptimepassed - 0.5f * Physics.gravity.y * steptimepassed * steptimepassed,
                -0f,
                velocity.z * steptimepassed
                );

            //linepoints.Add(-movementvector + startingpoint);
            Vector3 newpointonline = -movementvector + startingpoint;

            RaycastHit hit;
            if (Physics.Raycast(linepoints[i - 1], newpointonline - linepoints[i - 1], out hit, (newpointonline - linepoints[i - 1]).magnitude))
            {
                linepoints.Add(hit.point);
                break;
            }

            linepoints.Add(newpointonline);
        }

        lr.positionCount = linepoints.Count;
        lr.SetPositions(linepoints.ToArray());
    }
    public void Hideline()
    {
        lr.positionCount = 0;
    }
}


