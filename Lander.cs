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
using CISP335_Library;

namespace XNA_Library
{
    public class Lander
    {
        private float FUEL_AMOUNT = 100.0f;
        private static LinkedList<Vector2> boxList;
        private Line2D line2d;
        private static Vector2 pivot = new Vector2(4.0f, 1.0f);
        Boolean isLanderCrashed = false;

        public Lander()
        {
            line2d = new CISP335_Library.Line2D();
        }

        public float getFuel()
        {
            return FUEL_AMOUNT;
        }

        public void setFuel(float fuelAmount)
        {
            if (((FUEL_AMOUNT + fuelAmount) >= 0.0f) && ((FUEL_AMOUNT + fuelAmount) <= 100.0f))
            {
                FUEL_AMOUNT = FUEL_AMOUNT + fuelAmount;
            }
        }

        public static LinkedList<Vector2> setBoundingBox(float x, float y, float scale, float angle)
        {
            LinkedList<Vector2> boxList = new LinkedList<Vector2>();

            boxList.AddLast((RotateVector2((new Vector2(0.0f, 0.0f)), angle, pivot)) * scale + new Vector2(x, y));
            boxList.AddLast((RotateVector2((new Vector2(0.0f, 2.0f)), angle, pivot)) * scale + new Vector2(x, y));

            boxList.AddLast((RotateVector2((new Vector2(0.0f, 2.0f)), angle, pivot)) * scale + new Vector2(x, y));
            boxList.AddLast((RotateVector2((new Vector2(10.0f, 2.0f)), angle, pivot)) * scale + new Vector2(x, y));

            boxList.AddLast((RotateVector2((new Vector2(10.0f, 2.0f)), angle, pivot)) * scale + new Vector2(x, y));
            boxList.AddLast((RotateVector2((new Vector2(10.0f, 0.0f)), angle, pivot)) * scale + new Vector2(x, y));

            boxList.AddLast((RotateVector2((new Vector2(10.0f, 0.0f)), angle, pivot)) * scale + new Vector2(x, y));
            boxList.AddLast((RotateVector2((new Vector2(0.0f, 0.0f)), angle, pivot)) * scale + new Vector2(x, y));
            
            return boxList;
        }

        static LinkedList<Vector2> getBoundingBox()
        {
            return boxList;
        }

        public void rotateLander(float scale, float x, float y)
        {
            Vector2 rotateCenter = new Vector2((1 + x) * scale, (4 + y) * scale);
        }

        public Boolean getLanderCrashed()
        {
            return isLanderCrashed;
        }  
        
        public Boolean setLanderCrashed(LinkedList<VertexPositionColor> terrainPortion, float x, float y, float scale, float angle)
        {
            int pair1 = 1;
            int pair2 = 1;
            Vector2 line1_1 = new Vector2(0.0f,0.0f);
            Vector2 line1_2 = new Vector2(0.0f,0.0f);
            Vector2 line2_1 = new Vector2(0.0f,0.0f);
            Vector2 line2_2 = new Vector2(0.0f,0.0f);
            boxList = setBoundingBox(x, y, scale, angle);

            //determine whether the ship has crashed into a section of terrain by determining whether the
            //terrain line and bounding box for the ship intersect
            foreach (VertexPositionColor vpc in terrainPortion)
            {
                //find second (terrain) line first
                if(pair2 == 1)
                {
                    line2_1 = new Vector2(vpc.Position.X, vpc.Position.Y);
                    ++pair2;
                }
                else
                {
                    line2_2 = new Vector2(vpc.Position.X, vpc.Position.Y);
                    ++pair2;
                }
                if(pair2 == 3)//once second line is found, find all possible first (bounding box) lines
                {
                    foreach (Vector2 v in boxList)
                    {
                        //first first line
                        if (pair1 == 1)
                        {
                            line1_1 = v;
                            ++pair1;
                        }
                        else
                        {
                            line1_2 = v;
                            ++pair1;
                        }
                        if (pair1 == 3)//once first line is found, test for intersection
                        {
                            //isLanderCrashed = line2d.Intersect(line1_1, line1_2  , line2_1, line2_2);
                            isLanderCrashed = line2d.Intersect3(line1_1.X, line1_1.Y, line1_2.X, line1_2.Y, line2_1.X, line2_1.Y, line2_2.X, line2_2.Y);
                            /*if (line1_1.Y >= line2_1.Y && line1_2.Y >= line2_2.Y)
                            {
                                isLanderCrashed = true;
                            }*/
                            if(isLanderCrashed != true)
                            {
                            pair1 = 1;
                            }
                            else //change value of isLanderCrashed and return result
                            {
                                isLanderCrashed = true;
                                return isLanderCrashed;
                            }
                        }
                    }
                    pair2 = 1;
                }
            }
            //if intersection is not found, reset isLanderCrashed to default value and return result
            isLanderCrashed = false; 
            return isLanderCrashed;
        }
                

