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

    private List<string> allTs2Dirs = new();
    private void OnLoad(object? sender, EventArgs e)
    {
        if (OperatingSystem.IsWindows())
        {
            var drives = DriveInfo.GetDrives();
            for (int d = 0; d < drives.Length; d++)
            {
                string eaPath = @$"{drives[d].Name}Program Files (x86)\EA GAMES";
                bool isTs2 = false;
                if (Directory.Exists(eaPath))
                {
                    var subFolders = Directory.GetDirectories(eaPath);
                    int mostpack = 0;
                    for (int f = 0; f < subFolders.Length; f++)
                    {
                        if (subFolders[f].Contains("The Sims 2"))
                        {
                            isTs2 = true;
                            Packs.Add(subFolders[f]);
                            for (int i = 1; i < 10; i++)
                            {
                                string exec = Path.Combine(subFolders[f], @$"TSBin\Sims2EP{i}.exe");
                                if (File.Exists(exec) && mostpack < i)
                                {
                                    mostpack = i;
                                    GamePath = exec;
                                }
                            }
                            if (GamePath == null) GamePath = Path.Combine(subFolders[f], @"TSBin\Sims2.exe");
                        }
                    }
                }
                if(isTs2) allTs2Dirs.Add(GamePath);
            }
        }

        if (GamePath == null)
        {
            ChooseDirectories form = new();
            form.Show();
        }

        if (allTs2Dirs.Count > 1)
        {
            ChooseDirectories form = new();
            form.Text = "Multiple Sims 2 Directories Found! Choose Directories...";
            form.ShowDialog();
        }
        
        Stream? imageCover = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.cover.png");
        if (imageCover != null) CoverPanel.BackgroundImage = Image.FromStream(imageCover);
    }

    public static string? GamePath = null;
    public static List<string> Packs = new();
    
    public static string Ts2Parameters = "";
    
    private void PlayButtonOnClick(object? sender, EventArgs e)
    {
        Process.Start(GamePath, Ts2Parameters);
        Thread.Sleep(5000);
        Application.Exit();
    }

    private void PlayWindowButtonOnClick(object? sender, EventArgs e)
    {
        Process.Start(GamePath, $"{Ts2Parameters} -w");
        Thread.Sleep(5000);
        Application.Exit();
    }

    private void GameSettingsButtonOnClick(object? sender, EventArgs e)
    {
        GameSettings OpenForm = new GameSettings();
        OpenForm.ShowDialog();
    }

    private void LauncherSettingsButtonOnClick(object? sender, EventArgs e)
    {
        ChooseDirectories OpenForm = new ChooseDirectories();
        OpenForm.ShowDialog();
    }
}