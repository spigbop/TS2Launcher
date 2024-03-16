using System.ComponentModel;

namespace TS2Launcher.Dialogues;

partial class GameSettings
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(320, 320);
        this.Text = "Game Settings";
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.BackColor = Color.FromArgb(255, 119, 128, 193);
        this.ForeColor = Color.FromArgb(255, 0, 14, 69);
        this.Font = new Font("Benguiat Gothic", 9.25f, FontStyle.Bold);
        
        this.Load += OnLoad;
        
        this.Controls.Add(TitlePanel);
        this.Controls.Add(DisableSoundLabel);
        this.Controls.Add(DisableSoundCheckBox);
        
    }

    private Panel TitlePanel = new Panel()
    {
        Name = "TitlePanel",
        Anchor = AnchorStyles.Left,
        Location = new Point(5,5),
        Size = new Size(121,18)
    };

    private CheckBox DisableSoundCheckBox = new CheckBox()
    {
        Name = "DisableSoundCheckBox",
        Anchor = AnchorStyles.Left,
        Location = new Point(5, 28),
        Text = ""
    };

    private Label DisableSoundLabel = new Label()
    {
        Name = "DisableSoundLabel",
        Anchor = AnchorStyles.Left,
        Location = new Point(20, 32),
        Size = new Size(300, 30),
        Text = "Disable All Sounds"
    };
    
    #endregion
}