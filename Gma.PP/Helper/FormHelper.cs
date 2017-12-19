using Gma.PP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.PP.Common;
using System.Threading;
using System.Windows.Forms;
using Gma.PP.Objects;

namespace Gma.PP.Helper
{
    public static class  FormHelper
    {
        public static void SetFocusOnMainWindow()
        {
            Mouse.SetCursorPos(50, 10);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(500);
        }

        public static void SendTab()
        {
            SendKeys.SendWait(AppShortcutKeyDef.TabKey);
            Thread.Sleep(500);
        }

        public static void SendBackTab()
        {
            //SendKeys.SendWait(AppShortcutKeyDef.TabBackKey);

            Mouse.keybd_event(KeyDef.vbKeyShift, 0, 0, 0);
            Mouse.keybd_event(KeyDef.vbKeyTab, 0, 0, 0);
            Mouse.keybd_event(KeyDef.vbKeyTab, 0, 2, 0);
            Mouse.keybd_event(KeyDef.vbKeyShift, 0, 2, 0);
            Thread.Sleep(50);
        }

        public static void NewWuLiaoRow()
        {
            SendKeys.SendWait(AppShortcutKeyDef.NewWuLiaoRow);
        }

        public static void MoveToWuLiaoListDefaultRow()
        {
            var Pos = LocationManager.LocationInf.GetItem(LocationItemConsts.WuLiaoListDefaultRow);
            Mouse.SetCursorPos(Pos.X, Pos.Y);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(500);
        }

        public static void EditWuLiaoInForm()
        {
            SendKeys.SendWait(AppShortcutKeyDef.EditWuLiaoInForm);
            Thread.Sleep(1000);
        }

        public static void SetFocusOnHangHaoEditBox()
        {
            var Pos = LocationManager.LocationInf.GetItem(LocationItemConsts.WuLiaoFormHangHao);
            Mouse.SetCursorPos(Pos.X, Pos.Y);
            Thread.Sleep(500);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(1000);
        }

        public static void CloseWuLiaoItemForm()
        {
            var Pos = LocationManager.LocationInf.GetItem(LocationItemConsts.CloseWuLiaoForm);
            Mouse.SetCursorPos(Pos.X, Pos.Y);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(500);
        }

        public static void MoveToNextWuLiaoRow()
        { 
            SendKeys.SendWait(AppShortcutKeyDef.DownKey);
            Thread.Sleep(1000);
        }

        public static void SendCancelCaiGouDan()
        {
            var Pos = LocationManager.LocationInf.GetItem(LocationItemConsts.CancelCaiGouDan);
            Mouse.SetCursorPos(Pos.X, Pos.Y);
            Mouse.mouse_event(Mouse.MouseEventFlag.LeftDown | Mouse.MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            Thread.Sleep(500);
        }

    }
}
