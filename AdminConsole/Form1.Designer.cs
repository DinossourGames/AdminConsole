namespace AdminConsole
{
    partial class Form1
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
            this.btnItem = new System.Windows.Forms.Button();
            this.btnPoolStart = new System.Windows.Forms.Button();
            this.btnPoolEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemDurability = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemAttack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemRange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemDefense = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemHealth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemLucky = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMoveSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbAddStatus = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pbServerStatus = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(86, 334);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(122, 38);
            this.btnItem.TabIndex = 0;
            this.btnItem.Text = "Novo Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // btnPoolStart
            // 
            this.btnPoolStart.Location = new System.Drawing.Point(360, 195);
            this.btnPoolStart.Name = "btnPoolStart";
            this.btnPoolStart.Size = new System.Drawing.Size(79, 42);
            this.btnPoolStart.TabIndex = 1;
            this.btnPoolStart.Text = "Criar Pool";
            this.btnPoolStart.UseVisualStyleBackColor = true;
            // 
            // btnPoolEnd
            // 
            this.btnPoolEnd.Location = new System.Drawing.Point(258, 195);
            this.btnPoolEnd.Name = "btnPoolEnd";
            this.btnPoolEnd.Size = new System.Drawing.Size(81, 42);
            this.btnPoolEnd.TabIndex = 2;
            this.btnPoolEnd.Text = "Encerrar Pool";
            this.btnPoolEnd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(86, 43);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(122, 20);
            this.txtItemName.TabIndex = 5;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(86, 69);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(122, 42);
            this.txtItemDesc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // txtItemDurability
            // 
            this.txtItemDurability.Location = new System.Drawing.Point(86, 117);
            this.txtItemDurability.Name = "txtItemDurability";
            this.txtItemDurability.Size = new System.Drawing.Size(122, 20);
            this.txtItemDurability.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Durabilidade";
            // 
            // txtItemAttack
            // 
            this.txtItemAttack.Location = new System.Drawing.Point(86, 169);
            this.txtItemAttack.Name = "txtItemAttack";
            this.txtItemAttack.Size = new System.Drawing.Size(122, 20);
            this.txtItemAttack.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ataque";
            // 
            // txtItemRange
            // 
            this.txtItemRange.Location = new System.Drawing.Point(86, 195);
            this.txtItemRange.Name = "txtItemRange";
            this.txtItemRange.Size = new System.Drawing.Size(122, 20);
            this.txtItemRange.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Range";
            // 
            // txtItemDefense
            // 
            this.txtItemDefense.Location = new System.Drawing.Point(86, 221);
            this.txtItemDefense.Name = "txtItemDefense";
            this.txtItemDefense.Size = new System.Drawing.Size(122, 20);
            this.txtItemDefense.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Defesa";
            // 
            // txtItemHealth
            // 
            this.txtItemHealth.Location = new System.Drawing.Point(86, 247);
            this.txtItemHealth.Name = "txtItemHealth";
            this.txtItemHealth.Size = new System.Drawing.Size(122, 20);
            this.txtItemHealth.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vida";
            // 
            // txtItemLucky
            // 
            this.txtItemLucky.Location = new System.Drawing.Point(86, 273);
            this.txtItemLucky.Name = "txtItemLucky";
            this.txtItemLucky.Size = new System.Drawing.Size(122, 20);
            this.txtItemLucky.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sorte";
            // 
            // txtMoveSpeed
            // 
            this.txtMoveSpeed.Location = new System.Drawing.Point(86, 299);
            this.txtMoveSpeed.Name = "txtMoveSpeed";
            this.txtMoveSpeed.Size = new System.Drawing.Size(122, 20);
            this.txtMoveSpeed.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Move Speed";
            // 
            // pbAddStatus
            // 
            this.pbAddStatus.Location = new System.Drawing.Point(25, 334);
            this.pbAddStatus.Name = "pbAddStatus";
            this.pbAddStatus.Size = new System.Drawing.Size(42, 38);
            this.pbAddStatus.TabIndex = 24;
            this.pbAddStatus.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(236, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 372);
            this.panel1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(269, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Item";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(328, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "Pool";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(269, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Item";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(269, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Item";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(269, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Item";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(376, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "10";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(376, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "10";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(376, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "10";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(376, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "10";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 58);
            this.button1.TabIndex = 35;
            this.button1.Text = "Encerrar Pool Com Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(341, 281);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(122, 20);
            this.textBox10.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(469, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 372);
            this.panel2.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(623, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 24);
            this.label21.TabIndex = 37;
            this.label21.Text = "Player";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(507, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = "Item";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(507, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 20);
            this.label23.TabIndex = 39;
            this.label23.Text = "Item";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(507, 102);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 20);
            this.label24.TabIndex = 40;
            this.label24.Text = "Item";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(507, 125);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 20);
            this.label25.TabIndex = 41;
            this.label25.Text = "Item";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(507, 147);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 20);
            this.label26.TabIndex = 42;
            this.label26.Text = "Item";
            // 
            // pbServerStatus
            // 
            this.pbServerStatus.BackColor = System.Drawing.Color.Silver;
            this.pbServerStatus.Location = new System.Drawing.Point(808, 363);
            this.pbServerStatus.Name = "pbServerStatus";
            this.pbServerStatus.Size = new System.Drawing.Size(16, 16);
            this.pbServerStatus.TabIndex = 43;
            this.pbServerStatus.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(721, 363);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 16);
            this.label27.TabIndex = 44;
            this.label27.Text = "Server Status";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemCost
            // 
            this.txtItemCost.Location = new System.Drawing.Point(86, 144);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.Size = new System.Drawing.Size(122, 20);
            this.txtItemCost.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemCost);
            this.Controls.Add(this.pbServerStatus);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbAddStatus);
            this.Controls.Add(this.txtMoveSpeed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtItemLucky);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtItemHealth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtItemDefense);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtItemRange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemAttack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemDurability);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPoolEnd);
            this.Controls.Add(this.btnPoolStart);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.label27);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnPoolStart;
        private System.Windows.Forms.Button btnPoolEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemDurability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemAttack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemDefense;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemHealth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemLucky;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMoveSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbAddStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pbServerStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.Label label5;
    }
}

