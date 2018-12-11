namespace Lab11_
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.cbCircles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(655, 535);
            this.pnMain.TabIndex = 0;
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.btnCollapse);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.cbCircles);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTools.Location = new System.Drawing.Point(346, 0);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(309, 535);
            this.pnTools.TabIndex = 1;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Image = ((System.Drawing.Image)(resources.GetObject("btnCollapse.Image")));
            this.btnCollapse.Location = new System.Drawing.Point(118, 331);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(46, 34);
            this.btnCollapse.TabIndex = 14;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnExpand.Image")));
            this.btnExpand.Location = new System.Drawing.Point(118, 284);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(46, 41);
            this.btnExpand.TabIndex = 13;
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.BackColor = System.Drawing.Color.Lime;
            this.btnDownFar.Image = ((System.Drawing.Image)(resources.GetObject("btnDownFar.Image")));
            this.btnDownFar.Location = new System.Drawing.Point(101, 400);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(75, 23);
            this.btnDownFar.TabIndex = 12;
            this.btnDownFar.UseVisualStyleBackColor = false;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // btnDown
            // 
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(101, 371);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 11;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.BackColor = System.Drawing.Color.Lime;
            this.btnLeftFar.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftFar.Image")));
            this.btnLeftFar.Location = new System.Drawing.Point(27, 290);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(29, 75);
            this.btnLeftFar.TabIndex = 10;
            this.btnLeftFar.UseVisualStyleBackColor = false;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(62, 290);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(27, 75);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRightFar
            // 
            this.btnRightFar.BackColor = System.Drawing.Color.Lime;
            this.btnRightFar.Image = ((System.Drawing.Image)(resources.GetObject("btnRightFar.Image")));
            this.btnRightFar.Location = new System.Drawing.Point(231, 290);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(28, 75);
            this.btnRightFar.TabIndex = 8;
            this.btnRightFar.UseVisualStyleBackColor = false;
            this.btnRightFar.Click += new System.EventHandler(this.btnRightFar_Click);
            // 
            // btnRight
            // 
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(198, 290);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(29, 75);
            this.btnRight.TabIndex = 7;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(101, 255);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.BackColor = System.Drawing.Color.Lime;
            this.btnUpFar.Image = ((System.Drawing.Image)(resources.GetObject("btnUpFar.Image")));
            this.btnUpFar.Location = new System.Drawing.Point(101, 226);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(75, 23);
            this.btnUpFar.TabIndex = 5;
            this.btnUpFar.UseVisualStyleBackColor = false;
            this.btnUpFar.Click += new System.EventHandler(this.btnUpFar_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(62, 155);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(146, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(62, 126);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(146, 23);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(62, 97);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(146, 23);
            this.btnCreateNew.TabIndex = 2;
            this.btnCreateNew.Text = "Створити новий об\'єкт";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // cbCircles
            // 
            this.cbCircles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCircles.FormattingEnabled = true;
            this.cbCircles.Location = new System.Drawing.Point(62, 31);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(146, 21);
            this.cbCircles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перелік об\'єктів:";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 535);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.pnMain);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №11";
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cbCircles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
    }
}

