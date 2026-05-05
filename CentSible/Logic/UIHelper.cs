using System;
using System.Drawing;
using System.Windows.Forms;

public static class UIHelper
{
    public static void WireClickRecursive(Control root, EventHandler handler)
    {
        if (root is Button) return;
        root.Click -= handler;
        root.Click += handler;
        foreach (Control child in root.Controls)
            WireClickRecursive(child, handler);
    }

    public static void WireHoverRecursive(Control root, Control[] group)
    {
        root.Tag = group;
        root.MouseEnter -= HoverEnter;
        root.MouseLeave -= HoverLeave;
        root.MouseEnter += HoverEnter;
        root.MouseLeave += HoverLeave;
        foreach (Control child in root.Controls)
            WireHoverRecursive(child, group);
    }

    private static void HoverEnter(object sender, EventArgs e)
    {
        var group = (Control[])((Control)sender).Tag;
        foreach (var ctrl in group)
            RecolorRecursive(ctrl, Color.FromArgb(82, 160, 90));
    }

    private static void HoverLeave(object sender, EventArgs e)
    {
        var group = (Control[])((Control)sender).Tag;
        foreach (var ctrl in group)
            RecolorRecursive(ctrl, Color.FromArgb(26, 46, 27));
    }

    private static void RecolorRecursive(Control ctrl, Color color)
    {
        ctrl.BackColor = color;
        foreach (Control child in ctrl.Controls)
            RecolorRecursive(child, color);
    }
}