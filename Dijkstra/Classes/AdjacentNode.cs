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
        private Edge _edge;
        public AdjacentNode(Node node, Edge edge)
        {
            this._node = node;
            this._edge = edge;
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

        public Edge Edge
        {
            get { return this._edge; }
            set { this._edge = value; }
        }

        public int CompareTo(AdjacentNode rn)
        {
            return this.Node.TotalCost.CompareTo(rn.Node.TotalCost);
        }
    }
}
