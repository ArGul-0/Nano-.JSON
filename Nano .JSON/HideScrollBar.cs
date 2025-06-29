using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class ScrollBarHider
{
    private const int SB_VERT = 1;
    private const int WM_VSCROLL = 0x0115;
    private const int SB_LINEUP = 0;
    private const int SB_LINEDOWN = 1;

    [DllImport("user32.dll")]
    private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

    public static void HideVertical(TextBox tb)
    {
        ShowScrollBar(tb.Handle, SB_VERT, false);
        tb.Invalidate();

        // Подписываемся на MouseWheel сразу после Hide
        tb.MouseWheel += (s, e) =>
        {
            // e.Delta кратно 120 — это ровно одна «щелчковая» прокрутка
            int ticks = e.Delta / 120;
            int code = e.Delta > 0 ? SB_LINEUP : SB_LINEDOWN;
            for (int i = 0; i < Math.Abs(ticks); i++)
                SendMessage(tb.Handle, WM_VSCROLL, (IntPtr)code, IntPtr.Zero);
        };
    }
}
