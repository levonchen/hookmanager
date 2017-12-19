using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Gma.PP.Common;
using Gma.Frame;
using log4net;
using Timer = System.Timers.Timer;
using Gma.PP.Objects;
using Gma.PP.Helper;

namespace Gma.PP
{
    public partial class Form1 : Form
    {
        private static readonly Timer Timer = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// step1.设置点击位置
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
           // btnPlan1.Text = Plan1.Desc;

            LocationManager.Init();
        }

        /// <summary>
        /// step2.校准服务器时间
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            var point = new PointForm();

            point.Show();
        }




        private void btnPlan1_Click(object sender, EventArgs e)
        {
            HookManager.KeyDown += HookManager_KeyDown;
        }

        //private Thread Thread
        //{
        //    get
        //    {
        //        return new Thread(() =>
        //        {
        //            Log.Info("new thread");
        //            SetText(DateTime.Now.ToString("HH:mm:ss"));
        //        });
        //    }
        //}


        private void Plan1Start(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            var ticks = (DateTime.Now - DateTime.Now.Date).Ticks;

            //else
            //{
            //    Thread.Start();
            //}
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Log.Info("按F2等待提交价格");          

                this.Close();
            }
        }

        private void btNewCaiGouDan_Click(object sender, EventArgs e)
        {
            //点击确定按钮
            //var cfmBtnPoint = WeiZhi.CfmBtn;
            Mouse.SetCursorPos(50, 10);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(50);

            //SendKeys.SendWait(AppShortcutKeyDef.NewTable);
            //Mouse.keybd_event(KeyDef.vbKeyControl, 0, 0, 0);
            //Mouse.keybd_event(KeyDef.vbKeyN, 0, 0, 0);
            //Mouse.keybd_event(KeyDef.vbKeyN, 0, 2, 0);
            //Mouse.keybd_event(KeyDef.vbKeyControl, 0, 2, 0);
            CreateNewTable();
        }

        private void CreateNewTable()
        {
            SendKeys.SendWait(AppShortcutKeyDef.NewTable);
        }

        private void butInputDingDanLeiXing_Click(object sender, EventArgs e)
        {
            var orderType = "21-Cxx-02";

            var Pos = LocationManager.LocationInf.GetItem(LocationItemConsts.DingDanLeiXing);
            Mouse.SetCursorPos(Pos.X, Pos.Y);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(500);
            
            SendKeys.SendWait(orderType);

            //foreach (var charItem in charItems)
            //{

            //    if (charItem == '-')
            //    {
            //        Mouse.keybd_event(KeyDef.vbKeySubtract, 0, 0, 0);
            //    }
            //    else
            //    {
            //        if (Char.IsUpper(charItem))
            //        {
            //            Mouse.keybd_event(KeyDef.vbKeyShift, 0, 0, 0);
            //            Mouse.keybd_event(Ascii.GetAscii(charItem), 0, 0, 0);
            //            Mouse.keybd_event(Ascii.GetAscii(charItem), 0, 2, 0);
            //            Mouse.keybd_event(KeyDef.vbKeyShift, 0, 2, 0);
            //        }
            //        else
            //        {
            //            Mouse.keybd_event(Ascii.GetAscii(charItem), 0, 0, 0);
            //            Mouse.keybd_event(Ascii.GetAscii(charItem), 0, 2, 0);
            //        }
            //    }
            //    Thread.Sleep(500);
            //}
            Thread.Sleep(500);

            FormHelper.SendTab();

            //Mouse.keybd_event(KeyDef.vbKeyReturn, 0, 0, 0);
            Thread.Sleep(1000);

            SendKeys.SendWait("{TAB}");
            //Mouse.SetCursorPos(Pos.X + 200, Pos.Y);
            // Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);

            Thread.Sleep(1000);

            SendKeys.SendWait("{TAB}");

            Thread.Sleep(1000);

            SendKeys.SendWait("{TAB}");


        }

        private void btNewRowWuLiao_Click(object sender, EventArgs e)
        {
            Mouse.SetCursorPos(50, 10);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(50);

            NewCaiGouDanRow();
        }

        private void NewCaiGouDanRow()
        {
            SendKeys.SendWait(AppShortcutKeyDef.NewWuLiaoRow);
        }

        private void butEditWuLiaoInTable_Click(object sender, EventArgs e)
        {
            Mouse.SetCursorPos(50, 10);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(50);

            SendKeys.SendWait(AppShortcutKeyDef.EditWuLiaoInForm);
        }

        private void butEditOneWuLiaoAll_Click(object sender, EventArgs e)
        {
            FormHelper.SetFocusOnMainWindow();

            for(int x = 0;  x < 2; x++)
            {
                AddOneRowItem(x);
            }
          
        }

        private void AddOneRowItem(int  index)
        {
            if (index == 0)
            {
                //FormHelper.NewWuLiaoRow();

                //FormHelper.SendTab();

                FormHelper.MoveToWuLiaoListDefaultRow();
            }
            else
            {
                FormHelper.MoveToNextWuLiaoRow();
            }


            var wuliaoBianMa = "1281000002";
            SendKeys.SendWait(wuliaoBianMa);

            Thread.Sleep(50);
            FormHelper.SendTab();
            Thread.Sleep(50);
            FormHelper.SendBackTab();
            Thread.Sleep(500);


            FormHelper.EditWuLiaoInForm();

            FormHelper.SetFocusOnHangHaoEditBox();
            Thread.Sleep(500);
            FormHelper.SendTab();           
            FormHelper.SendTab();            
            FormHelper.SendTab();


            //SendKeys.SendWait("1");

            Thread.Sleep(500);
            Mouse.keybd_event(Ascii.GetAscii('1'), 0, 0, 0);

            Thread.Sleep(500);
            FormHelper.SendTab();
            Thread.Sleep(500);
            Mouse.keybd_event(Ascii.GetAscii('1'), 0, 0, 0);

            Thread.Sleep(500);
            FormHelper.SendTab();

            Thread.Sleep(500);

            FormHelper.CloseWuLiaoItemForm();
        }

        private void butTest_Click(object sender, EventArgs e)
        {
            FormHelper.SetFocusOnMainWindow();

            FormHelper.SendTab();
            Thread.Sleep(500);
            FormHelper.SendBackTab();
        }

        private void butInputGeneralInfo_Click(object sender, EventArgs e)
        {
            FormHelper.SetFocusOnMainWindow();

            InputGeneralItems();
        }

        private void InputGeneralItems()
        {
            var orderType = "21-Cxx-02";

            var Pos = LocationManager.LocationInf.GetItem(LocationItemConsts.DingDanLeiXing);
            Mouse.SetCursorPos(Pos.X, Pos.Y);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(500);

            SendKeys.SendWait(orderType);

            Thread.Sleep(500);
            FormHelper.SendTab();
            FormHelper.SendTab();
            FormHelper.SendTab();
            FormHelper.SendTab();

            var gongYingShang = "S02900053";
            SendKeys.SendWait(gongYingShang);
            Thread.Sleep(500);
            FormHelper.SendTab();
            FormHelper.SendTab();
            FormHelper.SendTab();
        }

        private void butCreateATotalForm_Click(object sender, EventArgs e)
        {
            FormHelper.SetFocusOnMainWindow();

            CreateATotalCaiGouDan();
        }

        private void CreateATotalCaiGouDan()
        {

            //1: 生成表
            CreateNewTable();
            Thread.Sleep(3000);

            //表头
            InputGeneralItems();

            //采购列表
            Thread.Sleep(500);
            for (int x = 0; x < 2; x++)
            {
                AddOneRowItem(x);
                Thread.Sleep(500);
            }

            Thread.Sleep(1000);

            //关闭保存
            FormHelper.SendCancelCaiGouDan();
        }
    }
}
