using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace XNA_Library
{
    public class Line2D
    {
        public Boolean Intersect(Vector2 line1_1, Vector2 line1_2, Vector2 line2_1, Vector2 line2_2)
        {
            double x1 = (int)line1_1.X;
            double x2 = (int)line1_2.X;
            double x3 = (int)line2_1.X;
            double x4 = (int)line2_2.X;

            double y1 = (int)line1_1.Y;
            double y2 = (int)line1_2.Y;
            double y3 = (int)line2_1.Y;
            double y4 = (int)line2_2.Y;

            // Return false if either of the lines have zero length
            if (x1 == x2 && y1 == y2 ||
                  x3 == x4 && y3 == y4)
            {
                return false;
            }
            // Fastest method, based on Franklin Antonio's "Faster Line Segment Intersection" topic "in Graphics Gems III" book (http://www.graphicsgems.org/)
            double ax = x2 - x1;
            double ay = y2 - y1;
            double bx = x3 - x4;
            double by = y3 - y4;
            double cx = x1 - x3;
            double cy = y1 - y3;

            double alphaNumerator = by * cx - bx * cy;
            double commonDenominator = ay * bx - ax * by;
            if (commonDenominator > 0)
            {
                if (alphaNumerator < 0 || alphaNumerator > commonDenominator)
                {
                    return false;
                }
            }
            else if (commonDenominator < 0)
            {
                if (alphaNumerator > 0 || alphaNumerator < commonDenominator)
                {
                    return false;
                }
            }
            double betaNumerator = ax * cy - ay * cx;
            if (commonDenominator > 0)
            {
                if (betaNumerator < 0 || betaNumerator > commonDenominator)
                {
                    return false;
                }
            }
            else if (commonDenominator < 0)
            {
                if (betaNumerator > 0 || betaNumerator < commonDenominator)
                {
                    return false;
                }
            }
            if (commonDenominator == 0)
            {
                // This code wasn't in Franklin Antonio's method. It was added by Keith Woodward.
                // The lines are parallel.
                // Check if they're collinear.
                double y3LessY1 = y3 - y1;
                double collinearityTestForP3 = x1 * (y2 - y3) + x2 * (y3LessY1) + x3 * (y1 - y2);   // see http://mathworld.wolfram.com/Collinear.html
                // If p3 is collinear with p1 and p2 then p4 will also be collinear, since p1-p2 is parallel with p3-p4
                if (collinearityTestForP3 == 0)
                {
                    // The lines are collinear. Now check if they overlap.
                    if (x1 >= x3 && x1 <= x4 || x1 <= x3 && x1 >= x4 ||
                          x2 >= x3 && x2 <= x4 || x2 <= x3 && x2 >= x4 ||
                          x3 >= x1 && x3 <= x2 || x3 <= x1 && x3 >= x2)
                    {
                        if (y1 >= y3 && y1 <= y4 || y1 <= y3 && y1 >= y4 ||
                              y2 >= y3 && y2 <= y4 || y2 <= y3 && y2 >= y4 ||
                              y3 >= y1 && y3 <= y2 || y3 <= y1 && y3 >= y2)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
        }

        public bool Intersects2(Vector2 xy1, Vector2 xy2,
                                      Vector2 xy3, Vector2 xy4)
        {
            float A = (xy1.X - xy2.X);
            float B = (xy4.X - xy3.X);
            float C = (xy1.Y - xy2.Y);
            float D = (xy4.Y - xy2.Y);
            float E = (xy4.X - xy2.X);
            float F = (xy4.Y - xy2.Y);

            float t = (((D * E) - (B * F)) / ((A * D) - (B * C)));
            float s = ((-(C * E) + (A * F)) / ((A * D) - (B * C)));

            if (((0 <= t) && (t <= 1)) && ((0 <= s) && (s <= 1)))
            {
                return true;
            }
            return false;
        }

        public static int relativeCCW(double x1, double y1,
                      double x2, double y2,
                      double px, double py)
        {
            x2 -= x1;
            y2 -= y1;
            px -= x1;
            py -= y1;
            double ccw = px * y2 - py * x2;
            if (ccw == 0.0)
            {
                // The point is colinear, classify based on which side of
                // the segment the point falls on.  We can calculate a
                // relative value using the projection of px,py onto the
                // segment - a negative value indicates the point projects
                // outside of the segment in the direction of the particular
                // endpoint used as the origin for the projection.
                ccw = px * x2 + py * y2;
                if (ccw > 0.0)
                {
                    // Reverse the projection to be relative to the original x2,y2
                    // x2 and y2 are simply negated.
                    // px and py need to have (x2 - x1) or (y2 - y1) subtracted
                    //    from them (based on the original values)
                    // Since we really want to get a positive answer when the
                    //    point is "beyond (x2,y2)", then we want to calculate
                    //    the inverse anyway - thus we leave x2 & y2 negated.
                    px -= x2;
                    py -= y2;
                    ccw = px * x2 + py * y2;
                    if (ccw < 0.0)
                    {
                        ccw = 0.0;
                    }
                }
            }
            return (ccw < 0.0) ? -1 : ((ccw > 0.0) ? 1 : 0);
        }

        /**
         * Tests if the line segment from {@code (x1,y1)} to 
         * {@code (x2,y2)} intersects the line segment from {@code (x3,y3)} 
         * to {@code (x4,y4)}.
         *
         * @param x1 the X coordinate of the start point of the first
         *           specified line segment
         * @param y1 the Y coordinate of the start point of the first
         *           specified line segment
         * @param x2 the X coordinate of the end point of the first
         *           specified line segment
         * @param y2 the Y coordinate of the end point of the first
         *           specified line segment
         * @param x3 the X coordinate of the start point of the second
         *           specified line segment
         * @param y3 the Y coordinate of the start point of the second
         *           specified line segment
         * @param x4 the X coordinate of the end point of the second
         *           specified line segment
         * @param y4 the Y coordinate of the end point of the second
         *           specified line segment
         * @return <code>true</code> if the first specified line segment 
         *			and the second specified line segment intersect  
         *			each other; <code>false</code> otherwise.  
         * @since 1.2
         */
        public Boolean Intersect3(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            return ((relativeCCW(x1, y1, x2, y2, x3, y3) *
                 relativeCCW(x1, y1, x2, y2, x4, y4) <= 0)
                && (relativeCCW(x3, y3, x4, y4, x1, y1) *
                    relativeCCW(x3, y3, x4, y4, x2, y2) <= 0));
        }

        public static void renderVectors(XNA_Library.PrimitiveBatch pb, LinkedList<Vector2> list)
        {
            foreach (Vector2 v in list)
            {
                pb.AddVertex(v, Color.White);
            }
        }
    }
}
