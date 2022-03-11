using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class RichLabel : Control
{
    private RichTextBox mRtb;
    public RichLabel()
    {
        mRtb = new RichTextBox();
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque, true);
    }
    protected override void Dispose(bool disposing)
    {
        // Dispose RTB
        if (disposing)
        {
            SendMessage(mRtb.Handle, EM_FORMATRANGE, (IntPtr)1, IntPtr.Zero);
            mRtb.Dispose();
        }
        base.Dispose(disposing);
    }
    public override Color ForeColor
    {
        get { return mRtb.ForeColor; }
        set { mRtb.ForeColor = value; Invalidate(); }
    }
    public override Color BackColor
    {
        get { return mRtb.BackColor; }
        set { mRtb.BackColor = value; Invalidate(); }
    }
    public override Font Font
    {
        get { return mRtb.Font; }
        set
        {
            mRtb.Font = value;
            mRtb.SelectionLength = mRtb.Text.Length;
            mRtb.SelectionFont = value;
            Invalidate();
        }
    }
    public override string Text
    {
        get { return mRtb.Text; }
        set { mRtb.Text = value; Invalidate(); }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
    public string Rtf
    {
        get { return mRtb.Rtf; }
        set { mRtb.Rtf = value; Invalidate(); }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        // Erase background
        using (SolidBrush br = new SolidBrush(this.BackColor))
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        // Setup to paint text
        FORMATRANGE fmtRange;
        float twips = 20 * 72f / e.Graphics.DpiY;
        // Set printable area, converted to twips
        fmtRange.rc.Top = (int)(twips * this.ClientRectangle.Top);
        fmtRange.rc.Bottom = (int)(twips * this.ClientRectangle.Bottom);
        fmtRange.rc.Left = (int)(twips * this.ClientRectangle.Left);
        fmtRange.rc.Right = (int)(twips * this.ClientRectangle.Right);
        fmtRange.rcPage = fmtRange.rc;
        // Set character range to print
        fmtRange.chrg.cpMin = 0;
        fmtRange.chrg.cpMax = mRtb.TextLength;
        // Set device context
        IntPtr hdc = e.Graphics.GetHdc();
        fmtRange.hdc = hdc;
        fmtRange.hdcTarget = hdc;
        // Marshal to unmanaged memory
        IntPtr hdlRange = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange));
        Marshal.StructureToPtr(fmtRange, hdlRange, false);
        // Send RichTextBox the EM_FORMATRANGE message to display the text
        SendMessage(mRtb.Handle, EM_FORMATRANGE, (IntPtr)1, hdlRange);
        // Release resources
        Marshal.FreeCoTaskMem(hdlRange);
        e.Graphics.ReleaseHdc(hdc);
        base.OnPaint(e);
    }
    // P/Invoke declarations
    [StructLayout(LayoutKind.Sequential)]
    internal struct CHARRANGE
    {
        internal int cpMin;
        internal int cpMax;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct RECT
    {
        internal int Left;
        internal int Top;
        internal int Right;
        internal int Bottom;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct FORMATRANGE
    {
        internal IntPtr hdc;
        internal IntPtr hdcTarget;
        internal RECT rc;
        internal RECT rcPage;
        internal CHARRANGE chrg;
    }
    private const int WM_USER = 0x0400;
    private const int EM_FORMATRANGE = WM_USER + 57;
    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
}