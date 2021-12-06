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

        // 현재 체크된 Parent의 개수
        int _prChecked = 0;

        // 현재 체크된 Child의 개수
        int _chChecked = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 부모 객체 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            //체크된 Parent 개수 초기화
            _prChecked = 0;

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

            if (_pg.parent.Count < 1) return;

            // Row 추가
            foreach (Child item in _pg.parent[_prIdx].childList)
            {
                // Row 생성
                dgvChild.Rows.Add();

                // 값 지정
                dgvChild.Rows[dgvChild.RowCount - 1].Tag = item as Child;
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

        #region 체크박스 관련
        /// <summary>
        /// Parent 체크박스 관련 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                if (dgvParent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "TRUE")
                {
                    dgvParent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    Parent pr = dgvParent.Rows[e.RowIndex].Tag as Parent;
                    pr.isChecked = false;
                    _prChecked--;
                }
                else
                {
                    dgvParent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    Parent pr = dgvParent.Rows[e.RowIndex].Tag as Parent;
                    pr.isChecked = true;
                    _prChecked++;
                }
            }
        }

        /// <summary>
        /// Child 체크박스 관련 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                if (dgvChild.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "TRUE")
                {
                    dgvChild.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    Child ch = dgvChild.Rows[e.RowIndex].Tag as Child;
                    ch.isChecked = false;
                    _chChecked--;
                }
                else
                {
                    dgvChild.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    Child ch = dgvChild.Rows[e.RowIndex].Tag as Child;
                    ch.isChecked = true;
                    _chChecked++;
                }
            }
        }
        #endregion


        /// <summary>
        /// 자식 객체 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChildAdd_Click(object sender, EventArgs e)
        {
            if (dgvParent.RowCount < 1) return;

            // 새로운 Child 객체 생성
            Child ch = new Child();
            ch.content = DateTime.Now.ToString("yyyyMMddHHmmss") + "에 추가로 생성된 Child";

            // Parent 객체 호출
            Parent pr = _pg.parent[_prIdx];

            // Child Add 후 화면 재호출
            pr.childList.Add(ch);
            fDisplyChild();
        }

        /// <summary>
        /// 부모 객체 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParentRemove_Click(object sender, EventArgs e)
        {
            // 체크되어 있는 Parent가 있는지 확인
            if (_prChecked < 1) return;

            try
            {
                for (int i = _pg.parent.Count - 1; i >= 0; i--)
                {
                    if (_pg.parent[i].isChecked)
                    {
                        _pg.parent.RemoveAt(i);
                    }
                }

                // 선택된 인덱스 초기화
                _prIdx = 0;

                // 화면 재출력
                fDisplayParent();
                fDisplyChild();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 자식 객체 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChildRemove_Click(object sender, EventArgs e)
        {
            // 체크되어 있는 Child가 있는지 확인
            if (_chChecked < 1) return;

            try
            {
                for (int i = _pg.parent[_prIdx].childList.Count - 1; i >= 0; i--)
                {
                    if (_pg.parent[_prIdx].childList[i].isChecked)
                    {
                        _pg.parent[_prIdx].childList.RemoveAt(i);
                    }
                }

                // 화면 재출력
                fDisplayParent();
                fDisplyChild();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}