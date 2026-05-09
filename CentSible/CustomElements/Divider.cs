using System;
using System.Drawing;
using System.Windows.Forms;

public class GreenDivider : Control
{
    public GreenDivider()
    {
        this.Height = 2;
        this.Dock = DockStyle.Top;
        this.BackColor = Color.Transparent;

        // Prevent flickering
        this.SetStyle(ControlStyles.UserPaint |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (Pen pen = new Pen(Color.LimeGreen, 2))
        {
            e.Graphics.DrawLine(
                pen,
                0,
                this.Height / 2,
                this.Width,
                this.Height / 2
            );
        }
    }
}