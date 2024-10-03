namespace LR1Stasiia
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelTermName = new System.Windows.Forms.Label();
            this.labelCriteria = new System.Windows.Forms.Label();
            this.labelAlternatives = new System.Windows.Forms.Label();
            this.labelTerms = new System.Windows.Forms.Label();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxMiddle = new System.Windows.Forms.TextBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.textBoxTermName = new System.Windows.Forms.TextBox();
            this.textBoxCriteria = new System.Windows.Forms.TextBox();
            this.textBoxAlternatives = new System.Windows.Forms.TextBox();
            this.textBoxTerms = new System.Windows.Forms.TextBox();
            this.buttonNormalize = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.labelShortName = new System.Windows.Forms.Label();
            this.buttonConvertToShortNames = new System.Windows.Forms.Button();
            this.buttonConvertToTrapezoidal = new System.Windows.Forms.Button();
            this.buttonCreateTable = new System.Windows.Forms.Button();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.buttonTrapezIntervalRatings = new System.Windows.Forms.Button();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.labelAlphaValue = new System.Windows.Forms.Label();
            this.buttonAlphaPositionValue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxNormalizedIntervals = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTermName
            // 
            this.labelTermName.AutoSize = true;
            this.labelTermName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTermName.ForeColor = System.Drawing.Color.White;
            this.labelTermName.Location = new System.Drawing.Point(41, 249);
            this.labelTermName.Name = "labelTermName";
            this.labelTermName.Size = new System.Drawing.Size(142, 27);
            this.labelTermName.TabIndex = 3;
            this.labelTermName.Text = "Назва терму:";
            //this.labelTermName.Click += new System.EventHandler(this.labelTermName_Click);
            // 
            // labelCriteria
            // 
            this.labelCriteria.AutoSize = true;
            this.labelCriteria.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCriteria.ForeColor = System.Drawing.Color.White;
            this.labelCriteria.Location = new System.Drawing.Point(326, 50);
            this.labelCriteria.Name = "labelCriteria";
            this.labelCriteria.Size = new System.Drawing.Size(149, 27);
            this.labelCriteria.TabIndex = 4;
            this.labelCriteria.Text = "- Критерії (≥7)";
            //this.labelCriteria.Click += new System.EventHandler(this.labelCriteria_Click);
            // 
            // labelAlternatives
            // 
            this.labelAlternatives.AutoSize = true;
            this.labelAlternatives.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlternatives.ForeColor = System.Drawing.Color.White;
            this.labelAlternatives.Location = new System.Drawing.Point(256, 104);
            this.labelAlternatives.Name = "labelAlternatives";
            this.labelAlternatives.Size = new System.Drawing.Size(219, 27);
            this.labelAlternatives.TabIndex = 5;
            this.labelAlternatives.Text = "- Альтернативи (≥ 5)";
            //this.labelAlternatives.Click += new System.EventHandler(this.labelAlternatives_Click);
            // 
            // labelTerms
            // 
            this.labelTerms.AutoSize = true;
            this.labelTerms.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTerms.ForeColor = System.Drawing.Color.White;
            this.labelTerms.Location = new System.Drawing.Point(283, 155);
            this.labelTerms.Name = "labelTerms";
            this.labelTerms.Size = new System.Drawing.Size(192, 27);
            this.labelTerms.TabIndex = 6;
            this.labelTerms.Text = "- Кількість термів";
            //this.labelTerms.Click += new System.EventHandler(this.labelTerms_Click);
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLeft.Location = new System.Drawing.Point(46, 385);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(178, 34);
            this.textBoxLeft.TabIndex = 26;
            //this.textBoxLeft.TextChanged += new System.EventHandler(this.textBoxLeft_TextChanged);
            // 
            // textBoxMiddle
            // 
            this.textBoxMiddle.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddle.Location = new System.Drawing.Point(46, 437);
            this.textBoxMiddle.Name = "textBoxMiddle";
            this.textBoxMiddle.Size = new System.Drawing.Size(178, 34);
            this.textBoxMiddle.TabIndex = 8;
            //this.textBoxMiddle.TextChanged += new System.EventHandler(this.textBoxMiddle_TextChanged);
            // 
            // textBoxRight
            // 
            this.textBoxRight.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRight.Location = new System.Drawing.Point(46, 489);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(178, 34);
            this.textBoxRight.TabIndex = 9;
            //this.textBoxRight.TextChanged += new System.EventHandler(this.textBoxRight_TextChanged);
            // 
            // textBoxTermName
            // 
            this.textBoxTermName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTermName.Location = new System.Drawing.Point(238, 246);
            this.textBoxTermName.Name = "textBoxTermName";
            this.textBoxTermName.Size = new System.Drawing.Size(237, 34);
            this.textBoxTermName.TabIndex = 10;
            //this.textBoxTermName.TextChanged += new System.EventHandler(this.textBoxTermName_TextChanged);
            // 
            // textBoxCriteria
            // 
            this.textBoxCriteria.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCriteria.Location = new System.Drawing.Point(46, 43);
            this.textBoxCriteria.Name = "textBoxCriteria";
            this.textBoxCriteria.Size = new System.Drawing.Size(178, 34);
            this.textBoxCriteria.TabIndex = 11;
            //this.textBoxCriteria.TextChanged += new System.EventHandler(this.textBoxCriteria_TextChanged);
            // 
            // textBoxAlternatives
            // 
            this.textBoxAlternatives.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlternatives.Location = new System.Drawing.Point(46, 97);
            this.textBoxAlternatives.Name = "textBoxAlternatives";
            this.textBoxAlternatives.Size = new System.Drawing.Size(178, 34);
            this.textBoxAlternatives.TabIndex = 12;
            //this.textBoxAlternatives.TextChanged += new System.EventHandler(this.textBoxAlternatives_TextChanged);
            // 
            // textBoxTerms
            // 
            this.textBoxTerms.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTerms.Location = new System.Drawing.Point(46, 148);
            this.textBoxTerms.Name = "textBoxTerms";
            this.textBoxTerms.Size = new System.Drawing.Size(178, 34);
            this.textBoxTerms.TabIndex = 13;
            //this.textBoxTerms.TextChanged += new System.EventHandler(this.textBoxTerms_TextChanged);
            // 
            // buttonNormalize
            // 
            this.buttonNormalize.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNormalize.Location = new System.Drawing.Point(914, 39);
            this.buttonNormalize.Name = "buttonNormalize";
            this.buttonNormalize.Size = new System.Drawing.Size(255, 73);
            this.buttonNormalize.TabIndex = 15;
            this.buttonNormalize.Text = "Нормалізація";
            this.buttonNormalize.UseVisualStyleBackColor = true;
            this.buttonNormalize.Click += new System.EventHandler(this.buttonNormalize_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(914, 133);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(255, 74);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Скинути";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(874, 642);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 305);
            this.dataGridView1.TabIndex = 20;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zedGraphControl1.Location = new System.Drawing.Point(1270, 43);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(749, 559);
            this.zedGraphControl1.TabIndex = 21;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            //this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShortName.Location = new System.Drawing.Point(331, 296);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(144, 34);
            this.textBoxShortName.TabIndex = 23;
            //this.textBoxShortName.TextChanged += new System.EventHandler(this.textBoxShortName_TextChanged);
            // 
            // labelShortName
            // 
            this.labelShortName.AutoSize = true;
            this.labelShortName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShortName.ForeColor = System.Drawing.Color.White;
            this.labelShortName.Location = new System.Drawing.Point(41, 303);
            this.labelShortName.Name = "labelShortName";
            this.labelShortName.Size = new System.Drawing.Size(246, 27);
            this.labelShortName.TabIndex = 22;
            this.labelShortName.Text = "Скорочена назва терму:";
            //this.labelShortName.Click += new System.EventHandler(this.labelShortName_Click);
            // 
            // buttonConvertToShortNames
            // 
            this.buttonConvertToShortNames.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConvertToShortNames.Location = new System.Drawing.Point(586, 337);
            this.buttonConvertToShortNames.Name = "buttonConvertToShortNames";
            this.buttonConvertToShortNames.Size = new System.Drawing.Size(583, 73);
            this.buttonConvertToShortNames.TabIndex = 24;
            this.buttonConvertToShortNames.Text = "Матриця інтервальних експертних оцінок";
            this.buttonConvertToShortNames.UseVisualStyleBackColor = true;
            this.buttonConvertToShortNames.Click += new System.EventHandler(this.buttonConvertToShortNames_Click);
            // 
            // buttonConvertToTrapezoidal
            // 
            this.buttonConvertToTrapezoidal.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConvertToTrapezoidal.Location = new System.Drawing.Point(586, 435);
            this.buttonConvertToTrapezoidal.Name = "buttonConvertToTrapezoidal";
            this.buttonConvertToTrapezoidal.Size = new System.Drawing.Size(583, 73);
            this.buttonConvertToTrapezoidal.TabIndex = 25;
            this.buttonConvertToTrapezoidal.Text = "Матриця трапеційних лінгвістичних термів";
            this.buttonConvertToTrapezoidal.UseVisualStyleBackColor = true;
            this.buttonConvertToTrapezoidal.Click += new System.EventHandler(this.buttonConvertToTrapezoidal_Click);
            // 
            // buttonCreateTable
            // 
            this.buttonCreateTable.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateTable.Location = new System.Drawing.Point(586, 225);
            this.buttonCreateTable.Name = "buttonCreateTable";
            this.buttonCreateTable.Size = new System.Drawing.Size(583, 74);
            this.buttonCreateTable.TabIndex = 27;
            this.buttonCreateTable.Text = "Побудувати таблицю";
            this.buttonCreateTable.UseVisualStyleBackColor = true;
            this.buttonCreateTable.Click += new System.EventHandler(this.buttonCreateTable_Click);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuild.Location = new System.Drawing.Point(586, 39);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(306, 73);
            this.buttonBuild.TabIndex = 28;
            this.buttonBuild.Text = "Побудувати графік";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // buttonTrapezIntervalRatings
            // 
            this.buttonTrapezIntervalRatings.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTrapezIntervalRatings.Location = new System.Drawing.Point(586, 530);
            this.buttonTrapezIntervalRatings.Name = "buttonTrapezIntervalRatings";
            this.buttonTrapezIntervalRatings.Size = new System.Drawing.Size(583, 72);
            this.buttonTrapezIntervalRatings.TabIndex = 33;
            this.buttonTrapezIntervalRatings.Text = "Інтервальні оцінки лінгвістичних трапеційних термів";
            this.buttonTrapezIntervalRatings.UseVisualStyleBackColor = true;
            this.buttonTrapezIntervalRatings.Click += new System.EventHandler(this.buttonTrapezIntervalRatings_Click);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlpha.Location = new System.Drawing.Point(297, 568);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(178, 34);
            this.textBoxAlpha.TabIndex = 36;
            this.textBoxAlpha.TextChanged += new System.EventHandler(this.textBoxAlpha_TextChanged);
            // 
            // labelAlphaValue
            // 
            this.labelAlphaValue.AutoSize = true;
            this.labelAlphaValue.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlphaValue.ForeColor = System.Drawing.Color.White;
            this.labelAlphaValue.Location = new System.Drawing.Point(41, 575);
            this.labelAlphaValue.Name = "labelAlphaValue";
            this.labelAlphaValue.Size = new System.Drawing.Size(164, 27);
            this.labelAlphaValue.TabIndex = 37;
            this.labelAlphaValue.Text = "Введіть альфа:";
            //this.labelAlphaValue.Click += new System.EventHandler(this.labelAlphaValue_Click);
            // 
            // buttonAlphaPositionValue
            // 
            this.buttonAlphaPositionValue.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAlphaPositionValue.Location = new System.Drawing.Point(586, 133);
            this.buttonAlphaPositionValue.Name = "buttonAlphaPositionValue";
            this.buttonAlphaPositionValue.Size = new System.Drawing.Size(306, 71);
            this.buttonAlphaPositionValue.TabIndex = 38;
            this.buttonAlphaPositionValue.Text = "Зберегти альфа";
            this.buttonAlphaPositionValue.UseVisualStyleBackColor = true;
            this.buttonAlphaPositionValue.Click += new System.EventHandler(this.buttonAlphaPositionValue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(326, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 4;
            // 
            // listBoxNormalizedIntervals
            // 
            this.listBoxNormalizedIntervals.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxNormalizedIntervals.FormattingEnabled = true;
            this.listBoxNormalizedIntervals.ItemHeight = 27;
            this.listBoxNormalizedIntervals.Location = new System.Drawing.Point(46, 642);
            this.listBoxNormalizedIntervals.Name = "listBoxNormalizedIntervals";
            this.listBoxNormalizedIntervals.Size = new System.Drawing.Size(800, 328);
            this.listBoxNormalizedIntervals.TabIndex = 32;
            this.listBoxNormalizedIntervals.SelectedIndexChanged += new System.EventHandler(this.listBoxNormalizedIntervals_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "- Праве значення";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 27);
            this.label2.TabIndex = 40;
            this.label2.Text = "- Середнє значення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(326, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "- Ліве значення";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1022);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAlphaPositionValue);
            this.Controls.Add(this.labelAlphaValue);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.buttonTrapezIntervalRatings);
            this.Controls.Add(this.listBoxNormalizedIntervals);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.buttonCreateTable);
            this.Controls.Add(this.buttonConvertToTrapezoidal);
            this.Controls.Add(this.buttonConvertToShortNames);
            this.Controls.Add(this.textBoxShortName);
            this.Controls.Add(this.labelShortName);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonNormalize);
            this.Controls.Add(this.textBoxTerms);
            this.Controls.Add(this.textBoxAlternatives);
            this.Controls.Add(this.textBoxCriteria);
            this.Controls.Add(this.textBoxTermName);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.textBoxMiddle);
            this.Controls.Add(this.textBoxLeft);
            this.Controls.Add(this.labelTerms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAlternatives);
            this.Controls.Add(this.labelCriteria);
            this.Controls.Add(this.labelTermName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTermName;
        private System.Windows.Forms.Label labelCriteria;
        private System.Windows.Forms.Label labelAlternatives;
        private System.Windows.Forms.Label labelTerms;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxMiddle;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.TextBox textBoxTermName;
        private System.Windows.Forms.TextBox textBoxCriteria;
        private System.Windows.Forms.TextBox textBoxAlternatives;
        private System.Windows.Forms.TextBox textBoxTerms;
        private System.Windows.Forms.Button buttonNormalize;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox textBoxShortName;
        private System.Windows.Forms.Label labelShortName;
        private System.Windows.Forms.Button buttonConvertToShortNames;
        private System.Windows.Forms.Button buttonConvertToTrapezoidal;
        private System.Windows.Forms.Button buttonCreateTable;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Button buttonTrapezIntervalRatings;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label labelAlphaValue;
        private System.Windows.Forms.Button buttonAlphaPositionValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxNormalizedIntervals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

