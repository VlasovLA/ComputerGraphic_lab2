using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Vlasov_tomogram_visualizer
{
    public partial class Form1 : Form
    {
        private bool loaded = false;
        private bool needReload = false;
        private bool texMode = false;
        private View view;
        private Bin bin;
        private int currentLayer;
        public Form1()
        {
            InitializeComponent();
            int currentLayer = 0;
            bin = new Bin();
            view = new View();
            view.minValue = minTrackBar.Value;
            view.widthValue = widthTrackBar.Value;
        }

        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps={0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
                layerTrackBar.Maximum = Bin.Z - 1;
                minTrackBar.Maximum = 4999;
                widthTrackBar.Maximum = 4999;
            }
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (texMode)
                switchButton.Text = "  Mode:\nQuad Strip";
            else
                switchButton.Text = "  Mode:\nTexture";
            texMode = !texMode;
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (needReload)
                {
                    view.GenerateTextureImage(currentLayer, minTrackBar.Value, widthTrackBar.Value);
                    view.Load2DTexture();
                    needReload = false;
                }
                if (texMode)
                    view.DrawTexture();
                else
                    view.DrawQuads(currentLayer);
                glControl1.SwapBuffers();
            }
        }

        private void layerTrackBar_Scroll(object sender, EventArgs e)
        {
            currentLayer = layerTrackBar.Value;
            layerTextBox.Text = layerTrackBar.Value.ToString();
            needReload = true;
        }

        private void minTrackBar_Scroll(object sender, EventArgs e)
        {
            view.minValue = minTrackBar.Value;
            minTextBox.Text = minTrackBar.Value.ToString();
            needReload = true;
        }

        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            view.widthValue = widthTrackBar.Value;
            widthTextBox.Text = widthTrackBar.Value.ToString();
            needReload = true;
        }

        private void layerTextBox_TextChanged(object sender, EventArgs e)
        {
            layerTrackBar.Value = Int32.Parse(layerTextBox.Text);
            currentLayer = layerTrackBar.Value;
            needReload = true;
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            minTrackBar.Value = Int32.Parse(minTextBox.Text);
            view.minValue = minTrackBar.Value;
            needReload = true;
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            widthTrackBar.Value = Int32.Parse(widthTextBox.Text);
            view.widthValue = widthTrackBar.Value;
            needReload = true;
        }

    }
}
