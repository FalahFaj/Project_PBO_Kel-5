namespace Project_PBO_Kel_5
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tablelayout1 = new TableLayoutPanel();
            Minimize = new Button();
            Maximize = new Button();
            exit = new Button();
            tableLayout2 = new TableLayoutPanel();
            imageList = new ImageList(components);
            tablelayout1.SuspendLayout();
            SuspendLayout();
            // 
            // tablelayout1
            // 
            tablelayout1.BackColor = SystemColors.MenuHighlight;
            tablelayout1.ColumnCount = 8;
            tablelayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            tablelayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tablelayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.0135651F));
            tablelayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9864365F));
            tablelayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tablelayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tablelayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tablelayout1.ColumnStyles.Add(new ColumnStyle());
            tablelayout1.Controls.Add(Minimize, 4, 0);
            tablelayout1.Controls.Add(Maximize, 5, 0);
            tablelayout1.Controls.Add(exit, 6, 0);
            tablelayout1.Dock = DockStyle.Top;
            tablelayout1.Location = new Point(0, 0);
            tablelayout1.Margin = new Padding(0);
            tablelayout1.Name = "tablelayout1";
            tablelayout1.RowCount = 2;
            tablelayout1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.037735F));
            tablelayout1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.962265F));
            tablelayout1.Size = new Size(1100, 57);
            tablelayout1.TabIndex = 0;
            tablelayout1.Paint += tablelayout1_Paint;
            // 
            // Minimize
            // 
            Minimize.Dock = DockStyle.Fill;
            Minimize.FlatAppearance.BorderSize = 0;
            Minimize.FlatStyle = FlatStyle.Flat;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(951, 0);
            Minimize.Margin = new Padding(0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(52, 37);
            Minimize.TabIndex = 6;
            Minimize.UseVisualStyleBackColor = true;
            Minimize.Click += button5_Click;
            // 
            // Maximize
            // 
            Maximize.Dock = DockStyle.Fill;
            Maximize.FlatAppearance.BorderSize = 0;
            Maximize.FlatStyle = FlatStyle.Flat;
            Maximize.Image = (Image)resources.GetObject("Maximize.Image");
            Maximize.Location = new Point(1003, 0);
            Maximize.Margin = new Padding(0);
            Maximize.Name = "Maximize";
            Maximize.Size = new Size(46, 37);
            Maximize.TabIndex = 5;
            Maximize.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Dock = DockStyle.Fill;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1049, 0);
            exit.Margin = new Padding(0);
            exit.Name = "exit";
            exit.Size = new Size(50, 37);
            exit.TabIndex = 2;
            exit.UseVisualStyleBackColor = true;
            exit.Click += button1_Click;
            // 
            // tableLayout2
            // 
            tableLayout2.BackColor = SystemColors.MenuHighlight;
            tableLayout2.ColumnCount = 1;
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout2.Dock = DockStyle.Left;
            tableLayout2.Location = new Point(0, 57);
            tableLayout2.Name = "tableLayout2";
            tableLayout2.RowCount = 6;
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayout2.Size = new Size(78, 615);
            tableLayout2.TabIndex = 1;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "home.png");
            imageList.Images.SetKeyName(1, "choices.png");
            imageList.Images.SetKeyName(2, "order-now.png");
            imageList.Images.SetKeyName(3, "person.png");
            imageList.Images.SetKeyName(4, "shop.png");
            imageList.Images.SetKeyName(5, "shopping-cart.png");
            imageList.Images.SetKeyName(6, "settings.png");
            imageList.Images.SetKeyName(7, "person1.png");
            imageList.Images.SetKeyName(8, "user.png");
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1100, 672);
            Controls.Add(tableLayout2);
            Controls.Add(tablelayout1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            tablelayout1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tablelayout1;
        private TableLayoutPanel tableLayout2;
        private Button exit;
        private ImageList imageList;
        private Button Minimize;
        private Button Maximize;
    }
}