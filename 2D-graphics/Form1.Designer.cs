
namespace _2D_graphics
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
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.panel2D = new System.Windows.Forms.Panel();
        this.colorPickerFig = new System.Windows.Forms.Button();
        this.ClearButton = new System.Windows.Forms.Button();
        this.checkBoxFigurePoints = new System.Windows.Forms.CheckBox();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
        this.textBoxAngle = new System.Windows.Forms.TextBox();
        this.button2 = new System.Windows.Forms.Button();
        this.checkBoxShowPoint = new System.Windows.Forms.CheckBox();
        this.radioButtonOwnCenter = new System.Windows.Forms.RadioButton();
        this.radioButtonCenter = new System.Windows.Forms.RadioButton();
        this.textBoxY0 = new System.Windows.Forms.TextBox();
        this.radioButtonPoint = new System.Windows.Forms.RadioButton();
        this.textBoxX0 = new System.Windows.Forms.TextBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.textBoxScale = new System.Windows.Forms.TextBox();
        this.trackBarScale = new System.Windows.Forms.TrackBar();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.matrix = new System.Windows.Forms.DataGridView();
        this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colorDialogFigure = new System.Windows.Forms.ColorDialog();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.panel2D.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.pictureBox1.Location = new System.Drawing.Point(12, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(848, 676);
        this.pictureBox1.TabIndex = 2;
        this.pictureBox1.TabStop = false;
        this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
        // 
        // panel2D
        // 
        this.panel2D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.panel2D.Controls.Add(this.colorPickerFig);
        this.panel2D.Controls.Add(this.ClearButton);
        this.panel2D.Controls.Add(this.checkBoxFigurePoints);
        this.panel2D.Controls.Add(this.groupBox3);
        this.panel2D.Controls.Add(this.groupBox2);
        this.panel2D.Controls.Add(this.groupBox1);
        this.panel2D.Location = new System.Drawing.Point(866, 12);
        this.panel2D.Name = "panel2D";
        this.panel2D.Size = new System.Drawing.Size(249, 676);
        this.panel2D.TabIndex = 32;
        // 
        // colorPickerFig
        // 
        this.colorPickerFig.AutoSize = true;
        this.colorPickerFig.BackColor = System.Drawing.Color.Silver;
        this.colorPickerFig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.colorPickerFig.Location = new System.Drawing.Point(69, 398);
        this.colorPickerFig.Name = "colorPickerFig";
        this.colorPickerFig.Size = new System.Drawing.Size(104, 27);
        this.colorPickerFig.TabIndex = 21;
        this.colorPickerFig.Text = "Цвет фигуры";
        this.colorPickerFig.UseVisualStyleBackColor = false;
        this.colorPickerFig.Click += new System.EventHandler(this.colorPickerFig_Click);
        // 
        // ClearButton
        // 
        this.ClearButton.AutoSize = true;
        this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.ClearButton.Location = new System.Drawing.Point(63, 627);
        this.ClearButton.Name = "ClearButton";
        this.ClearButton.Size = new System.Drawing.Size(123, 30);
        this.ClearButton.TabIndex = 26;
        this.ClearButton.Text = "Очистить";
        this.ClearButton.UseVisualStyleBackColor = true;
        this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
        // 
        // checkBoxFigurePoints
        // 
        this.checkBoxFigurePoints.AutoSize = true;
        this.checkBoxFigurePoints.Location = new System.Drawing.Point(63, 431);
        this.checkBoxFigurePoints.Name = "checkBoxFigurePoints";
        this.checkBoxFigurePoints.Size = new System.Drawing.Size(123, 21);
        this.checkBoxFigurePoints.TabIndex = 25;
        this.checkBoxFigurePoints.Text = "Точки фигуры";
        this.checkBoxFigurePoints.UseVisualStyleBackColor = true;
        this.checkBoxFigurePoints.CheckedChanged += new System.EventHandler(this.Invalidate);
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.checkBoxAnimation);
        this.groupBox3.Controls.Add(this.textBoxAngle);
        this.groupBox3.Controls.Add(this.button2);
        this.groupBox3.Controls.Add(this.checkBoxShowPoint);
        this.groupBox3.Controls.Add(this.radioButtonOwnCenter);
        this.groupBox3.Controls.Add(this.radioButtonCenter);
        this.groupBox3.Controls.Add(this.textBoxY0);
        this.groupBox3.Controls.Add(this.radioButtonPoint);
        this.groupBox3.Controls.Add(this.textBoxX0);
        this.groupBox3.Location = new System.Drawing.Point(3, 214);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(243, 178);
        this.groupBox3.TabIndex = 20;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Поворот и анимация";
        // 
        // checkBoxAnimation
        // 
        this.checkBoxAnimation.AutoSize = true;
        this.checkBoxAnimation.Location = new System.Drawing.Point(74, 147);
        this.checkBoxAnimation.Name = "checkBoxAnimation";
        this.checkBoxAnimation.Size = new System.Drawing.Size(96, 21);
        this.checkBoxAnimation.TabIndex = 22;
        this.checkBoxAnimation.Text = "Анимация";
        this.checkBoxAnimation.UseVisualStyleBackColor = true;
        this.checkBoxAnimation.CheckedChanged += new System.EventHandler(this.checkBoxAnimation_CheckedChanged);
        // 
        // textBoxAngle
        // 
        this.textBoxAngle.Location = new System.Drawing.Point(137, 23);
        this.textBoxAngle.Name = "textBoxAngle";
        this.textBoxAngle.Size = new System.Drawing.Size(72, 22);
        this.textBoxAngle.TabIndex = 12;
        this.textBoxAngle.Text = "0";
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(29, 18);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(85, 33);
        this.button2.TabIndex = 11;
        this.button2.Text = "Поворот";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // checkBoxShowPoint
        // 
        this.checkBoxShowPoint.AutoSize = true;
        this.checkBoxShowPoint.Location = new System.Drawing.Point(152, 107);
        this.checkBoxShowPoint.Name = "checkBoxShowPoint";
        this.checkBoxShowPoint.Size = new System.Drawing.Size(70, 21);
        this.checkBoxShowPoint.TabIndex = 21;
        this.checkBoxShowPoint.Text = "Точка";
        this.checkBoxShowPoint.UseVisualStyleBackColor = true;
        this.checkBoxShowPoint.CheckedChanged += new System.EventHandler(this.Invalidate);
        // 
        // radioButtonOwnCenter
        // 
        this.radioButtonOwnCenter.AutoSize = true;
        this.radioButtonOwnCenter.Location = new System.Drawing.Point(21, 106);
        this.radioButtonOwnCenter.Name = "radioButtonOwnCenter";
        this.radioButtonOwnCenter.Size = new System.Drawing.Size(104, 21);
        this.radioButtonOwnCenter.TabIndex = 15;
        this.radioButtonOwnCenter.TabStop = true;
        this.radioButtonOwnCenter.Text = "Свой центр";
        this.radioButtonOwnCenter.UseVisualStyleBackColor = true;
        this.radioButtonOwnCenter.CheckedChanged += new System.EventHandler(this.Invalidate);
        // 
        // radioButtonCenter
        // 
        this.radioButtonCenter.AutoSize = true;
        this.radioButtonCenter.Checked = true;
        this.radioButtonCenter.Location = new System.Drawing.Point(21, 79);
        this.radioButtonCenter.Name = "radioButtonCenter";
        this.radioButtonCenter.Size = new System.Drawing.Size(149, 21);
        this.radioButtonCenter.TabIndex = 14;
        this.radioButtonCenter.TabStop = true;
        this.radioButtonCenter.Text = "Центр координат ";
        this.radioButtonCenter.UseVisualStyleBackColor = true;
        this.radioButtonCenter.CheckedChanged += new System.EventHandler(this.Invalidate);
        // 
        // textBoxY0
        // 
        this.textBoxY0.Location = new System.Drawing.Point(176, 51);
        this.textBoxY0.Name = "textBoxY0";
        this.textBoxY0.Size = new System.Drawing.Size(39, 22);
        this.textBoxY0.TabIndex = 11;
        this.textBoxY0.Text = "0";
        this.textBoxY0.TextChanged += new System.EventHandler(this.Invalidate);
        // 
        // radioButtonPoint
        // 
        this.radioButtonPoint.AutoSize = true;
        this.radioButtonPoint.Location = new System.Drawing.Point(21, 52);
        this.radioButtonPoint.Name = "radioButtonPoint";
        this.radioButtonPoint.Size = new System.Drawing.Size(69, 21);
        this.radioButtonPoint.TabIndex = 13;
        this.radioButtonPoint.TabStop = true;
        this.radioButtonPoint.Text = "Точка";
        this.radioButtonPoint.UseVisualStyleBackColor = true;
        this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.Invalidate);
        // 
        // textBoxX0
        // 
        this.textBoxX0.Location = new System.Drawing.Point(129, 51);
        this.textBoxX0.Name = "textBoxX0";
        this.textBoxX0.Size = new System.Drawing.Size(41, 22);
        this.textBoxX0.TabIndex = 10;
        this.textBoxX0.Text = "0";
        this.textBoxX0.TextChanged += new System.EventHandler(this.Invalidate);
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.textBoxScale);
        this.groupBox2.Controls.Add(this.trackBarScale);
        this.groupBox2.Location = new System.Drawing.Point(3, 3);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(243, 65);
        this.groupBox2.TabIndex = 19;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Масштаб";
        // 
        // textBoxScale
        // 
        this.textBoxScale.Location = new System.Drawing.Point(189, 21);
        this.textBoxScale.Name = "textBoxScale";
        this.textBoxScale.Size = new System.Drawing.Size(31, 22);
        this.textBoxScale.TabIndex = 19;
        this.textBoxScale.Text = "25";
        this.textBoxScale.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
        // 
        // trackBarScale
        // 
        this.trackBarScale.AutoSize = false;
        this.trackBarScale.Location = new System.Drawing.Point(21, 21);
        this.trackBarScale.Maximum = 40;
        this.trackBarScale.Minimum = 15;
        this.trackBarScale.Name = "trackBarScale";
        this.trackBarScale.Size = new System.Drawing.Size(162, 36);
        this.trackBarScale.TabIndex = 18;
        this.trackBarScale.TickStyle = System.Windows.Forms.TickStyle.None;
        this.trackBarScale.Value = 25;
        this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.matrix);
        this.groupBox1.Location = new System.Drawing.Point(3, 74);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(243, 134);
        this.groupBox1.TabIndex = 18;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Матрица";
        // 
        // matrix
        // 
        this.matrix.AllowUserToAddRows = false;
        this.matrix.AllowUserToDeleteRows = false;
        this.matrix.AllowUserToResizeColumns = false;
        this.matrix.AllowUserToResizeRows = false;
        this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.matrix.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.matrix.ColumnHeadersVisible = false;
        this.matrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
        this.matrix.GridColor = System.Drawing.SystemColors.ButtonFace;
        this.matrix.Location = new System.Drawing.Point(43, 21);
        this.matrix.Name = "matrix";
        this.matrix.RowHeadersVisible = false;
        this.matrix.RowHeadersWidth = 51;
        this.matrix.RowTemplate.Height = 24;
        this.matrix.Size = new System.Drawing.Size(164, 98);
        this.matrix.TabIndex = 1;
        this.matrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Invalidate);
        // 
        // Column1
        // 
        this.Column1.HeaderText = "1";
        this.Column1.MinimumWidth = 6;
        this.Column1.Name = "Column1";
        this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // Column2
        // 
        this.Column2.HeaderText = "2";
        this.Column2.MinimumWidth = 6;
        this.Column2.Name = "Column2";
        this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // Column3
        // 
        this.Column3.HeaderText = "3";
        this.Column3.MinimumWidth = 6;
        this.Column3.Name = "Column3";
        this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // timer1
        // 
        this.timer1.Interval = 1000000000;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.ClientSize = new System.Drawing.Size(1127, 700);
        this.Controls.Add(this.panel2D);
        this.Controls.Add(this.pictureBox1);
        this.Name = "Form1";
        this.Text = "Контрольная работа, задание 3";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.panel2D.ResumeLayout(false);
        this.panel2D.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
        this.groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel2D;
    private System.Windows.Forms.RadioButton radioButtonOwnCenter;
    private System.Windows.Forms.RadioButton radioButtonCenter;
    private System.Windows.Forms.RadioButton radioButtonPoint;
    private System.Windows.Forms.TextBox textBoxX0;
    private System.Windows.Forms.TextBox textBoxAngle;
    private System.Windows.Forms.TextBox textBoxY0;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView matrix;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBoxScale;
    private System.Windows.Forms.TrackBar trackBarScale;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.CheckBox checkBoxShowPoint;
    private System.Windows.Forms.Button colorPickerFig;
    private System.Windows.Forms.CheckBox checkBoxFigurePoints;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.ColorDialog colorDialogFigure;
    private System.Windows.Forms.CheckBox checkBoxAnimation;
    private System.Windows.Forms.Timer timer1;
}
}

