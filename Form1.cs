using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;

namespace Zoom_XY
{
    public partial class Form1 : Form
    {
        private InputSimulator _input = new InputSimulator(); //Activate KeyBoardControl
        private MouseSimulator _mouse = new MouseSimulator(); //Activate MouseControl
        private bool _working = false;

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _CheckZoomRunner.Start();
            HotKeyManager.RegisterHotKey(Keys.F12, KeyModifiers.Control);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(_StartBtn_Click);
        }

        private void _StartBtn_Click(object sender, EventArgs e)
        {
            if (_working)
                StopProgram();
            else
                StartProgram();
        }

        private void StartProgram()
        {
            _GetZoomXY.Start();
            _working = true;
            _StartBtn.Text = "Started";

            _GetZoomJoinXY.Start();

            _GetZoomAudioXY.Start();

            _GetZoomContentViewXY.Start();

            _GetZoomLeaveXY.Start();
        }

        private void StopProgram()
        {
            _GetZoomXY.Stop();
            _working = false;
            _StartBtn.Text = "Stopped";

            _GetZoomJoinXY.Stop();
            _GetZoomAudioXY.Stop();
            _GetZoomContentViewXY.Stop();
            _GetZoomLeaveXY.Stop();
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

        private int AbsX(int x)
        {
            return x * (65536 / GetSystemMetrics(0));
        }

        private int AbsY(int y)
        {
            return y * (65536 / GetSystemMetrics(0));
        }

        private void _GetZoomXY_Tick(object sender, EventArgs e)
        {
            //Get Zoom XY
            //Zoom Cloud Meetings
            var handle = FindWindow("ZPFTEWndClass", "Zoom Cloud Meetings");
            if (handle != IntPtr.Zero)
            {
                var rct = new RECT();
                GetWindowRect(handle, ref rct);

                var pos = Cursor.Position;
                pos.X -= rct.Left;
                pos.Y -= rct.Top;
                _zoomxylabel.Text = "Zoom XY : " + pos.ToString();
            }
        }

        private void GetZoomJoinXY_Tick(object sender, EventArgs e)
        {
            //Get Zoom Join XY
            //Zoom 加入會議 輸入會議密碼
            var handle = FindWindow("zWaitHostWndClass", null);
            if (handle != IntPtr.Zero)
            {
                var rct = new RECT();
                GetWindowRect(handle, ref rct);

                var pos = Cursor.Position;
                pos.X -= rct.Left;
                pos.Y -= rct.Top;
                _zoomjoinlabel.Text = "Zoom Join XY : " + pos.ToString();
            }
        }

        private void _GetZoomAudioXY_Tick(object sender, EventArgs e)
        {
            //zJoinAudioWndClass
            //加入音訊
            var handle = FindWindow("zJoinAudioWndClass", null);
            if (handle != IntPtr.Zero)
            {
                var rct = new RECT();
                GetWindowRect(handle, ref rct);

                var pos = Cursor.Position;
                pos.X -= rct.Left;
                pos.Y -= rct.Top;
                _zoomaudiolabel.Text = "Zoom Audio XY : " + pos.ToString();
            }
        }
        private void _GetZoomContentViewXY_Tick(object sender, EventArgs e)
        {
            var handle = FindWindow("ZPContentViewWndClass", null);
            if (handle != IntPtr.Zero)
            {
                var rct = new RECT();
                GetWindowRect(handle, ref rct);

                var pos = Cursor.Position;
                pos.X -= rct.Left;
                pos.Y -= rct.Top;
                _zoomcontentviewXY.Text = "Zoom ZPContentView XY : " + pos.ToString();
            }
        }
        private void GetZoomLeaveXY_Tick(object sender, EventArgs e)
        {
            var handle = FindWindow("SysShadow", null);
            if (handle != IntPtr.Zero)
            {
                //結束會議或離開會議？
                //zLeaveWndClass
                var rct = new RECT();
                GetWindowRect(handle, ref rct);

                var pos = Cursor.Position;
                pos.X -= rct.Left;
                pos.Y -= rct.Top;
                _zoomcontentviewXY.Text = "Zoom Leave XY : " + pos.ToString();
            }
        }
        private void _CheckZoomRunner_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("zoom");
            if (pname.Length == 0)
            {
                _StartBtn.Text = "Waiting Zoom Open...";
                _StartBtn.Enabled = false;
                _GetZoomXY.Stop();
                _GetZoomJoinXY.Stop();
                _zoomxylabel.Text = "Zoom XY : ";
                _zoomjoinlabel.Text = "Zoom Join XY : ";
            }
            else if (pname.Length == 1)
            {
                _StartBtn.Text = "Start";
                _StartBtn.Enabled = true;
            }
        }
    }
}