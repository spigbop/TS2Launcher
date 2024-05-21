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
        this.Font = Program.ProgramFont;
        
        this.Load += OnLoad;
        
        this.Controls.Add(DisableSoundLabel);
        this.Controls.Add(DisableSoundCheckBox);
        this.Controls.Add(CustomResoulitonLabel);
        this.Controls.Add(CustomResoulitonCheckBox);
        CustomResoulitonCheckBox.Click += CustomResolutionCheckBoxOnClick;
        this.Controls.Add(ResolutionWidthBox);
        this.Controls.Add(ResXLabel);
        this.Controls.Add(ResolutionHeightBox);
        this.Controls.Add(ResYLabel);
        this.Controls.Add(AutoResoulitonButton);
        AutoResoulitonButton.Click += AutoResolutionButtonOnClick;
        this.Controls.Add(ApplyButton);
        ApplyButton.Click += ApplyButtonOnClick;
    }

    private CheckBox DisableSoundCheckBox = new CheckBox()
    {
        Name = "DisableSoundCheckBox",
        Anchor = AnchorStyles.Left,
        Location = new Point(5, 5),
        Text = ""
    };

    private Label DisableSoundLabel = new Label()
    {
        Name = "DisableSoundLabel",
        Anchor = AnchorStyles.Left,
        Location = new Point(20, 9),
        Size = new Size(300, 30),
        Text = "Disable All Sounds"
    };
    
    private CheckBox CustomResoulitonCheckBox = new CheckBox()
    {
        Name = "CustomResoulitonCheckBox",
        Anchor = AnchorStyles.Left,
        Location = new Point(5, 35),
        Text = ""
    };
    
    private Label CustomResoulitonLabel = new Label()
    {
        Name = "CustomResoulitonLabel",
        Anchor = AnchorStyles.Left,
        Location = new Point(20, 39),
        Size = new Size(300, 30),
        Text = "Custom Resolution:"
    };
    
    private NumericUpDown ResolutionWidthBox = new NumericUpDown()
    {
        Name = "ResolutionWidthBox",
        Enabled = false,
        Anchor = AnchorStyles.Left,
        Location = new Point(50, 70),
        Size = new Size(60, 30),
        Maximum = 2147483645,
        Minimum = 1,
        Value = 640
    };
    
    private NumericUpDown ResolutionHeightBox = new NumericUpDown()
    {
        Name = "ResolutionHeightBox",
        Enabled = false,
        Anchor = AnchorStyles.Left,
        Location = new Point(165, 70),
        Size = new Size(60, 30),
        Maximum = 2147483645,
        Minimum = 1,
        Value = 480
    };
    
    private Label ResXLabel = new Label()
    {
        Name = "ResXLabel",
        Anchor = AnchorStyles.Left,
        Location = new Point(5, 74),
        Size = new Size(50, 30),
        Text = "Width:"
    };
    
    private Label ResYLabel = new Label()
    {
        Name = "ResYLabel",
        Anchor = AnchorStyles.Left,
        Location = new Point(115, 74),
        Size = new Size(60, 30),
        Text = "Height:"
    };
    
    private Button AutoResoulitonButton = new Button()
    {
        Name = "AutoResoulitonButton",
        Enabled = false,
        Anchor = AnchorStyles.Left,
        Location = new Point(230, 70),
        Size = new Size(85, 25),
        BackColor = Color.FromArgb(255, 115, 156, 176),
        FlatStyle = FlatStyle.Flat,
        FlatAppearance = { BorderSize = 0 },
        Text = "Auto"
    };
    
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