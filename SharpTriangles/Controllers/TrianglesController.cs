using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using SharpTriangles.Models;

namespace SharpTriangles.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TrianglesController : ApiController
    {
        // GET api/triangles/ID
        public Point[] Get(string id)
        {
            char letter = id[0];
            int col;
            if (!char.IsLetter(letter) || !int.TryParse(id.Substring(1), out col))
                return null;
            col -= 1;
            if (col < 0)
                return null;
            int row = char.ToLower(letter) - 'a';
            Point start = new Point(y:row * 10,x: (col /2) * 10);
            Point second = start;
            if (col % 2 == 0)
                second.Y += 10;
            else
                second.X += 10;
            Point third = new Point(y:start.Y + 10,x:start.X + 10);
            return new[] {start, second, third};
        }
    }
}