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
        private Node _firstNode;
        private Node _secondNode;

        private const int fontSize = 10;
        private bool _visited;

        public Edge(Node firstNode, Node secondNode)
        {
            this._firstNode = firstNode;
            this._secondNode = secondNode;
            _visited = false;
        }

        public Edge(Node firstNode, Node secondNode, double distance) : this(firstNode, secondNode)
        {
            this._distance = distance;
        }

        public Node FirstNode
        {
            get { return this._firstNode; }
            set { this._firstNode = value; }
        }

        public Node SecondNode
        {
            get { return this._secondNode; }
            set { this._secondNode = value; }
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
