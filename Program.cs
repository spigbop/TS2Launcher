using System.Drawing.Text;
using System.Reflection;

namespace TS2Launcher;

static class Program
{
    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
    
    private static PrivateFontCollection fonts = new PrivateFontCollection();

    public static Font ProgramFont = new("Microsoft Sans Serif", 9.25f, FontStyle.Regular);
    
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        Stream? font = Assembly.GetExecutingAssembly().GetManifestResourceStream("TS2Launcher.Resources.ts2font.ttf");
        if (font != null)
        {
            byte[] fontData = ReadFully(font);
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, (int)font.Length);
            AddFontMemResourceEx(fontPtr, (uint)font.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            ProgramFont = new Font(fonts.Families[0], 9.25f);
        }
        
        Application.Run(new Launcher());
    }
    
    public static byte[] ReadFully(Stream input)
    {
        byte[] buffer = new byte[16*1024];
        using (MemoryStream ms = new MemoryStream())
        {
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }
    }
}