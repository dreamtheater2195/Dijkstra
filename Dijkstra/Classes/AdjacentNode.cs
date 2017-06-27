using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Classes
{
    public class AdjacentNode: IComparable<AdjacentNode>
    {
        private Node _node;
        private Edge _edgeCameFrom;
        public AdjacentNode(Node node, Edge edgeCameFrom)
        {
            this._node = node;
            this._edgeCameFrom = edgeCameFrom;
        }

        public double TotalCost
        {
            get { return _node.TotalCost; }
        }

        public Node Node
        {
            get { return this._node; }
            set { this._node = value; }
        }

        public Edge EdgeCameFrom
        {
            get { return this._edgeCameFrom; }
            set { this._edgeCameFrom = value; }
        }

        public int CompareTo(AdjacentNode rn)
        {
            return this.Node.TotalCost.CompareTo(rn.Node.TotalCost);
        }
    }
}
