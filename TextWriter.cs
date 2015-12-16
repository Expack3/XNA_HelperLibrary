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
    public class TextWriter
    {
        static LinkedList<Vector2> getText(char letter, float scale)
        {
            LinkedList<Vector2> textList = new LinkedList<Vector2>();

            switch (letter)
            {
                case 'A':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(1.0f, 0.0f));

                    textList.AddLast(new Vector2(1.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case 'B':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'C':
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'D':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(1.0f, 0.0f));

                    textList.AddLast(new Vector2(1.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'E':
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(1.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'F':
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    break;
                case 'G':
                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'H':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case 'I':
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(1.0f, 2.0f));

                    textList.AddLast(new Vector2(1.0f, 2.0f));
                    textList.AddLast(new Vector2(1.0f, 0.0f));
                    break;
                case 'J':
                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    break;
                case 'K':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'L':
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    break;
                case 'M':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(1.0f, 1.0f));

                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'N':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'O':
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'P':
                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'Q':
                    textList.AddLast(new Vector2(1.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(1.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    break;
                case 'R':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'S':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'T':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(1.0f, 0.0f));
                    textList.AddLast(new Vector2(1.0f, 2.0f));

                    break;
                case 'U':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    break;
                case 'V':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(1.0f, 2.0f));

                    textList.AddLast(new Vector2(1.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'W':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(1.0f, 1.0f));

                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    break;
                case 'X':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'Y':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(1.0f, 1.0f));

                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    textList.AddLast(new Vector2(1.0f, 2.0f));
                    break;
                case 'Z':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '0':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case '1':
                    textList.AddLast(new Vector2(1.0f, 0.0f));
                    textList.AddLast(new Vector2(1.0f, 2.0f));
                    break;
                case '2':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '3':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case '4':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '5':
                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case '6':
                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    break;
                case '7':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '8':
                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 2.0f));

                    textList.AddLast(new Vector2(0.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    break;
                case '9':
                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(2.0f, 0.0f));

                    textList.AddLast(new Vector2(2.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 0.0f));

                    textList.AddLast(new Vector2(0.0f, 0.0f));
                    textList.AddLast(new Vector2(0.0f, 1.0f));

                    textList.AddLast(new Vector2(0.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case '.':
                    textList.AddLast(new Vector2(1.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 1.0f));

                    textList.AddLast(new Vector2(2.0f, 1.0f));
                    textList.AddLast(new Vector2(2.0f, 2.0f));

                    textList.AddLast(new Vector2(2.0f, 2.0f));
                    textList.AddLast(new Vector2(1.0f, 2.0f));

                    textList.AddLast(new Vector2(1.0f, 2.0f));
                    textList.AddLast(new Vector2(1.0f, 1.0f));

                    break;
                default:
                    break;

            }

            return textList;
        }

        public void WriteText(XNA_Library.PrimitiveBatch pb, float x, float y, float scale, Color color, int enumeration, String text)
        {
            int stringPos = 0;
            Vector2 offset = new Vector2(0, 0);
            Vector2 startPos = new Vector2(x, y);
            switch(enumeration)
            {
                case 1:
                    break;
                case 2:
                    startPos = new Vector2(startPos.X + (5 * scale), startPos.Y);
                    break;
                case 3:
                    startPos = new Vector2(startPos.X + (10 * scale), startPos.Y);
                    break;
                default:
                    break;
            }
            char ch = text[stringPos];
            LinkedList<Vector2> list2 = getText(' ', 1);

            while (text.Length != stringPos)
            {
                ch = Char.ToUpper(text[stringPos]);
                if ((ch > 64 && ch < 91) || (ch >= 48 && ch <= 57) || (ch == '.'))
                {
                    list2 = getText(ch, scale);
                    stringPos++;
                    foreach (Vector2 v in list2)
                    {
                        pb.AddVertex((offset + startPos + (v * scale)), color);
                    }
                }
                else
                {
                    stringPos++;
                }
                offset += new Vector2(3, 0) * (scale * 3);
            }
        }
    }
}
