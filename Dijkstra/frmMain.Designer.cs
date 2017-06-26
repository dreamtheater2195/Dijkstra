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
            this.btnFindMin = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.statusBar = new C1.Win.C1Ribbon.C1StatusBar();
            this.statusLabel = new C1.Win.C1Ribbon.RibbonLabel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumNodes = new C1.Win.C1Input.C1NumericEdit();
            this.txtNumEdges = new C1.Win.C1Input.C1NumericEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbCanvas = new System.Windows.Forms.GroupBox();
            this.cbCustomDistance = new System.Windows.Forms.CheckBox();
            this.cbDirectedGraph = new System.Windows.Forms.CheckBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnClearEdges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEdges)).BeginInit();
            this.gbCanvas.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindMin
            // 
            this.btnFindMin.Image = global::Dijkstra.Properties.Resources.ico_Forward;
            this.btnFindMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindMin.Location = new System.Drawing.Point(8, 223);
            this.btnFindMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindMin.Name = "btnFindMin";
            this.btnFindMin.Size = new System.Drawing.Size(137, 30);
            this.btnFindMin.TabIndex = 0;
            this.btnFindMin.Text = "Find shortest path";
            this.btnFindMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindMin.UseVisualStyleBackColor = true;
            this.btnFindMin.Click += new System.EventHandler(this.btnfindMin_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestart.Image = global::Dijkstra.Properties.Resources.ico_Update;
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.Location = new System.Drawing.Point(8, 450);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(66, 30);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Image = global::Dijkstra.Properties.Resources.ico_Delete;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(78, 450);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.canvasPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(2, 15);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(2);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(693, 457);
            this.canvasPanel.TabIndex = 8;
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
            this.label1.TabIndex = 10;
            this.label1.Text = "Num of nodes:";
            // 
            // txtNumNodes
            // 
            this.txtNumNodes.AutoSize = false;
            this.txtNumNodes.Location = new System.Drawing.Point(8, 31);
            this.txtNumNodes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumNodes.Name = "txtNumNodes";
            this.txtNumNodes.Size = new System.Drawing.Size(137, 23);
            this.txtNumNodes.TabIndex = 11;
            this.txtNumNodes.Tag = null;
            // 
            // txtNumEdges
            // 
            this.txtNumEdges.AutoSize = false;
            this.txtNumEdges.Location = new System.Drawing.Point(8, 77);
            this.txtNumEdges.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumEdges.Name = "txtNumEdges";
            this.txtNumEdges.Size = new System.Drawing.Size(137, 23);
            this.txtNumEdges.TabIndex = 13;
            this.txtNumEdges.Tag = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Num of edges:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Image = global::Dijkstra.Properties.Resources.ico_Upload;
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(8, 104);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(137, 30);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate ";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gbCanvas
            // 
            this.gbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCanvas.Controls.Add(this.canvasPanel);
            this.gbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCanvas.Location = new System.Drawing.Point(151, 8);
            this.gbCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.gbCanvas.Name = "gbCanvas";
            this.gbCanvas.Padding = new System.Windows.Forms.Padding(2);
            this.gbCanvas.Size = new System.Drawing.Size(697, 474);
            this.gbCanvas.TabIndex = 15;
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
            this.cbCustomDistance.TabIndex = 17;
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
            this.cbDirectedGraph.TabIndex = 18;
            this.cbDirectedGraph.Text = "Directed graph";
            this.cbDirectedGraph.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbDirectedGraph);
            this.gbOptions.Controls.Add(this.cbCustomDistance);
            this.gbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbOptions.Location = new System.Drawing.Point(8, 139);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(138, 79);
            this.gbOptions.TabIndex = 20;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnClearEdges
            // 
            this.btnClearEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearEdges.Image = global::Dijkstra.Properties.Resources.ico_Delete;
            this.btnClearEdges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearEdges.Location = new System.Drawing.Point(8, 416);
            this.btnClearEdges.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearEdges.Name = "btnClearEdges";
            this.btnClearEdges.Size = new System.Drawing.Size(137, 30);
            this.btnClearEdges.TabIndex = 22;
            this.btnClearEdges.Text = "Clear all edges";
            this.btnClearEdges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearEdges.UseVisualStyleBackColor = true;
            this.btnClearEdges.Click += new System.EventHandler(this.btnClearEdges_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(858, 508);
            this.Controls.Add(this.btnClearEdges);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbCanvas);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNumEdges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumNodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnFindMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Dijkstra";
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

        private System.Windows.Forms.Button btnFindMin;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnClear;
        private C1.Win.C1Ribbon.C1StatusBar statusBar;
        private C1.Win.C1Ribbon.RibbonLabel statusLabel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1NumericEdit txtNumNodes;
        private C1.Win.C1Input.C1NumericEdit txtNumEdges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox gbCanvas;
        private System.Windows.Forms.CheckBox cbCustomDistance;
        private System.Windows.Forms.CheckBox cbDirectedGraph;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnClearEdges;
    }
}

