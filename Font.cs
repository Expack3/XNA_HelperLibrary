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

namespace CISP335_Library
{
    public class Font
    {
        public static void WriteText(PrimitiveBatch pb, float x, float y, float scale, Color color, String text)
        {
            text = text.ToUpper();

            LinkedList<Vector2> list = new LinkedList<Vector2>();
            char letter = ' ';

            Vector2 pos = new Vector2(x, y);
            Vector2 newPos = new Vector2(x, y);

            for (int i = 0; i < text.Length; i++)
            {
                letter = text[i];

                list = getLetter(letter);

                newPos.X = pos.X + (scale * 4 * i);

                foreach (Vector2 v in list)
                {
                    pb.AddVertex(newPos + (v * scale), color);
                }
            }
        }

        public static LinkedList<Vector2> getLetter(char letter)
        {
            LinkedList<Vector2> list = new LinkedList<Vector2>();

            switch (letter)
            {
                case 'A':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case 'B':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'C':
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'D':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'E':
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'F':
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    break;
                case 'G':
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'H':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case 'I':
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    break;
                case 'J':
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    break;
                case 'K':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'L':
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    break;
                case 'M':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'N':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'O':
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'P':
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'Q':
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    break;
                case 'R':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case 'S':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'T':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    break;
                case 'U':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'V':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'W':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case 'X':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    break;
                case 'Y':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    break;
                case 'Z':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '0':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case '1':
                    list.AddLast(new Vector2(1.0f, 0.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    break;
                case '2':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '3':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case '4':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '5':
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    break;
                case '6':
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    break;
                case '7':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    break;
                case '8':
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(0.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    break;
                case '9':
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(2.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 0.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(0.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    break;
                case '.':
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 1.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(2.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 2.0f));
                    list.AddLast(new Vector2(1.0f, 1.0f));
                    break;
                default:
                    break;
            }

            return list;
        }
    }
}
