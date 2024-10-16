using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CPresentacion
{
    public class CustomLabel : Label
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();
        private Font customFont;

        // Constructor
        public CustomLabel()
        {
            this.DoubleBuffered = true;  // Para evitar parpadeos en el repintado
        }

        // Método para cargar la fuente personalizada desde un archivo
        public void LoadFontFromFile(string filePath, float fontSize, FontStyle style = FontStyle.Regular)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    privateFonts.AddFontFile(filePath);
                    customFont = new Font(privateFonts.Families[0], fontSize, style);
                    this.Font = customFont; // Asigna la fuente personalizada al label
                    this.Invalidate(); // Redibuja el control
                }
                else
                {
                    throw new FileNotFoundException("El archivo de fuente no fue encontrado.", filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la fuente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Aquí se puede realizar cualquier dibujo personalizado adicional si se desea
        }

        // Método opcional si quieres cargar la fuente desde un recurso embebido
        public void LoadFontFromResource(string resourceName, float fontSize, FontStyle style = FontStyle.Regular)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (Stream fontStream = assembly.GetManifestResourceStream(resourceName))
            {
                if (fontStream != null)
                {
                    byte[] fontData = new byte[fontStream.Length];
                    fontStream.Read(fontData, 0, (int)fontStream.Length);

                    IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                    Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                    privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                    Marshal.FreeCoTaskMem(fontPtr);

                    customFont = new Font(privateFonts.Families[0], fontSize, style);
                    this.Font = customFont; // Asigna la fuente personalizada
                }
            }
        }
    }
}
