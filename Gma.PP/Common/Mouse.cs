using System;
using System.Runtime.InteropServices;

namespace Gma.PP.Common
{
    public class Mouse
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point pt);

        /// <summary>
        /// 设置焦点
        /// </summary>
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        /// <summary>
        /// 鼠标事件
        /// </summary>
        [DllImport("user32.dll")]
        public static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);
        
        /// <summary>
        /// 键盘事件
        /// </summary>
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlag : uint
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,
            VirtualDesk = 0x4000,
            Absolute = 0x8000
        }
    }

    public struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}
