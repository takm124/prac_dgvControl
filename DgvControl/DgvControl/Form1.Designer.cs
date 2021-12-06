namespace DgvControl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvParent = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionParent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnParentMerge = new System.Windows.Forms.Button();
            this.btnParentRemove = new System.Windows.Forms.Button();
            this.btnParentAdd = new System.Windows.Forms.Button();
            this.lbParent = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvChild = new System.Windows.Forms.DataGridView();
            this.childNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionChild = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChildSplit = new System.Windows.Forms.Button();
            this.btnChildRemove = new System.Windows.Forms.Button();
            this.btnChildAdd = new System.Windows.Forms.Button();
            this.lbChild = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChild)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 644);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvParent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 642);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvParent
            // 
            this.dgvParent.AllowUserToAddRows = false;
            this.dgvParent.AllowUserToDeleteRows = false;
            this.dgvParent.AllowUserToResizeColumns = false;
            this.dgvParent.AllowUserToResizeRows = false;
            this.dgvParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.selectionParent,
            this.content});
            this.dgvParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParent.Location = new System.Drawing.Point(4, 55);
            this.dgvParent.MultiSelect = false;
            this.dgvParent.Name = "dgvParent";
            this.dgvParent.RowHeadersVisible = false;
            this.dgvParent.RowTemplate.Height = 30;
            this.dgvParent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParent.Size = new System.Drawing.Size(579, 583);
            this.dgvParent.TabIndex = 0;
            this.dgvParent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParent_CellClick);
            this.dgvParent.SelectionChanged += new System.EventHandler(this.dgvParent_SelectionChanged);
            // 
            // no
            // 
            this.no.FillWeight = 2F;
            this.no.HeaderText = "No";
            this.no.MinimumWidth = 2;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no.Width = 40;
            // 
            // selectionParent
            // 
            this.selectionParent.HeaderText = "선택";
            this.selectionParent.MinimumWidth = 10;
            this.selectionParent.Name = "selectionParent";
            this.selectionParent.ReadOnly = true;
            this.selectionParent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selectionParent.Width = 60;
            // 
            // content
            // 
            this.content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.content.HeaderText = "내용";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnParentMerge);
            this.panel1.Controls.Add(this.btnParentRemove);
            this.panel1.Controls.Add(this.btnParentAdd);
            this.panel1.Controls.Add(this.lbParent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnParentMerge
            // 
            this.btnParentMerge.Location = new System.Drawing.Point(496, 5);
            this.btnParentMerge.Name = "btnParentMerge";
            this.btnParentMerge.Size = new System.Drawing.Size(84, 33);
            this.btnParentMerge.TabIndex = 3;
            this.btnParentMerge.Text = "Merge";
            this.btnParentMerge.UseVisualStyleBackColor = true;
            // 
            // btnParentRemove
            // 
            this.btnParentRemove.Location = new System.Drawing.Point(406, 5);
            this.btnParentRemove.Name = "btnParentRemove";
            this.btnParentRemove.Size = new System.Drawing.Size(84, 33);
            this.btnParentRemove.TabIndex = 2;
            this.btnParentRemove.Text = "Remove";
            this.btnParentRemove.UseVisualStyleBackColor = true;
            this.btnParentRemove.Click += new System.EventHandler(this.btnParentRemove_Click);
            // 
            // btnParentAdd
            // 
            this.btnParentAdd.Location = new System.Drawing.Point(316, 5);
            this.btnParentAdd.Name = "btnParentAdd";
            this.btnParentAdd.Size = new System.Drawing.Size(84, 33);
            this.btnParentAdd.TabIndex = 1;
            this.btnParentAdd.Text = "Add";
            this.btnParentAdd.UseVisualStyleBackColor = true;
            this.btnParentAdd.Click += new System.EventHandler(this.btnParentAdd_Click);
            // 
            // lbParent
            // 
            this.lbParent.AutoSize = true;
            this.lbParent.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbParent.Location = new System.Drawing.Point(9, 10);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(69, 22);
            this.lbParent.TabIndex = 0;
            this.lbParent.Text = "Parent";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvChild, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 642);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvChild
            // 
            this.dgvChild.AllowUserToAddRows = false;
            this.dgvChild.AllowUserToDeleteRows = false;
            this.dgvChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.childNo,
            this.selectionChild,
            this.parent,
            this.contentChild});
            this.dgvChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChild.Location = new System.Drawing.Point(4, 55);
            this.dgvChild.Name = "dgvChild";
            this.dgvChild.ReadOnly = true;
            this.dgvChild.RowHeadersVisible = false;
            this.dgvChild.RowTemplate.Height = 30;
            this.dgvChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChild.Size = new System.Drawing.Size(575, 583);
            this.dgvChild.TabIndex = 0;
            this.dgvChild.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChild_CellClick);
            // 
            // childNo
            // 
            this.childNo.FillWeight = 2F;
            this.childNo.HeaderText = "No";
            this.childNo.MinimumWidth = 2;
            this.childNo.Name = "childNo";
            this.childNo.ReadOnly = true;
            this.childNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.childNo.Width = 40;
            // 
            // selectionChild
            // 
            this.selectionChild.HeaderText = "선택";
            this.selectionChild.MinimumWidth = 10;
            this.selectionChild.Name = "selectionChild";
            this.selectionChild.ReadOnly = true;
            this.selectionChild.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selectionChild.Width = 60;
            // 
            // parent
            // 
            this.parent.HeaderText = "소속";
            this.parent.MinimumWidth = 10;
            this.parent.Name = "parent";
            this.parent.ReadOnly = true;
            this.parent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.parent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contentChild
            // 
            this.contentChild.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentChild.HeaderText = "내용";
            this.contentChild.Name = "contentChild";
            this.contentChild.ReadOnly = true;
            this.contentChild.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChildSplit);
            this.panel2.Controls.Add(this.btnChildRemove);
            this.panel2.Controls.Add(this.btnChildAdd);
            this.panel2.Controls.Add(this.lbChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnChildSplit
            // 
            this.btnChildSplit.Location = new System.Drawing.Point(477, 6);
            this.btnChildSplit.Name = "btnChildSplit";
            this.btnChildSplit.Size = new System.Drawing.Size(84, 33);
            this.btnChildSplit.TabIndex = 4;
            this.btnChildSplit.Text = "Split";
            this.btnChildSplit.UseVisualStyleBackColor = true;
            // 
            // btnChildRemove
            // 
            this.btnChildRemove.Location = new System.Drawing.Point(387, 6);
            this.btnChildRemove.Name = "btnChildRemove";
            this.btnChildRemove.Size = new System.Drawing.Size(84, 33);
            this.btnChildRemove.TabIndex = 3;
            this.btnChildRemove.Text = "Remove";
            this.btnChildRemove.UseVisualStyleBackColor = true;
            this.btnChildRemove.Click += new System.EventHandler(this.btnChildRemove_Click);
            // 
            // btnChildAdd
            // 
            this.btnChildAdd.Location = new System.Drawing.Point(297, 6);
            this.btnChildAdd.Name = "btnChildAdd";
            this.btnChildAdd.Size = new System.Drawing.Size(84, 33);
            this.btnChildAdd.TabIndex = 2;
            this.btnChildAdd.Text = "Add";
            this.btnChildAdd.UseVisualStyleBackColor = true;
            this.btnChildAdd.Click += new System.EventHandler(this.btnChildAdd_Click);
            // 
            // lbChild
            // 
            this.lbChild.AutoSize = true;
            this.lbChild.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbChild.Location = new System.Drawing.Point(7, 10);
            this.lbChild.Name = "lbChild";
            this.lbChild.Size = new System.Drawing.Size(54, 22);
            this.lbChild.TabIndex = 1;
            this.lbChild.Text = "Child";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChild)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvParent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbParent;
        private System.Windows.Forms.DataGridView dgvChild;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbChild;
        private System.Windows.Forms.Button btnParentMerge;
        private System.Windows.Forms.Button btnParentRemove;
        private System.Windows.Forms.Button btnParentAdd;
        private System.Windows.Forms.Button btnChildSplit;
        private System.Windows.Forms.Button btnChildRemove;
        private System.Windows.Forms.Button btnChildAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectionParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn childNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectionChild;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentChild;
    }
}

