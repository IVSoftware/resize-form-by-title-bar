using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace resize_form_by_title_bar
{
    enum DragAction{ None, Move, Resize, }
    public partial class Form1 : Form, IMessageFilter
    {
        private Point _dragStartScreen;
        private Point _dragStartLocation;
        private Size _dragStartSize;

        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            Disposed += (sender, e) => Application.RemoveMessageFilter(this);
            MinimumSize = new Size(260, 200); // Make sure it can't disappear!
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            #region G L Y P H
            var path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Fonts",
                "glyphs.ttf");
            privateFontCollection.AddFontFile(path);
            var fontFamily = privateFontCollection.Families[0];
            Glyphs = new Font(fontFamily, 11F);
            #endregion G L Y P H
            labelResize.Font = Glyphs;
            labelResize.Text = "\uE800";
            labelResize.ForeColor = Color.MediumSeaGreen;
            labelMove.Font = Glyphs;
            labelMove.Text = "\uE801";
            labelMove.ForeColor = Color.MediumSeaGreen;
        }
        public static Font Glyphs { get; private set; }
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_MOUSEMOVE = 0x0200;
        const int WM_LBUTTONUP = 0x0202;

        DragAction _dragAction = default(DragAction);
        DragAction DragAction
        {
            get => _dragAction;
            set
            {
                if (!Equals(_dragAction, value))
                {
                    _dragAction = value;
                    switch (DragAction)
                    {
                        case DragAction.None:
                            Cursor = Cursors.Default;
                            break;
                        case DragAction.Move:
                            Cursor = Cursors.SizeAll;
                            _dragStartScreen = MousePosition;
                            _dragStartLocation = Location;
                            break;
                        case DragAction.Resize:
                            Cursor = Cursors.SizeNESW;
                            _dragStartScreen = MousePosition;
                            _dragStartSize = Size;
                            break;
                        default:
                            break;
                    }
                    Debug.WriteLine(DragAction);
                }
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_LBUTTONDOWN:
                    var client = titleBarPanel.PointToClient(MousePosition);
                    if (labelMove.Bounds.Contains(client))
                    {
                        DragAction = DragAction.Move;
                    }
                    else if (labelResize.Bounds.Contains(client))
                    {
                        DragAction = DragAction.Resize;
                    }
                    else if (titleBarPanel.ClientRectangle.Contains(client))
                    {
                        DragAction =
                            radioButtonMove.Checked ?
                                DragAction.Move :
                                DragAction.Resize;
                    }
                    else break;
                    Capture = true;
                    m.Result = (IntPtr)1;
                    return true;
                case WM_MOUSEMOVE:
                    int
                        deltaX = MousePosition.X - _dragStartScreen.X,
                        deltaY = MousePosition.Y - _dragStartScreen.Y;
                    switch (DragAction)
                    {
                        case DragAction.None:
                            break;
                        case DragAction.Move:
                            BeginInvoke(new Action(() =>
                            {
                                Location = new Point(_dragStartLocation.X + deltaX, _dragStartLocation.Y + deltaY);
                            }));
                            m.Result = (IntPtr)1;
                            break;
                        case DragAction.Resize:
                            BeginInvoke(new Action(() =>
                            {
                                Size = new Size(_dragStartSize.Width + deltaX, _dragStartSize.Height + deltaY);
                            }));
                            m.Result = (IntPtr)1;
                            return true;
                        default:
                            break;
                    }
                    break;
                case WM_LBUTTONUP:
                    DragAction = DragAction.None;
                    Capture = false;
                    break;
            }
            return false;
        }
    }
}
