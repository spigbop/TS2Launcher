using System.ComponentModel;

namespace TS2Launcher.Dialogues;

partial class ChooseDirectories
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
        this.Text = "Choose Directories...";
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.BackColor = Color.FromArgb(255, 119, 128, 193);
        this.ForeColor = Color.FromArgb(255, 0, 14, 69);
        this.Font = Program.ProgramFont;
        
        this.Controls.Add(ApplyButton);
        ApplyButton.Click += ApplyButtonOnClick;
    }

    private Button ApplyButton = new Button()
    {
        Name = "ApplyButton",
        Anchor = AnchorStyles.Left,
        Location = new Point(230, 270),
        Size = new Size(85, 25),
        BackColor = Color.FromArgb(255, 115, 156, 176),
        FlatStyle = FlatStyle.Flat,
        FlatAppearance = { BorderSize = 0 },
        Text = "Apply"
    };
    
    #endregion
}