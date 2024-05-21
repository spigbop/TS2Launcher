using System.Reflection;
using System.Windows;

namespace TS2Launcher.Dialogues;

public partial class GameSettings : Form
{
    public GameSettings()
    {
        InitializeComponent();
    }
    
    private void OnLoad(object? sender, EventArgs e)
    {
        if (Launcher.Ts2Parameters.Contains("-nosound")) DisableSoundCheckBox.Checked = true;
        if (Launcher.Ts2Parameters.Contains("-r")) CustomResoulitonCheckBox.Checked = true; CustomResolutionCheckBoxOnClick(CustomResoulitonCheckBox, e);
    }

    private void CustomResolutionCheckBoxOnClick(object? sender, EventArgs e)
    {
        CheckBox? cb = sender as CheckBox;
        if (cb != null)
        {
            ResolutionHeightBox.Enabled = cb.Checked;
            ResolutionWidthBox.Enabled = cb.Checked;
            AutoResoulitonButton.Enabled = cb.Checked;
        }
    }

    private void AutoResolutionButtonOnClick(object? sender, EventArgs e)
    {
        var localScreen = Screen.FromControl(this);
        ResolutionWidthBox.Value = localScreen.Bounds.Width;
        ResolutionHeightBox.Value = localScreen.Bounds.Height;
    }

    private void ApplyButtonOnClick(object? sender, EventArgs e)
    {
        Launcher.Ts2Parameters = "";
        if (DisableSoundCheckBox.Checked) Launcher.Ts2Parameters = "-nosound";
        if (CustomResoulitonCheckBox.Checked) Launcher.Ts2Parameters = $"{Launcher.Ts2Parameters} -r{ResolutionWidthBox.Value}x{ResolutionHeightBox.Value}";
        this.Close();
    }
}