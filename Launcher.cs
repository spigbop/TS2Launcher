using System.Diagnostics;
using System.Reflection;
using TS2Launcher.Dialogues;

namespace TS2Launcher;

public sealed partial class Launcher : Form
{
    public Launcher()
    {
        InitializeComponent();
    }

    private void OnLoad(object? sender, EventArgs e)
    {
        Stream? imagePlay = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.play.png");
        if (imagePlay != null) PlayButton.Image = Image.FromStream(imagePlay);
        
        Stream? imageWindowPlay = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.play-window.png");
        if (imageWindowPlay != null) PlayWindowButton.Image = Image.FromStream(imageWindowPlay);
        
        Stream? imageCover = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.cover.png");
        if (imageCover != null) CoverPanel.BackgroundImage = Image.FromStream(imageCover);
        
        Stream? imageGameSettings = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.game-settings.png");
        if (imageGameSettings != null) GameSettingsButton.Image = Image.FromStream(imageGameSettings);
    }

    public static string Ts2Parameters = "";
    
    private void PlayButtonOnClick(object? sender, EventArgs e)
    {
        Process.Start(@"D:\Program Files (x86)\EA GAMES\The Sims 2 Mansion and Garden Stuff\TSBin\Sims2EP9.exe", $"{Ts2Parameters}");
        Thread.Sleep(5000);
        Application.Exit();
    }

    private void PlayWindowButtonOnClick(object? sender, EventArgs e)
    {
        Process.Start(@"D:\Program Files (x86)\EA GAMES\The Sims 2 Mansion and Garden Stuff\TSBin\Sims2EP9.exe", $"{Ts2Parameters} -w");
        Thread.Sleep(5000);
        Application.Exit();
    }

    private void GameSettingsButtonOnClick(object? sender, EventArgs e)
    {
        GameSettings OpenForm = new GameSettings();
        OpenForm.ShowDialog();
    }
}