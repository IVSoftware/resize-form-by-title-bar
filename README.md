As I understand it, you wish to drag the mouse on the `titleBarPanel` and have that resize the form. To achieve this, consider implementing [IMessageFilter](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.imessagefilter) to hook the mouse events regardless of which control (e.g. `titleBarPanel`) is focused for the click. Now all you have to do is:
- Determine whether mouse position is in the `titleBarPanel` rectangle
- If so, capture the mouse down `Size` and `Location`
- As the mouse moves, recalc the main form `Size` based on how much the mouse has moved.

*Don't forget to [Capture](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.capture) the mouse!*
***

    public partial class Form1 : Form, IMessageFilter
    {
        private Point _dragStartScreen;
        private Size _dragStartSize;
        private bool _dragResizing = false;

        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            Disposed += (sender, e) =>Application.RemoveMessageFilter(this);
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

