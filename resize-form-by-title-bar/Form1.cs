using System;
using System.Drawing;
using System.Windows.Forms;

namespace resize_form_by_title_bar
{
    public partial class Form1 : Form, IMessageFilter
    {
        private Point _dragStartScreen;
        private Size _dragStartSize;
        private bool _dragResizing = false;

        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            Disposed += (sender, e) => Application.RemoveMessageFilter(this);
            MinimumSize = new Size(50, 50);
        }
        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_MOUSEMOVE = 0x0200;
        const int WM_LBUTTONUP = 0x0202;

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_LBUTTONDOWN:
                    var client = PointToClient(MousePosition);
                    if (titleBarPanel.ClientRectangle.Contains(client))
                    {
                        _dragResizing = true;
                        _dragStartScreen = MousePosition;
                        _dragStartSize = Size;
                        Capture = true;
                        m.Result = (IntPtr)1;
                        return true;
                    }
                    break;
                case WM_MOUSEMOVE:
                    if (_dragResizing)
                    {
                        int
                            deltaX = MousePosition.X - _dragStartScreen.X,
                            deltaY = MousePosition.Y - _dragStartScreen.Y;
                        BeginInvoke(new Action(() =>
                        {
                            Size = new Size(_dragStartSize.Width + deltaX, _dragStartSize.Height + deltaY);
                        }));
                        m.Result = (IntPtr)1;
                        return true;
                    }
                    break;
                case WM_LBUTTONUP:
                    _dragResizing = false;
                    Capture = false;
                    break;
            }
            return false;
        }
    }
}
