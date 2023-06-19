using Emgu.CV;
using Emgu.CV.Structure;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            file = new ToolStripMenuItem();
            open = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            panel1 = new Panel();
            labelMessage = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { file });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(526, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            file.DropDownItems.AddRange(new ToolStripItem[] { open, Exit });
            file.Name = "file";
            file.Size = new Size(34, 20);
            file.Text = "file";
            // 
            // open
            // 
            open.Name = "open";
            open.Size = new Size(180, 22);
            open.Text = "open";
            open.Click += open_Click;
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(180, 22);
            Exit.Text = "Exit";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelMessage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 41);
            panel1.TabIndex = 1;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.ImageAlign = ContentAlignment.BottomLeft;
            labelMessage.Location = new Point(10, 11);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 21);
            labelMessage.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 419);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(526, 484);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.png;*.bmp;) |*.jpg;*.png;*.bmp; ";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var img = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = img.ToBitmap();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}