        static LinkedList<Vector2> landerList(float rotateX, float rotateY)
        {
            
            LinkedList<Vector2> textList = new LinkedList<Vector2>();

            textList.AddLast(new Vector2(0.0f + rotateX, 0.0f + rotateY));
            textList.AddLast(new Vector2(2.0f + rotateX, 2.0f + rotateY));

            textList.AddLast(new Vector2(2.0f + rotateX, 2.0f + rotateY));
            textList.AddLast(new Vector2(8.0f + rotateX, 2.0f + rotateY));

            textList.AddLast(new Vector2(8.0f - rotateX, 2.0f - rotateY));
            textList.AddLast(new Vector2(10.0f - rotateX, 0.0f - rotateY));

            textList.AddLast(new Vector2(10.0f - rotateX, 0.0f - rotateY));
            textList.AddLast(new Vector2(0.0f - rotateX, 0.0f - rotateY));

            return textList;
        }

        static LinkedList<Vector2> landerList()
        {
            LinkedList<Vector2> textList = new LinkedList<Vector2>();

            textList.AddLast(new Vector2(0.0f, 0.0f));
            textList.AddLast(new Vector2(2.0f, 2.0f));

            textList.AddLast(new Vector2(2.0f, 2.0f));
            textList.AddLast(new Vector2(8.0f, 2.0f));

            textList.AddLast(new Vector2(8.0f, 2.0f));
            textList.AddLast(new Vector2(10.0f, 0.0f));

            textList.AddLast(new Vector2(10.0f, 0.0f));
            textList.AddLast(new Vector2(0.0f, 0.0f));

            return textList;
        }

        public static void renderPivot(CISP335_Library.PrimitiveBatch pb)
        {
            pb.AddVertex(pivot, Color.Green);
            pb.AddVertex(pivot, Color.Green);
        }

        
        public void getLander(CISP335_Library.PrimitiveBatch pb, float x, float y, float angle, float scale, Color color)
        {
            LinkedList<Vector2> list2 = landerList();
            foreach (Vector2 v in list2)
            {
                float Xrotated = pivot.X + (v.X - pivot.X) * (float)Math.Cos(angle) - (v.Y - pivot.Y) * (float)Math.Sin(angle);
                float Yrotated = pivot.Y + (v.X - pivot.X) * (float)Math.Sin(angle) + (v.Y - pivot.Y) * (float)Math.Cos(angle);
                pb.AddVertex(new Vector2(x + (Xrotated * scale), y + (Yrotated * scale)), color);
            }
        }

        public static Vector2 getPivot()
        {
            return pivot;
        }

        public static void setPivot(float x, float y, float scale)
        {
            pivot = new Vector2(4.0f, 1.0f);
        }

        private static Vector2 RotateVector2(Vector2 point, float rotation, Vector2 pivot)
        {
            Vector2 tempPoint = point;

            float Xrotated = pivot.X + (tempPoint.X - pivot.X) * (float)Math.Cos(rotation) - (tempPoint.Y - pivot.Y) * (float)Math.Sin(rotation);
            float Yrotated = pivot.Y + (tempPoint.X - pivot.X) * (float)Math.Sin(rotation) + (tempPoint.Y - pivot.Y) * (float)Math.Cos(rotation);

            point = new Vector2(Xrotated, Yrotated);

            return point;
        }
    }
}