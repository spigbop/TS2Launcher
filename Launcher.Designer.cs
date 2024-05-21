using System.Reflection;
using System.Runtime.CompilerServices;

namespace TS2Launcher;

sealed partial class Launcher
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(640, 320);
        Stream icon = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.Sims2DoubleDeluxe.ico");
        if (icon != null) this.Icon = new Icon(icon);
        this.Text = "The Sims 2 Launcher (Unofficial)";
        this.Size = new Size(640, 320);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.BackColor = Color.FromArgb(255, 119, 128, 193);
        this.ForeColor = Color.FromArgb(255, 0, 14, 69);
        this.Font = Program.ProgramFont;
        
        
        this.Load += OnLoad;
        
        this.Controls.Add(ScreenshotsPanel);
        this.Controls.Add(CoverPanel);
        this.Controls.Add(PlayButton);
        PlayButton.Click += PlayButtonOnClick;
        this.Controls.Add(PlayWindowButton);
        PlayWindowButton.Click += PlayWindowButtonOnClick;
        
        this.Controls.Add(GameSettingsButton);
        GameSettingsButton.Click += GameSettingsButtonOnClick;
        
        this.Controls.Add(LauncherSettingsButton);
        LauncherSettingsButton.Click += LauncherSettingsButtonOnClick;
    }

    private Button PlayButton = new Button()
    {
        Name = "PlayButton",
        Anchor = AnchorStyles.Right,
        Location = new Point(480,5),
        Size = new Size(140,50),
        FlatStyle = FlatStyle.Flat,
        FlatAppearance = { BorderSize = 0 },
        BackColor = Color.FromArgb(255, 115, 156, 176),
        Font = new Font(Program.ProgramFont.FontFamily, 22.2f, FontStyle.Bold),
        Text = "Play",
    };
    
    private Button PlayWindowButton = new Button()
    {
        Name = "PlayWindowButton",
        Anchor = AnchorStyles.Right,
        Location = new Point(480,55),
        Size = new Size(140,30),
        FlatStyle = FlatStyle.Flat,
        FlatAppearance = { BorderSize = 0 },
        BackColor = Color.FromArgb(255, 115, 156, 176),
        Font = new Font(Program.ProgramFont.FontFamily, 10f, FontStyle.Bold),
        Text = "Play Windowed"
    };
    
    private Button GameSettingsButton = new Button()
    {
        Name = "GameSettingsButton",
        Anchor = AnchorStyles.Right,
        Location = new Point(480,105),
        Size = new Size(140,30),
        FlatStyle = FlatStyle.Flat,
        FlatAppearance = { BorderSize = 0 },
        BackColor = Color.FromArgb(255, 115, 156, 176),
        Font = new Font(Program.ProgramFont.FontFamily, 10f, FontStyle.Bold),
        Text = "Game Settings"
    };
    
    private Button LauncherSettingsButton = new Button()
    {
        Name = "LauncherSettingsButton",
        Anchor = AnchorStyles.Right,
        Location = new Point(480,135),
        Size = new Size(140,30),
        FlatStyle = FlatStyle.Flat,
        FlatAppearance = { BorderSize = 0 },
        BackColor = Color.FromArgb(255, 115, 156, 176),
        Font = new Font(Program.ProgramFont.FontFamily, 10f, FontStyle.Bold),
        Text = "Launcher Settings"
    };

    private Panel ScreenshotsPanel = new Panel()
    {
        Name = "ScreenshotsPanel",
        Anchor = AnchorStyles.Left,
        Location = new Point(5,5),
        Size = new Size(380,270),
        BackColor = Color.FromArgb(255, 115, 156, 176),
    };
    
    private Panel CoverPanel = new Panel()
    {
        Name = "CoverPanel",
        Anchor = AnchorStyles.Left,
        Location = new Point(390,5),
        Size = new Size(85,270),
        BackColor = Color.FromArgb(255, 115, 156, 176),
    };

    #endregion
}