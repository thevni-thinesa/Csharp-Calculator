namespace Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            EightBtn = new Button();
            FiveBtn = new Button();
            TwoBtn = new Button();
            DotBtn = new Button();
            NineBtn = new Button();
            SixBtn = new Button();
            ThreeBtn = new Button();
            EqualBtn = new Button();
            ClearBtn = new Button();
            MinusBtn = new Button();
            DivBtn = new Button();
            MinusPlusBtn = new Button();
            PlusBtn = new Button();
            MulBtn = new Button();
            ModBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 20F);
            TxtBox.Location = new Point(12, 28);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(487, 61);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F);
            SevenBtn.Location = new Point(23, 148);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(77, 82);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F);
            FourBtn.Location = new Point(23, 236);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(77, 82);
            FourBtn.TabIndex = 1;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F);
            OneBtn.Location = new Point(23, 322);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(77, 82);
            OneBtn.TabIndex = 1;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F);
            ZeroBtn.Location = new Point(23, 410);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(77, 82);
            ZeroBtn.TabIndex = 1;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F);
            EightBtn.Location = new Point(106, 148);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(77, 82);
            EightBtn.TabIndex = 1;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F);
            FiveBtn.Location = new Point(106, 236);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(77, 82);
            FiveBtn.TabIndex = 1;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F);
            TwoBtn.Location = new Point(106, 322);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(77, 82);
            TwoBtn.TabIndex = 1;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F);
            DotBtn.Location = new Point(106, 410);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(77, 82);
            DotBtn.TabIndex = 1;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F);
            NineBtn.Location = new Point(189, 148);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(77, 82);
            NineBtn.TabIndex = 1;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F);
            SixBtn.Location = new Point(189, 236);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(77, 82);
            SixBtn.TabIndex = 1;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F);
            ThreeBtn.Location = new Point(189, 322);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(77, 82);
            ThreeBtn.TabIndex = 1;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F);
            EqualBtn.Location = new Point(189, 410);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(77, 82);
            EqualBtn.TabIndex = 1;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F);
            ClearBtn.Location = new Point(339, 148);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(160, 82);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F);
            MinusBtn.Location = new Point(339, 236);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(77, 82);
            MinusBtn.TabIndex = 1;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            // 
            // DivBtn
            // 
            DivBtn.Font = new Font("Segoe UI", 12F);
            DivBtn.Location = new Point(339, 322);
            DivBtn.Name = "DivBtn";
            DivBtn.Size = new Size(77, 82);
            DivBtn.TabIndex = 1;
            DivBtn.Text = "/";
            DivBtn.UseVisualStyleBackColor = true;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Font = new Font("Segoe UI", 12F);
            MinusPlusBtn.Location = new Point(339, 410);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(77, 82);
            MinusPlusBtn.TabIndex = 1;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F);
            PlusBtn.Location = new Point(422, 236);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(77, 82);
            PlusBtn.TabIndex = 1;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            // 
            // MulBtn
            // 
            MulBtn.Font = new Font("Segoe UI", 12F);
            MulBtn.Location = new Point(422, 322);
            MulBtn.Name = "MulBtn";
            MulBtn.Size = new Size(77, 82);
            MulBtn.TabIndex = 1;
            MulBtn.Text = "x";
            MulBtn.UseVisualStyleBackColor = true;
            // 
            // ModBtn
            // 
            ModBtn.Font = new Font("Segoe UI", 12F);
            ModBtn.Location = new Point(422, 410);
            ModBtn.Name = "ModBtn";
            ModBtn.Size = new Size(77, 82);
            ModBtn.TabIndex = 1;
            ModBtn.Text = "%";
            ModBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.how_to_become_software_engineer;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(525, 517);
            Controls.Add(ModBtn);
            Controls.Add(MinusPlusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(DotBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(MulBtn);
            Controls.Add(DivBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(TwoBtn);
            Controls.Add(OneBtn);
            Controls.Add(PlusBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button EightBtn;
        private Button FiveBtn;
        private Button TwoBtn;
        private Button DotBtn;
        private Button NineBtn;
        private Button SixBtn;
        private Button ThreeBtn;
        private Button EqualBtn;
        private Button ClearBtn;
        private Button MinusBtn;
        private Button DivBtn;
        private Button MinusPlusBtn;
        private Button PlusBtn;
        private Button MulBtn;
        private Button ModBtn;
    }
}
