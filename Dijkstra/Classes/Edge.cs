using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Classes
{
    public class Edge:IComparable<Edge> 
    {
        private double _distance;
        private Node _sourceNode;
        private Node _destNode;

        private const int fontSize = 10;
        private bool _visited;

        public Edge(Node sourceNode, Node destNode)
        {
            this._sourceNode = sourceNode;
            this._destNode = destNode;
            _visited = false;
        }

        public Edge(Node sourceNode, Node destNode, double distance) : this(sourceNode, destNode)
        {
            this._distance = distance;
        }

        public Node SourceNode
        {
            get { return this._sourceNode; }
            set { this._sourceNode = value; }
        }

        public Node DestNode
        {
            get { return this._destNode; }
            set { this._destNode = value; }
        }

        public double Distance
        {
            get { return this._distance; }
            set { this._distance = value; }
        }

        public void Reset()
        {
            _visited = false;
        }

        public int CompareTo(Edge e)
        {
            return this.Visited.CompareTo(e.Visited);
        }

        public bool Visited
        {
            get { return _visited; }
            set { this._visited = value; }
        }
    }
}
