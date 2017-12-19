using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.Frame;
using Gma.PP.Common;
using Gma.PP.Objects;

namespace Gma.PP
{
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LocationManager.SaveConfig();

            this.Close();
        }

        #region 订单类型鼠标位置

        private void cbxAddPriceText_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPlaceHolder.Checked)
            {
                HookManager.MouseMove += HookManager_AddPriceTextMouseMove;
                HookManager.MouseClick += HookManager_AddPriceTextMouseDoubleClick;
            }
            else
            {
                HookManager.MouseMove -= HookManager_AddPriceTextMouseMove;
                //Log.Info("关闭鼠标移动事件");
                HookManager.MouseClick -= HookManager_AddPriceTextMouseDoubleClick;
                //Log.Info("关闭鼠标双击事件");
            }
        }

        private void HookManager_AddPriceTextMouseMove(object sender, MouseEventArgs e)
        {
            //Log.Info("鼠标移动,x:" + e.X + ",y:" + e.Y);
            
            txtAddPriceText.Text = string.Format("{0},{1}", e.X, e.Y);
        }

        private void HookManager_AddPriceTextMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cbxPlaceHolder.Checked)
                cbxPlaceHolder.Checked = false;
            var StrLoc = txtAddPriceText.Text;
            var items = StrLoc.Split(',');
            //var LocalObj = LocationManager.LocationInf.GetItem(LocationItemConsts.DingDanLeiXing);
            if (CurrentSelectedLocation != null)
            {
                CurrentSelectedLocation.X = int.Parse(items[0]);
                CurrentSelectedLocation.Y = int.Parse(items[1]);
            }

        }

        #endregion

        private void butReset_Click(object sender, EventArgs e)
        {
            cbxPlaceHolder.Checked = true;
        }


        private void PointForm_Load(object sender, EventArgs e)
        {
            cbxPlaceHolder.Visible = false;
            var items = LocationManager.LocationInf.Items;
            foreach (var it in items)
            {
                this.itemLocationBindingSource.Add(it.Value);
            }
            
        }

        private ItemLocation _currentLocation;

        private ItemLocation CurrentSelectedLocation {
            get { return _currentLocation; }
            set {
                _currentLocation = value;
                lbId.Text = _currentLocation.Id;
                txtAddPriceText.Text = string.Format("{0},{1}", _currentLocation.X, _currentLocation.Y);
            } }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var items = this.dataGridView1.SelectedRows;
            if(items!=null && items.Count > 0)
            {
                var item = items[0];
                var itemLoc = item.DataBoundItem as ItemLocation;
                if(itemLoc != null)
                {
                    CurrentSelectedLocation = itemLoc;
                }
            }
        }
    }
}
