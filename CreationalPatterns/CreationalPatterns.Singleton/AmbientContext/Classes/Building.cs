using System.Collections.Generic;
using System.Text;

namespace AmbientContext.Classes
{
    public class Building
    {
        public List<Wall> Walls = new List<Wall>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Wall wall in Walls)
            {
                sb.AppendLine(wall.ToString());
            }

            return sb.ToString();
        }
    }
}
