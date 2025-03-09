using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class Circle
    {
        float mX;
        float mY;
        float mRadius;
        public Circle(float x, float y, float radius)
        {
            mX = x;
            mY = y;
            mRadius = radius;
        }
        public float GetX()
        {
            return mX;
        }
        public float GetY()
        {
            return mY;
        }

        public float GetRadius()
        {
            return mRadius;
        }
        public float GetArea()
        {
            return (float)(Math.PI * Math.Pow(mRadius, 2));
        }
        public bool Contains(float px, float py)
        {
            bool result = false;
            if (Math.Sqrt(Math.Pow(mX - px, 2) + Math.Pow(mY - py, 2)) <= mRadius)
            {
                result = true;
            }
            return result;
        }

        public float GetCircumference()
        {
            return (float)(Math.PI * 2 * mRadius);
        }
    }
}
