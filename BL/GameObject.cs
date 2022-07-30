using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaseStudy.BL
{
    internal class GameObject
    {
        private char[,] shape;  
        private Point startingPoint;
        private Boundary premises;
        private string direction;
        public GameObject()
        {
            shape = new char[1, 3] { { '.', '.', '.' } };
            startingPoint =new Point(0,0);
            premises = new Boundary();
            direction = "LeftToRight";
        }
        public GameObject(char[,] shape,Point startingPoint, Boundary premises,string direction)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = premises;
            this.direction = direction;
        }
        public char[,] getShape()
        {
            return shape;
        }

            bool flag=true;
        public void move()
        {
            if (direction == "LeftToRight")
            {
                if (startingPoint.y <= premises.getTopRight().y)
                {
                    startingPoint.y += 1;//left to right 
                    Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                }
            }
            else if(direction == "RightToLeft")
            {
                if ( startingPoint.y > premises.getTopLeft().y)
                {
                    startingPoint.y -= 1;//right to left
                    Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                }
            }
            else if (direction == "Patrol")
            {
                if (startingPoint.y ==premises.getTopLeft().y)
                {
                    flag = true;

                }
                else if((startingPoint.y ==premises.getTopRight().y))
                {
                    flag=false;
                }
                if (flag==true)
                {
                    if (startingPoint.y <= premises.getTopRight().y)
                    {
                        startingPoint.y += 1;//left to right 
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);

                    }
                }
                else if(flag==false)
                {
                    if (startingPoint.y > premises.getTopLeft().y)
                    {
                        startingPoint.y -= 1;//right to left
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                    }
                }
            }
            else if( direction == "Diagonal")
            {
                if(startingPoint.x < premises.getBottomRight().x && startingPoint.y < premises.getBottomRight().y)
                {
                     startingPoint.y += 1;
                     startingPoint.x += 1;
                     Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                }
            }
            else if(direction == "Projectile")
            {
                if (startingPoint.y < premises.getBottomRight().y)
                {
                    if (startingPoint.y <= premises.getBottomRight().y/2)
                    {
                        startingPoint.x -= 1;
                        startingPoint.y += 1;
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                        startingPoint.y += 5;
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                        startingPoint.x -= 1;
                        startingPoint.y -= 1;
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                    }
                    if (startingPoint.y >= premises.getBottomRight().y/2)
                    {
                        startingPoint.x += 3;
                        startingPoint.y += 4;
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                        startingPoint.y -= 3;
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                        startingPoint.x += 3;
                        startingPoint.y -= 2;
                        Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                    }
                }
            }
        }
        public void erase()
        {
            int x = shape.GetLength(0);
            int y = shape.GetLength(1);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.SetCursorPosition(startingPoint.y, startingPoint.x);
                    Console.Write(" ");
                    startingPoint.y++;
                }
                startingPoint.x++;
                startingPoint.y -= y;
            }
            startingPoint.x -= x;
        }
    }
}
