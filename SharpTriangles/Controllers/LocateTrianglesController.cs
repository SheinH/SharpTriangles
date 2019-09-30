using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace SharpTriangles.Controllers
{
    public class LocateTrianglesController : ApiController
    {
        // GET api/locate/5/5/10/10/15/15
        public string Get(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            var a = new []{new Point(x1,y1), new Point(x2,y2), new Point(x3,y3) };
            Array.Sort(a, (x, y) =>
            {
                if (x.Y != y.Y)
                    return x.Y - y.Y;
                else return x.X - y.X;
            });
            int row = a[0].Y / 10;
            int col = (a[0].X + a[1].X) / 10 + 1;
            char c = (char) ('A' + row);
            return c.ToString() + col;
        }
    }
}