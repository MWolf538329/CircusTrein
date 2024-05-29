namespace CircusTrein
{
    partial class CircusTrein
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
            txt_Output = new TextBox();
            btn_LoadScenario1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cb_Size = new ComboBox();
            cb_FoodType = new ComboBox();
            btn_AddAnimal = new Button();
            btn_Calculate = new Button();
            label4 = new Label();
            lb_AnimalList = new ListBox();
            label5 = new Label();
            btn_ClearAnimalList = new Button();
            btn_LoadScenario2 = new Button();
            btn_LoadScenario3 = new Button();
            btn_LoadScenario4 = new Button();
            btn_LoadScenario5 = new Button();
            btn_LoadScenario6 = new Button();
            btn_LoadScenario7 = new Button();
            SuspendLayout();
            // 
            // txt_Output
            // 
            txt_Output.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Output.Location = new Point(630, 41);
            txt_Output.Multiline = true;
            txt_Output.Name = "txt_Output";
            txt_Output.ReadOnly = true;
            txt_Output.ScrollBars = ScrollBars.Vertical;
            txt_Output.Size = new Size(425, 380);
            txt_Output.TabIndex = 0;
            // 
            // btn_LoadScenario1
            // 
            btn_LoadScenario1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadScenario1.Location = new Point(12, 195);
            btn_LoadScenario1.Name = "btn_LoadScenario1";
            btn_LoadScenario1.Size = new Size(140, 36);
            btn_LoadScenario1.TabIndex = 1;
            btn_LoadScenario1.Text = "Load Scenario 1";
            btn_LoadScenario1.UseVisualStyleBackColor = true;
            btn_LoadScenario1.Click += btn_LoadScenario1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 2;
            label1.Text = "User Input:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 47);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 3;
            label2.Text = "Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 5;
            label3.Text = "FoodType:";
            // 
            // cb_Size
            // 
            cb_Size.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Size.FormattingEnabled = true;
            cb_Size.Location = new Point(105, 44);
            cb_Size.Name = "cb_Size";
            cb_Size.Size = new Size(193, 31);
            cb_Size.TabIndex = 6;
            // 
            // cb_FoodType
            // 
            cb_FoodType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_FoodType.FormattingEnabled = true;
            cb_FoodType.Location = new Point(105, 81);
            cb_FoodType.Name = "cb_FoodType";
            cb_FoodType.Size = new Size(193, 31);
            cb_FoodType.TabIndex = 7;
            // 
            // btn_AddAnimal
            // 
            btn_AddAnimal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddAnimal.Location = new Point(12, 118);
            btn_AddAnimal.Name = "btn_AddAnimal";
            btn_AddAnimal.Size = new Size(286, 32);
            btn_AddAnimal.TabIndex = 8;
            btn_AddAnimal.Text = "Add Animal";
            btn_AddAnimal.UseVisualStyleBackColor = true;
            btn_AddAnimal.Click += btn_AddAnimal_Click;
            // 
            // btn_Calculate
            // 
            btn_Calculate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Calculate.Location = new Point(487, 342);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(137, 79);
            btn_Calculate.TabIndex = 9;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = true;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 169);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 11;
            label4.Text = "Preset Scenario's:";
            // 
            // lb_AnimalList
            // 
            lb_AnimalList.FormattingEnabled = true;
            lb_AnimalList.ItemHeight = 20;
            lb_AnimalList.Location = new Point(344, 41);
            lb_AnimalList.Name = "lb_AnimalList";
            lb_AnimalList.Size = new Size(280, 284);
            lb_AnimalList.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(792, 15);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 13;
            label5.Text = "Result Output:";
            // 
            // btn_ClearAnimalList
            // 
            btn_ClearAnimalList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ClearAnimalList.Location = new Point(344, 342);
            btn_ClearAnimalList.Name = "btn_ClearAnimalList";
            btn_ClearAnimalList.Size = new Size(137, 79);
            btn_ClearAnimalList.TabIndex = 14;
            btn_ClearAnimalList.Text = "Clear Animal List";
            btn_ClearAnimalList.UseVisualStyleBackColor = true;
            btn_ClearAnimalList.Click += btn_ClearAnimalList_Click;
            // 
            // btn_LoadScenario2
            // 
            btn_LoadScenario2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadScenario2.Location = new Point(158, 195);
            btn_LoadScenario2.Name = "btn_LoadScenario2";
            btn_LoadScenario2.Size = new Size(140, 36);
            btn_LoadScenario2.TabIndex = 15;
            btn_LoadScenario2.Text = "Load Scenario 2";
            btn_LoadScenario2.UseVisualStyleBackColor = true;
            btn_LoadScenario2.Click += btn_LoadScenario2_Click;
            // 
            // btn_LoadScenario3
            // 
            btn_LoadScenario3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadScenario3.Location = new Point(12, 237);
            btn_LoadScenario3.Name = "btn_LoadScenario3";
            btn_LoadScenario3.Size = new Size(140, 36);
            btn_LoadScenario3.TabIndex = 16;
            btn_LoadScenario3.Text = "Load Scenario 3";
            btn_LoadScenario3.UseVisualStyleBackColor = true;
            btn_LoadScenario3.Click += btn_LoadScenario3_Click;
            // 
            // btn_LoadScenario4
            // 
            btn_LoadScenario4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadScenario4.Location = new Point(158, 237);
            btn_LoadScenario4.Name = "btn_LoadScenario4";
            btn_LoadScenario4.Size = new Size(140, 36);
            btn_LoadScenario4.TabIndex = 17;
            btn_LoadScenario4.Text = "Load Scenario 4";
            btn_LoadScenario4.UseVisualStyleBackColor = true;
            btn_LoadScenario4.Click += btn_LoadScenario4_Click;
            // 
            // btn_LoadScenario5
            // 
            btn_LoadScenario5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadScenario5.Location = new Point(12, 279);
            btn_LoadScenario5.Name = "btn_LoadScenario5";
            btn_LoadScenario5.Size = new Size(140, 36);
            btn_LoadScenario5.TabIndex = 18;
            btn_LoadScenario5.Text = "Load Scenario 5";
            btn_LoadScenario5.UseVisualStyleBackColor = true;
            btn_LoadScenario5.Click += btn_LoadScenario5_Click;
            // 
            // btn_LoadScenario6
            // 
            btn_LoadScenario6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadScenario6.Location = new Point(158, 279);
            btn_LoadScenario6.Name = "btn_LoadScenario6";
            btn_LoadScenario6.Size = new Size(140, 36);
            btn_LoadScenario6.TabIndex = 19;
            btn_LoadScenario6.Text = "Load Scenario 6";
            btn_LoadScenario6.UseVisualStyleBackColor = true;
            btn_LoadScenario6.Click += btn_LoadScenario6_Click;
            // 
            // btn_LoadScenario7
            // 
            btn_LoadScenario7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LoadScenario7.Location = new Point(12, 321);
            btn_LoadScenario7.Name = "btn_LoadScenario7";
            btn_LoadScenario7.Size = new Size(140, 36);
            btn_LoadScenario7.TabIndex = 20;
            btn_LoadScenario7.Text = "Load Scenario 7";
            btn_LoadScenario7.UseVisualStyleBackColor = true;
            btn_LoadScenario7.Click += btn_LoadScenario7_Click;
            // 
            // CircusTrein
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 433);
            Controls.Add(btn_LoadScenario7);
            Controls.Add(btn_LoadScenario6);
            Controls.Add(btn_LoadScenario5);
            Controls.Add(btn_LoadScenario4);
            Controls.Add(btn_LoadScenario3);
            Controls.Add(btn_LoadScenario2);
            Controls.Add(btn_ClearAnimalList);
            Controls.Add(label5);
            Controls.Add(lb_AnimalList);
            Controls.Add(label4);
            Controls.Add(btn_Calculate);
            Controls.Add(btn_AddAnimal);
            Controls.Add(cb_FoodType);
            Controls.Add(cb_Size);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_LoadScenario1);
            Controls.Add(txt_Output);
            Name = "CircusTrein";
            Text = "CircusTrein";
            Load += CircusTrein_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Output;
        private Button btn_LoadScenario1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_Size;
        private ComboBox cb_FoodType;
        private Button btn_AddAnimal;
        private Button btn_Calculate;
        private Label label4;
        private ListBox lb_AnimalList;
        private Label label5;
        private Button btn_ClearAnimalList;
        private Button btn_LoadScenario2;
        private Button btn_LoadScenario3;
        private Button btn_LoadScenario4;
        private Button btn_LoadScenario5;
        private Button btn_LoadScenario6;
        private Button btn_LoadScenario7;
    }
}