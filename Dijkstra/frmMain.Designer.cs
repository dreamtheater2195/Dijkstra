namespace Dijkstra
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar = new C1.Win.C1Ribbon.C1StatusBar();
            this.statusLabel = new C1.Win.C1Ribbon.RibbonLabel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumNodes = new C1.Win.C1Input.C1NumericEdit();
            this.txtNumEdges = new C1.Win.C1Input.C1NumericEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCanvas = new System.Windows.Forms.GroupBox();
            this.cbCustomDistance = new System.Windows.Forms.CheckBox();
            this.cbDirectedGraph = new System.Windows.Forms.CheckBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.btnFindMin = new C1.Win.C1Input.C1Button();
            this.btnClearEdges = new C1.Win.C1Input.C1Button();
            this.btnClear = new C1.Win.C1Input.C1Button();
            this.btnRestart = new C1.Win.C1Input.C1Button();
            this.btnRemoveEdge = new C1.Win.C1Input.C1Button();
            this.btnRemoveNode = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEdges)).BeginInit();
            this.gbCanvas.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.LeftPaneItems.Add(this.statusLabel);
            this.statusBar.Margin = new System.Windows.Forms.Padding(2);
            this.statusBar.Name = "statusBar";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = "Click on the canvas to create a node";
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(2, 16);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(2);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(678, 456);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num of nodes:";
            // 
            // txtNumNodes
            // 
            this.txtNumNodes.AutoSize = false;
            this.txtNumNodes.Location = new System.Drawing.Point(8, 31);
            this.txtNumNodes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumNodes.Name = "txtNumNodes";
            this.txtNumNodes.Size = new System.Drawing.Size(153, 23);
            this.txtNumNodes.TabIndex = 1;
            this.txtNumNodes.Tag = null;
            // 
            // txtNumEdges
            // 
            this.txtNumEdges.AutoSize = false;
            this.txtNumEdges.Location = new System.Drawing.Point(8, 77);
            this.txtNumEdges.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumEdges.Name = "txtNumEdges";
            this.txtNumEdges.Size = new System.Drawing.Size(153, 23);
            this.txtNumEdges.TabIndex = 2;
            this.txtNumEdges.Tag = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Num of edges:";
            // 
            // gbCanvas
            // 
            this.gbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCanvas.Controls.Add(this.canvasPanel);
            this.gbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCanvas.Location = new System.Drawing.Point(166, 8);
            this.gbCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.gbCanvas.Name = "gbCanvas";
            this.gbCanvas.Padding = new System.Windows.Forms.Padding(2);
            this.gbCanvas.Size = new System.Drawing.Size(682, 474);
            this.gbCanvas.TabIndex = 9;
            this.gbCanvas.TabStop = false;
            this.gbCanvas.Text = "Canvas panel";
            // 
            // cbCustomDistance
            // 
            this.cbCustomDistance.AutoSize = true;
            this.cbCustomDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbCustomDistance.Location = new System.Drawing.Point(6, 24);
            this.cbCustomDistance.Name = "cbCustomDistance";
            this.cbCustomDistance.Size = new System.Drawing.Size(131, 17);
            this.cbCustomDistance.TabIndex = 0;
            this.cbCustomDistance.Text = "Allow custom distance";
            this.cbCustomDistance.UseVisualStyleBackColor = true;
            // 
            // cbDirectedGraph
            // 
            this.cbDirectedGraph.AutoSize = true;
            this.cbDirectedGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDirectedGraph.Location = new System.Drawing.Point(6, 47);
            this.cbDirectedGraph.Name = "cbDirectedGraph";
            this.cbDirectedGraph.Size = new System.Drawing.Size(96, 17);
            this.cbDirectedGraph.TabIndex = 1;
            this.cbDirectedGraph.Text = "Directed graph";
            this.cbDirectedGraph.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbDirectedGraph);
            this.gbOptions.Controls.Add(this.cbCustomDistance);
            this.gbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbOptions.Location = new System.Drawing.Point(8, 139);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(153, 79);
            this.gbOptions.TabIndex = 4;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // c1Button1
            // 
            this.c1Button1.BackColor = System.Drawing.Color.AliceBlue;
            this.c1Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Button1.ForeColor = System.Drawing.Color.Black;
            this.c1Button1.Image = global::Dijkstra.Properties.Resources.ico_Upload;
            this.c1Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Button1.Location = new System.Drawing.Point(8, 105);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(153, 28);
            this.c1Button1.TabIndex = 3;
            this.c1Button1.Text = "Generate graph";
            this.c1Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c1Button1.UseVisualStyleBackColor = false;
            this.c1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1Button1.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnFindMin
            // 
            this.btnFindMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMin.Image = global::Dijkstra.Properties.Resources.ico_Forward;
            this.btnFindMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindMin.Location = new System.Drawing.Point(7, 224);
            this.btnFindMin.Name = "btnFindMin";
            this.btnFindMin.Size = new System.Drawing.Size(154, 28);
            this.btnFindMin.TabIndex = 5;
            this.btnFindMin.Text = "Find shortest path";
            this.btnFindMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindMin.UseVisualStyleBackColor = true;
            this.btnFindMin.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnFindMin.Click += new System.EventHandler(this.btnfindMin_Click);
            // 
            // btnClearEdges
            // 
            this.btnClearEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEdges.Image = global::Dijkstra.Properties.Resources.ico_Delete;
            this.btnClearEdges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearEdges.Location = new System.Drawing.Point(8, 417);
            this.btnClearEdges.Name = "btnClearEdges";
            this.btnClearEdges.Size = new System.Drawing.Size(153, 28);
            this.btnClearEdges.TabIndex = 6;
            this.btnClearEdges.Text = "Clear all edges";
            this.btnClearEdges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearEdges.UseVisualStyleBackColor = true;
            this.btnClearEdges.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnClearEdges.Click += new System.EventHandler(this.btnClearEdges_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::Dijkstra.Properties.Resources.ico_Exit;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(87, 451);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Image = global::Dijkstra.Properties.Resources.ico_Update;
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.Location = new System.Drawing.Point(7, 451);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(74, 28);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Reset";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnRemoveEdge
            // 
            this.btnRemoveEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEdge.Image = global::Dijkstra.Properties.Resources.ico_Delete;
            this.btnRemoveEdge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEdge.Location = new System.Drawing.Point(87, 259);
            this.btnRemoveEdge.Name = "btnRemoveEdge";
            this.btnRemoveEdge.Size = new System.Drawing.Size(74, 28);
            this.btnRemoveEdge.TabIndex = 12;
            this.btnRemoveEdge.Text = "Remove edge";
            this.btnRemoveEdge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveEdge.UseVisualStyleBackColor = true;
            this.btnRemoveEdge.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNode.Image = global::Dijkstra.Properties.Resources.ico_Delete;
            this.btnRemoveNode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveNode.Location = new System.Drawing.Point(6, 259);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(75, 28);
            this.btnRemoveNode.TabIndex = 11;
            this.btnRemoveNode.Text = "Remove node";
            this.btnRemoveNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(858, 508);
            this.Controls.Add(this.btnRemoveEdge);
            this.Controls.Add(this.btnRemoveNode);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEdges);
            this.Controls.Add(this.btnFindMin);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbCanvas);
            this.Controls.Add(this.txtNumEdges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumNodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Dijkstra";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEdges)).EndInit();
            this.gbCanvas.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.C1Ribbon.C1StatusBar statusBar;
        private C1.Win.C1Ribbon.RibbonLabel statusLabel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1NumericEdit txtNumNodes;
        private C1.Win.C1Input.C1NumericEdit txtNumEdges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCanvas;
        private System.Windows.Forms.CheckBox cbCustomDistance;
        private System.Windows.Forms.CheckBox cbDirectedGraph;
        private System.Windows.Forms.GroupBox gbOptions;
        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1Input.C1Button btnFindMin;
        private C1.Win.C1Input.C1Button btnClearEdges;
        private C1.Win.C1Input.C1Button btnClear;
        private C1.Win.C1Input.C1Button btnRestart;
        private C1.Win.C1Input.C1Button btnRemoveEdge;
        private C1.Win.C1Input.C1Button btnRemoveNode;
    }
}

