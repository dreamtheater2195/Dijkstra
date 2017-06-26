using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Classes
{
    public class AdjacentNodeList
    {
        private List<AdjacentNode> _anList;
        private List<Node> _nodes;
        private Dictionary<Node, AdjacentNode> _anDictionary;

        public AdjacentNodeList()
        {
            _anList = new List<AdjacentNode>();
            _nodes = new List<Node>();
            _anDictionary = new Dictionary<Node, AdjacentNode>();
        }

        public void AddAdjacentNode(AdjacentNode rn)
        {
            _anList.Add(rn);
            _nodes.Add(rn.Node);
            _anDictionary.Add(rn.Node, rn);
        }

        public AdjacentNode GetAdjacentNode(Node n)
        {
            if (_anDictionary.ContainsKey(n))
            {
                return _anDictionary[n];
            }
            else
            {
                return null;
            }
        }

        public List<AdjacentNode> AdjacentNodes
        {
            get { return this._anList; }
        }

        public void RemoveAdjacentNode(AdjacentNode rn)
        {
            _anList.Remove(rn);
            _nodes.Remove(rn.Node);
        }

        public bool HasNode(Node n)
        {
            return _nodes.Contains(n);
        }

        public void SortAdjacentNodes()
        {
            _anList.Sort();
        }
        public void Clear()
        {
            this._anList.Clear();
            this._nodes.Clear();
            this._anDictionary.Clear();
        }
    }
}
