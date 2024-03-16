using System.Reflection;

namespace TS2Launcher.Dialogues;

public partial class GameSettings : Form
{
    public GameSettings()
    {
        InitializeComponent();
    }
    
    private void OnLoad(object? sender, EventArgs e)
    {
        Stream? imageGameSettings = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.game-settings.png");
        if (imageGameSettings != null) TitlePanel.BackgroundImage = Image.FromStream(imageGameSettings);
    }
}