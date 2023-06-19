namespace WinFormsApp1
{
    partial class Form1
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem file;
        private ToolStripMenuItem open;
        private ToolStripMenuItem Exit;
        private Panel panel1;
        private Label labelMessage;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}