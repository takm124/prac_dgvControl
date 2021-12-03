using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DgvControl
{
    public partial class Form1 : Form
    {
        // ParentGroup
        ParentGroup _pg = new ParentGroup();

        // 현재 선택된 Parent의 Index
        int _prIdx;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnParentAdd_Click(object sender, EventArgs e)
        {
            // Parent 객체 생성
            Parent pr = new Parent();
            pr.content = DateTime.Now.ToString("yyyyMMddHHmmss") + "에 생성된 Parent";

            // Child 객체 생성
            Child ch = new Child();
            ch.content = DateTime.Now.ToString("yyyyMMddHHmmss") + "에 생성된 Child";

            // Parent에 Child 추가
            pr.childList.Add(ch);

            // ParentGroup에 Parent 추가
            _pg.parent.Add(pr);

            // parent 객체 dgvParent에 출력
            fDisplayParent();

            // child 객체 dgcChild에 출력
            fDisplyChild();
        }

        /// <summary>
        /// dgvParent에 Parent 객체 출력
        /// </summary>
        private void fDisplayParent()
        {
            // No
            int count = 1;

            // dgvParent 초기화
            dgvParent.Rows.Clear();

            // Row 하나씩 추가
            foreach (Parent item in _pg.parent)
            {
                // Row 생성
                dgvParent.Rows.Add();

                // 값 지정
                dgvParent.Rows[dgvParent.RowCount - 1].Tag = item as Parent;
                dgvParent.Rows[dgvParent.RowCount - 1].Cells[0].Value = (count++).ToString();
                dgvParent.Rows[dgvParent.RowCount - 1].Cells[1].Value = false;
                dgvParent.Rows[dgvParent.RowCount - 1].Cells[2].Value = item.content;
            }
        }

        /// <summary>
        /// Child 객체 dgcChild에 출력
        /// </summary>
        private void fDisplyChild()
        {
            // No
            int count = 1;

            //dgvChild 초기화
            dgvChild.Rows.Clear();

            // Row 추가
            foreach (Child item in _pg.parent[_prIdx].childList)
            {
                // Row 생성
                dgvChild.Rows.Add();

                // 값 지정
                dgvChild.Rows[dgvChild.RowCount - 1].Cells[0].Value = (count++).ToString();
                dgvChild.Rows[dgvChild.RowCount - 1].Cells[1].Value = false;
                dgvChild.Rows[dgvChild.RowCount - 1].Cells[2].Value = (_prIdx + 1).ToString();
                dgvChild.Rows[dgvChild.RowCount - 1].Cells[3].Value = item.content;
            }
        }

        /// <summary>
        /// Parent 데이터 클릭 시 Child 데이터 출력, 현재 선택된 Parent 데이터의 인덱스 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvParent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParent.SelectedRows.Count > 0 && dgvParent.SelectedRows[0].Tag != null)
            {
                _prIdx = dgvParent.SelectedRows[0].Index;
                fDisplyChild();
            }
        }

        
        private void btnChildAdd_Click(object sender, EventArgs e)
        {
            // 새로운 Child 객체 생성
            Child ch = new Child();
            ch.content = DateTime.Now.ToString("yyyyMMddHHmmss") + "에 추가로 생성된 Child";

            // Parent 객체 호출
            Parent pr = _pg.parent[_prIdx];

            // Child Add 후 화면 재호출
            pr.childList.Add(ch);
            fDisplyChild();
        }
    }
}