using Dijkstra.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class frmMain : Form
    {
        #region Member variables
        private const int _diameter = 30;
        private const double _edgeLabelSize = 20;

        private const int _fontSize = 10;
        private const int _edgeFontSize = 10;

        private int _nodesCount;
        private bool _findMinDistance;

        private List<Node> _sptSet;
        private AdjacentNodeList _adjacentNodes;

        private List<Node> _nodes;
        private List<Edge> _edges;

        private Node _edgeNode1, _edgeNode2;
        private SolidBrush _visitedBrushNode, _unvisitedBrushNode, _unvisitedBrushEdge, _visitedBrushEdge, _brushDistanceLabel, _visitedBrushNodeBorder;
        private bool _isGraphConnected;
        #endregion

        public frmMain()
        {
            InitializeComponent();

            _sptSet = new List<Node>();
            _adjacentNodes = new AdjacentNodeList();

            _nodes = new List<Node>();
            _edges = new List<Edge>();

            _nodesCount = 1;
            _findMinDistance = false;
            _isGraphConnected = true;

            _unvisitedBrushEdge = new SolidBrush(Color.DimGray);
            _visitedBrushEdge = new SolidBrush(Color.Firebrick);
            _brushDistanceLabel = new SolidBrush(Color.Teal);

            _unvisitedBrushNode = new SolidBrush(Color.DarkBlue);
            _visitedBrushNode = new SolidBrush(Color.Firebrick);
            _visitedBrushNodeBorder = new SolidBrush(Color.RoyalBlue);

            cbCustomDistance.Checked = false;
            cbDirectedGraph.Checked = false;

            this.ActiveControl = txtNumNodes;
        }

        #region Paint
        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point clickPoint = e.Location;
                if (HasClickedOnNode(clickPoint.X, clickPoint.Y))
                {
                    AssignEndNode(clickPoint.X, clickPoint.Y);
                    if (_edgeNode1 != null && _edgeNode2 != null)
                    {
                        if (_findMinDistance)
                        {
                            statusLabel.Text = "Calculating...";
                            FindShortestPath(_edgeNode1, _edgeNode2);
                            PaintShortestPath(_edgeNode1, _edgeNode2);
                        }
                        else
                        {
                            //build an edge
                            double distance = 0.0;
                            if (cbCustomDistance.Checked)
                                distance = GetEdgeDistance();
                            else
                            {
                                distance = GetDistance(_edgeNode1.Center, _edgeNode2.Center);
                                distance = Math.Floor(distance / 10);
                            }

                            if (distance != 0.0)
                            {
                                if (OverlapsEdge(_edgeNode1, _edgeNode2))
                                {
                                    MessageBox.Show("Cannot add an overlapped edge. Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ClearEdgeNodes();
                                    return;
                                }
                                Edge edge = CreateEdge(_edgeNode1, _edgeNode2, distance);
                                _edges.Add(edge);

                                _edgeNode1.Edges.Add(edge);
                                _edgeNode2.Edges.Add(edge);
                                
                                canvasPanel.Invalidate();
                            }

                            ClearEdgeNodes();
                        }
                    }
                }
                else
                {
                    //Build a node
                    if (!OverlapsNode(clickPoint))
                    {
                        Node n = CreateNode(clickPoint);
                        _nodes.Add(n);
                        canvasPanel.Invalidate();
                        _nodesCount++;
                        ClearEdgeNodes();
                    }
                }
            }
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_edges.Count > 0)
                gbOptions.Enabled = false;

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //Paint all edges 
            _edges.Sort();
            Pen p;
            foreach (Edge edge in _edges)
            {
                int firstx = edge.SourceNode.Center.X;
                int firsty = edge.SourceNode.Center.Y;

                int secondx = edge.DestNode.Center.X;
                int secondy = edge.DestNode.Center.Y;
                if (edge.SourceNode.Center.X > edge.DestNode.Center.X)
                {
                    firstx -= (_diameter / 2 - 5);
                    secondx += (_diameter / 2 - 5);
                }
                else
                {
                    firstx += (_diameter / 2 - 5);
                    secondx -= (_diameter / 2 - 5);
                }

                if (edge.SourceNode.Center.Y > edge.DestNode.Center.Y)
                {
                    firsty -= (_diameter / 2 - 5);
                    secondy += (_diameter / 2 - 5);
                }
                else
                {
                    firsty += (_diameter / 2 - 5);
                    secondy -= (_diameter / 2 - 5);
                }
                if (edge.Visited)
                {
                    p = new Pen(_visitedBrushEdge, 2);
                }
                else
                {
                    p = new Pen(_unvisitedBrushEdge, 2);
                }
                if (cbDirectedGraph.Checked)
                {
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                    p.CustomEndCap = bigArrow;
                    e.Graphics.DrawLine(p, new Point(firstx, firsty), new Point(secondx, secondy));
                }
                else
                {
                    e.Graphics.DrawLine(p, new Point(edge.SourceNode.Center.X, edge.SourceNode.Center.Y), new Point(edge.DestNode.Center.X, edge.DestNode.Center.Y));
                }

                //paint the distance label
                Point edgeLabelLocation = GetEdgeLabelLocation(edge);
                using (Font the_font = new Font("Tahoma", _fontSize, FontStyle.Regular, GraphicsUnit.Point))
                {
                    SizeF text_size = e.Graphics.MeasureString(edge.Distance.ToString(), the_font);
                    if (edge.Visited)
                    {
                        e.Graphics.FillEllipse(_visitedBrushEdge, edgeLabelLocation.X - text_size.Width / 2, edgeLabelLocation.Y - text_size.Height / 2, text_size.Width + 5, text_size.Height + 5);
                    } else
                    {
                        e.Graphics.FillEllipse(_brushDistanceLabel, edgeLabelLocation.X - text_size.Width / 2, edgeLabelLocation.Y - text_size.Height / 2, text_size.Width + 5, text_size.Height + 5);
                    }
                    e.Graphics.DrawString(edge.Distance.ToString(), the_font, Brushes.White, edgeLabelLocation.X - text_size.Width/2 + 3, edgeLabelLocation.Y - text_size.Height/2 + 3);
                }
            }
            //Paint all nodes
            foreach (Node node in _nodes)
            {
                if (node.Visited)
                {
                    e.Graphics.DrawEllipse(new Pen(_visitedBrushNodeBorder, 2), node.Location.X, node.Location.Y, _diameter, _diameter);
                    e.Graphics.FillEllipse(_visitedBrushNode, node.Location.X, node.Location.Y, _diameter, _diameter);
                }
                else
                {
                    e.Graphics.FillEllipse(_unvisitedBrushNode, node.Location.X, node.Location.Y, _diameter, _diameter);
                }
                using (Font the_font = new Font("Tahoma", _fontSize, FontStyle.Regular, GraphicsUnit.Point))
                {
                    e.Graphics.DrawString(node.Label, the_font, Brushes.White, node.Center.X, node.Center.Y, format);
                }
            }
        }
        private void PaintShortestPath(Node start, Node end)
        {
            foreach (Node n in _nodes)
                n.Visited = false;

            foreach (Edge e in _edges)
                e.Visited = false;

            if (_isGraphConnected)
            {
                Node currentNode = end;
                double totalCost = 0;
                Stack<Node> shortestPath = new Stack<Node>();
                while (currentNode != start)
                {
                    currentNode.Visited = true;
                    currentNode.EdgeCameFrom.Visited = true;
                    totalCost += currentNode.EdgeCameFrom.Distance;
                    shortestPath.Push(currentNode);
                    currentNode = GetNeighbourNode(currentNode, currentNode.EdgeCameFrom);
                }

                start.Visited = true;
                shortestPath.Push(start);

                statusLabel.Text = "Shortest path from " + start.Label + " to " + end.Label + " is: \"";
                while (shortestPath.Count > 1)
                {
                    currentNode = shortestPath.Pop();
                    statusLabel.Text += currentNode.Label + " -> ";
                }
                currentNode = shortestPath.Pop();
                statusLabel.Text += currentNode.Label + "\"";
                statusLabel.Text += " with total cost: " + totalCost.ToString();

                canvasPanel.Invalidate();
            }
            else
            {
                ClearEdgeNodes();
                _isGraphConnected = true;
                _findMinDistance = false;
                statusLabel.Text = "Click on the canvas to create a node.";
                MessageBox.Show("Cannot find a path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        private Point GetEdgeLabelLocation(Edge edge)
        {
            int x = Math.Abs(edge.SourceNode.Center.X - edge.DestNode.Center.X) / 2;
            int y = Math.Abs(edge.SourceNode.Center.Y - edge.DestNode.Center.Y) / 2;

            if (edge.SourceNode.Center.X > edge.DestNode.Center.X)
                x += edge.DestNode.Center.X;
            else
                x += edge.SourceNode.Center.X;

            if (edge.SourceNode.Center.Y > edge.DestNode.Center.Y)
                y += edge.DestNode.Center.Y;
            else
                y += edge.SourceNode.Center.Y;

            return new Point(x, y);
        }

        private bool HasClickedOnNode(int x, int y)
        {
            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i].HasPoint(new Point(x, y)))
                {
                    return true;
                }
            }
            return false;
        }

        private bool OverlapsNode(Point p)
        {
            double distance;
            for (int i = 0; i < _nodes.Count; i++)
            {
                distance = GetDistance(p, _nodes[i].Center);
                if (distance < _diameter)
                {
                    return true;
                }
            }
            return false;
        }

        private bool OverlapsEdge(Node edgeNode1, Node edgeNode2)
        {
            for (int i = 0; i < _edges.Count;i++)
            {
                if (cbDirectedGraph.Checked)
                {
                    if (edgeNode1 == _edges[i].SourceNode && edgeNode2 == _edges[i].DestNode)
                    {
                        return true;
                    }
                } else
                {
                    if ((edgeNode1 == _edges[i].SourceNode && edgeNode2 == _edges[i].DestNode) || (edgeNode1 == _edges[i].DestNode && edgeNode2 == _edges[i].SourceNode))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private double GetEdgeDistance()
        {
            double distance = 0.0;
            frmInputDistance dd = new frmInputDistance();
            dd.StartPosition = FormStartPosition.CenterParent;
            dd.Owner = this;

            dd.ShowDialog();
            distance = dd.Distance;

            return distance;
        }

        private double GetDistance(Point p1, Point p2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)), 2);
        }

        private void AssignEndNode(int x, int y)
        {
            Node node = GetNodeAt(x, y);
            if (node != null)
            {
                if (_edgeNode1 == null)
                {
                    _edgeNode1 = node;
                    statusLabel.Text = "Selected node " + node.Label + ". Please select another one.";
                }
                else
                {
                    if (node != _edgeNode1)
                    {
                        _edgeNode2 = node;
                        statusLabel.Text = "Click on the canvas to create a node.";
                    }
                }
            }
        }

        private Node GetNodeAt(int x, int y)
        {
            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i].HasPoint(new Point(x, y)))
                {
                    return _nodes[i];
                }
            }
            return null;
        }

        private Node CreateNode(Point p)
        {
            int nodeLocationX = p.X - _diameter / 2;
            int nodeLocationY = p.Y - _diameter / 2;
            return new Node(new Point(nodeLocationX, nodeLocationY), p, _nodesCount.ToString(), _diameter);
        }

        private Edge CreateEdge(Node node1, Node node2, double distance)
        {
            return new Edge(node1, node2, distance);
        }

        private void FindShortestPath(Node start, Node end)
        {
            _sptSet.Clear();
            _adjacentNodes.Clear();
            Node currentNode = start;
            currentNode.Visited = true;
            start.TotalCost = 0;
            _sptSet.Add(currentNode);
            AdjacentNode currentAdjacentNode;

            while (currentNode != end)
            {
                AddAdjacentNodes(currentNode);
                UpdateAdjacentNodesTotalCost(currentNode);

                if (_adjacentNodes.AdjacentNodes.Count == 0)
                {
                    _isGraphConnected = false;
                    break;
                }

                currentAdjacentNode = _adjacentNodes.AdjacentNodes[0];
                _adjacentNodes.RemoveAdjacentNode(currentAdjacentNode);

                currentNode = currentAdjacentNode.Node;
                currentNode.EdgeCameFrom = currentAdjacentNode.EdgeCameFrom;
                _sptSet.Add(currentNode);
            }
        }

        private void AddAdjacentNodes(Node node)
        {
            Node neighbour;
            AdjacentNode an;
            foreach (Edge edge in node.Edges)
            {
                neighbour = GetNeighbourNode(node, edge);
                if (cbDirectedGraph.Checked && neighbour != edge.DestNode) continue;
                if ((node.EdgeCameFrom == null || neighbour != GetNeighbourNode(node, node.EdgeCameFrom)))
                {
                    if (!_sptSet.Contains(neighbour))
                    {
                        if (_adjacentNodes.HasNode(neighbour))
                        {
                            if (node.TotalCost + edge.Distance < neighbour.TotalCost)
                            {
                                an = _adjacentNodes.GetAdjacentNode(neighbour);
                                an.EdgeCameFrom = edge;
                            }
                        }
                        else
                        {
                            an = new AdjacentNode(neighbour, edge);
                            _adjacentNodes.AddAdjacentNode(an);
                        }
                    }
                }
            }
        }

        private void btnfindMin_Click(object sender, EventArgs e)
        {
            this._findMinDistance = true;
            statusLabel.Text = "Select two nodes for which you want to find the shortest path";
        }

        private Node GetNeighbourNode(Node node, Edge edge)
        {
            if (edge.SourceNode == node)
                return edge.DestNode;
            else
                return edge.SourceNode;
        }

        private void UpdateAdjacentNodesTotalCost(Node node)
        {
            double currentCost = node.TotalCost;
            foreach (AdjacentNode an in _adjacentNodes.AdjacentNodes)
            {
                if (node == GetNeighbourNode(an.Node, an.EdgeCameFrom))
                {
                    if (currentCost + an.EdgeCameFrom.Distance < an.Node.TotalCost || an.Node.TotalCost == -1)
                        an.Node.TotalCost = currentCost + an.EdgeCameFrom.Distance;
                }
            }

            _adjacentNodes.SortAdjacentNodes();
        }

        private void ClearEdgeNodes()
        {
            _edgeNode1 = _edgeNode2 = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            canvasPanel.CreateGraphics().Clear(Color.LightSteelBlue);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Clear()
        {
            this._nodes.Clear();
            this._edges.Clear();
            this._sptSet.Clear();
            this._adjacentNodes.Clear();
            this._findMinDistance = false;
            this._nodesCount = 1;
            gbOptions.Enabled = true;
            statusLabel.Text = "Click on the canvas to create a node.";
        }

        private void btnClearEdges_Click(object sender, EventArgs e)
        {
            Restart();
            _edges.Clear();
            foreach (Node n in _nodes)
                n.Edges.Clear();
            gbOptions.Enabled = true;
            canvasPanel.Invalidate();
            statusLabel.Text = "Click on the canvas to create a node.";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
            canvasPanel.Invalidate();
            statusLabel.Text = "Click on the canvas to create a node.";
        }

        private void Restart()
        {
            this._findMinDistance = false;
            _isGraphConnected = true;

            this._sptSet.Clear();
            this._adjacentNodes.Clear();

            foreach (Node n in _nodes)
            {
                n.Visited = false;
                n.TotalCost = -1;
                n.EdgeCameFrom = null;
            }

            foreach (Edge e in _edges)
                e.Visited = false;

            ClearEdgeNodes();
        }

        #region Generate random
        private bool IsValidInput()
        {
            int numOfNodes;
            if (txtNumNodes.Text.Trim() == "")
            {
                MessageBox.Show("Num of nodes is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (!int.TryParse(txtNumNodes.Text, out numOfNodes))
                {
                    MessageBox.Show("Num of nodes must be an integer value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (numOfNodes <= 0 || numOfNodes > 20)
                {
                    MessageBox.Show("Num of nodes must be larger than 0 and less or equals to 20", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            int numOfEdges;
            if (txtNumEdges.Text.Trim() == "")
            {
                MessageBox.Show("Num of edges is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else { 
                if (!int.TryParse(txtNumEdges.Text, out numOfEdges))
                {
                    MessageBox.Show("Num of edges must be an integer value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    if (cbDirectedGraph.Checked)
                    {
                        if (numOfEdges <= 0 || (numOfEdges > numOfNodes * (numOfNodes - 1)))
                        {
                            MessageBox.Show("Num of edges of a directed graph must be larger than 0 and less or equals to " + numOfNodes * (numOfNodes - 1), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    } else
                    {
                        if (numOfEdges <= 0 || (numOfEdges > numOfNodes * (numOfNodes - 1) / 2))
                        {
                            MessageBox.Show("Num of edges of a undirected graph must be larger than 0 and less or equals to " + numOfNodes * (numOfNodes - 1) / 2, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;
            btnClear_Click(null, null);

            //Generate randoms nodes
            int numOfNodes = int.Parse(txtNumNodes.Text);
            Random rd = new Random();
            while (numOfNodes > 0)
            {
                int xcoord = rd.Next(canvasPanel.Location.X + 50, canvasPanel.Location.X + canvasPanel.Size.Width - 50);
                int ycoord = rd.Next(canvasPanel.Location.Y + 50, canvasPanel.Location.Y + canvasPanel.Size.Height - 50);
                Point p = new Point(xcoord, ycoord);
                if (OverlapsNode(p))
                {
                    continue;
                }
                else
                {
                    Node n = CreateNode(p);
                    _nodes.Add(n);
                    _nodesCount++;
                    ClearEdgeNodes();
                    numOfNodes--;
                }
            }
            
            //Generate random edges
            numOfNodes = int.Parse(txtNumNodes.Text);
            int numOfEdges = int.Parse(txtNumEdges.Text);
            
            for (int i = 0; i < numOfEdges; i++)
            {
                double distance = 0.0;
                _edgeNode1 = _nodes[rd.Next(0, numOfNodes)];
                _edgeNode2 = _nodes[rd.Next(0, numOfNodes)];
                if (_edgeNode1 == _edgeNode2 || OverlapsEdge(_edgeNode1, _edgeNode2))
                {
                    i--;
                    continue;
                }
                if (cbCustomDistance.Checked)
                {
                    int foundReverseEdge = 0;
                    for (int j = 0; j < _edges.Count; j++)
                    {
                        if (_edges[j].SourceNode == _edgeNode2 && _edges[j].DestNode == _edgeNode1)
                        {
                            distance = _edges[j].Distance;
                            foundReverseEdge = 1;
                            break;
                        }
                    }
                    if (foundReverseEdge == 0) distance = rd.Next(1, 50);
                }
                else
                {
                    distance = GetDistance(_edgeNode1.Center, _edgeNode2.Center);
                    distance = Math.Floor(distance / 10);
                }
                Edge edge = CreateEdge(_edgeNode1, _edgeNode2, distance);
                _edges.Add(edge);
                _edgeNode1.Edges.Add(edge);
                _edgeNode2.Edges.Add(edge);
            }
            ClearEdgeNodes();
            canvasPanel.Invalidate();
        }
        #endregion 
    }
}
