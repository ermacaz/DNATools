namespace DNATools
{
    partial class frmDigestPrimers
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
            this.txtBaseNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gcClampSize = new System.Windows.Forms.TextBox();
            this.cbxGC = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstLibrary = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNa = new System.Windows.Forms.TextBox();
            this.cbxSingleCut = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtREnzyme = new System.Windows.Forms.TextBox();
            this.txtFEnzyme = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRTemp = new System.Windows.Forms.TextBox();
            this.txtFTemp = new System.Windows.Forms.TextBox();
            this.txtRPrimer = new System.Windows.Forms.TextBox();
            this.txtFPrimer = new System.Windows.Forms.TextBox();
            this.rtxtSequence = new System.Windows.Forms.RichTextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstUserPicks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBaseNum
            // 
            this.txtBaseNum.Location = new System.Drawing.Point(218, 304);
            this.txtBaseNum.Name = "txtBaseNum";
            this.txtBaseNum.Size = new System.Drawing.Size(44, 20);
            this.txtBaseNum.TabIndex = 105;
            this.txtBaseNum.Text = "9";
            this.txtBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBaseNum.TextChanged += new System.EventHandler(this.txtBaseNum_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Bases used";
            // 
            // gcClampSize
            // 
            this.gcClampSize.Location = new System.Drawing.Point(98, 304);
            this.gcClampSize.Name = "gcClampSize";
            this.gcClampSize.Size = new System.Drawing.Size(36, 20);
            this.gcClampSize.TabIndex = 103;
            this.gcClampSize.Text = "3";
            this.gcClampSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gcClampSize.TextChanged += new System.EventHandler(this.gcClampSize_TextChanged);
            // 
            // cbxGC
            // 
            this.cbxGC.AutoSize = true;
            this.cbxGC.Checked = true;
            this.cbxGC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGC.Location = new System.Drawing.Point(29, 307);
            this.cbxGC.Name = "cbxGC";
            this.cbxGC.Size = new System.Drawing.Size(73, 17);
            this.cbxGC.TabIndex = 102;
            this.cbxGC.Text = "GC Clamp";
            this.cbxGC.UseVisualStyleBackColor = true;
            this.cbxGC.CheckedChanged += new System.EventHandler(this.cbxGC_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Multiple Cloning Region Cutsites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Enzyme Library";
            // 
            // lstLibrary
            // 
            this.lstLibrary.DisplayMember = "EcoRI";
            this.lstLibrary.FormattingEnabled = true;
            this.lstLibrary.Items.AddRange(new object[] {
            "AatII",
            "Acc65I",
            "AciI",
            "AclI",
            "AcuI",
            "AfeI",
            "AflII",
            "AgeI",
            "AgeI_HF",
            "AluI",
            "AlwI",
            "ApaI",
            "ApaLI",
            "AscI",
            "AseI",
            "AsiSI",
            "BaeGI",
            "BaeI",
            "BamHI",
            "BamHI_HF",
            "Bsbi",
            "BbvCI",
            "BbvI",
            "Bcci",
            "Bcci",
            "BciVI",
            "BclI",
            "BcoDI",
            "BfaI",
            "BfuAI",
            "BfuCI",
            "BglII",
            "BmgBI",
            "BmrI",
            "BmtI",
            "BmtI_HF",
            "BpmI",
            "BpuEI",
            "BsaI_HF",
            "BsaXI",
            "BseRI",
            "BseYI",
            "BsgI",
            "BsiHKAI",
            "BsiWI",
            "BsmAI",
            "BsmBI",
            "BsmFI",
            "BsmI",
            "BspCNI",
            "BspDI",
            "BspEI",
            "BspHI",
            "BspMI",
            "BspQI",
            "BsrBI",
            "BsrDI",
            "BsrGI",
            "BsrI",
            "BssHII",
            "BssSI",
            "BstBI",
            "BstNI",
            "BstUI",
            "BstZ171",
            "BtgI",
            "BtgZI",
            "BtsCI",
            "BtsI",
            "BtsIMutI",
            "ClaI",
            "CviAII",
            "CviQI",
            "DpnI",
            "DraI",
            "EagI",
            "EagI_HF",
            "EarI",
            "EciI",
            "Eco53kI",
            "EcoO109I",
            "EcoP151",
            "EcoRI",
            "EcoRI_HF",
            "EcoRV",
            "EcoRV_HF",
            "FatI",
            "FseI",
            "FspI",
            "HaeII",
            "HaeIII",
            "HhaI",
            "HindIII",
            "HindIII_HF",
            "HinfI",
            "HinP1I",
            "HpaI",
            "HpaII",
            "Hpy99I",
            "HpyCH4IV",
            "HpyCH4V",
            "KasI",
            "KpnI",
            "KpnI_HF",
            "MobI",
            "MfeI",
            "MfeI_HF",
            "MluCI",
            "MluI",
            "MscI",
            "MseI",
            "MslI",
            "NaeI",
            "NarI",
            "NcoI",
            "NcoI_HF",
            "NdeI",
            "NgoMIV",
            "NheI",
            "NheI_HF",
            "NlaIII",
            "NotI",
            "NotI_HF",
            "NruI",
            "NsiI",
            "Nt_AlwI",
            "PacI",
            "PaeR7I",
            "PciI",
            "PhoI",
            "PleI",
            "PluTI",
            "PmeI",
            "PmII",
            "PsiI",
            "PspOMI",
            "PsiI",
            "PsiI_HF",
            "PstI",
            "PvuI",
            "PvuI_HF",
            "PvuII",
            "PvuII_HF",
            "RsaI",
            "SacI",
            "SacI_HF",
            "SacII",
            "SalI",
            "SalI_HF",
            "SapI",
            "Sau3AI",
            "SbfI",
            "SbfI_HF",
            "ScaI",
            "ScaI_HF",
            "SfaNI",
            "SfoI",
            "SmaI",
            "SnaBI",
            "SpeI",
            "SpeI_HF",
            "SphI",
            "SphI_HF",
            "SspI_HF",
            "StuI",
            "SwaI",
            "TliI",
            "Tsp509I",
            "TspMI",
            "XbaI",
            "XhoI",
            "XmaI",
            "ZraI"});
            this.lstLibrary.Location = new System.Drawing.Point(29, 45);
            this.lstLibrary.Name = "lstLibrary";
            this.lstLibrary.Size = new System.Drawing.Size(105, 225);
            this.lstLibrary.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "[Na+] mM";
            // 
            // txtNa
            // 
            this.txtNa.Location = new System.Drawing.Point(218, 280);
            this.txtNa.Name = "txtNa";
            this.txtNa.Size = new System.Drawing.Size(44, 20);
            this.txtNa.TabIndex = 97;
            this.txtNa.Text = "50";
            this.txtNa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNa.TextChanged += new System.EventHandler(this.txtNa_TextChanged);
            // 
            // cbxSingleCut
            // 
            this.cbxSingleCut.AutoSize = true;
            this.cbxSingleCut.Location = new System.Drawing.Point(29, 280);
            this.cbxSingleCut.Name = "cbxSingleCut";
            this.cbxSingleCut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxSingleCut.Size = new System.Drawing.Size(99, 17);
            this.cbxSingleCut.TabIndex = 96;
            this.cbxSingleCut.Text = "Filter single cut ";
            this.cbxSingleCut.UseVisualStyleBackColor = true;
            this.cbxSingleCut.CheckedChanged += new System.EventHandler(this.cbxSingleCut_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "3\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "5\'";
            // 
            // txtREnzyme
            // 
            this.txtREnzyme.Location = new System.Drawing.Point(470, 277);
            this.txtREnzyme.Name = "txtREnzyme";
            this.txtREnzyme.ReadOnly = true;
            this.txtREnzyme.Size = new System.Drawing.Size(56, 20);
            this.txtREnzyme.TabIndex = 93;
            // 
            // txtFEnzyme
            // 
            this.txtFEnzyme.Location = new System.Drawing.Point(470, 240);
            this.txtFEnzyme.Name = "txtFEnzyme";
            this.txtFEnzyme.ReadOnly = true;
            this.txtFEnzyme.Size = new System.Drawing.Size(56, 20);
            this.txtFEnzyme.TabIndex = 92;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(728, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 91;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Reverse Primer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Forward Primer";
            // 
            // txtRTemp
            // 
            this.txtRTemp.Location = new System.Drawing.Point(770, 277);
            this.txtRTemp.Name = "txtRTemp";
            this.txtRTemp.ReadOnly = true;
            this.txtRTemp.Size = new System.Drawing.Size(56, 20);
            this.txtRTemp.TabIndex = 88;
            // 
            // txtFTemp
            // 
            this.txtFTemp.Location = new System.Drawing.Point(770, 240);
            this.txtFTemp.Name = "txtFTemp";
            this.txtFTemp.ReadOnly = true;
            this.txtFTemp.Size = new System.Drawing.Size(56, 20);
            this.txtFTemp.TabIndex = 87;
            // 
            // txtRPrimer
            // 
            this.txtRPrimer.Location = new System.Drawing.Point(544, 277);
            this.txtRPrimer.Name = "txtRPrimer";
            this.txtRPrimer.ReadOnly = true;
            this.txtRPrimer.Size = new System.Drawing.Size(211, 20);
            this.txtRPrimer.TabIndex = 86;
            // 
            // txtFPrimer
            // 
            this.txtFPrimer.Location = new System.Drawing.Point(544, 240);
            this.txtFPrimer.Name = "txtFPrimer";
            this.txtFPrimer.ReadOnly = true;
            this.txtFPrimer.Size = new System.Drawing.Size(211, 20);
            this.txtFPrimer.TabIndex = 85;
            // 
            // rtxtSequence
            // 
            this.rtxtSequence.Location = new System.Drawing.Point(411, 30);
            this.rtxtSequence.Name = "rtxtSequence";
            this.rtxtSequence.Size = new System.Drawing.Size(392, 186);
            this.rtxtSequence.TabIndex = 84;
            this.rtxtSequence.Text = "Enter Sequence Here";
            this.rtxtSequence.TextChanged += new System.EventHandler(this.rtxtSequence_TextChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(149, 127);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 83;
            this.btnUp.Text = "Move Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(149, 184);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 82;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(149, 156);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 81;
            this.btnDown.Text = "Move Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstUserPicks
            // 
            this.lstUserPicks.FormattingEnabled = true;
            this.lstUserPicks.Location = new System.Drawing.Point(233, 45);
            this.lstUserPicks.Name = "lstUserPicks";
            this.lstUserPicks.Size = new System.Drawing.Size(114, 225);
            this.lstUserPicks.TabIndex = 79;
            // 
            // frmDigestPrimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 358);
            this.Controls.Add(this.txtBaseNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gcClampSize);
            this.Controls.Add(this.cbxGC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstLibrary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNa);
            this.Controls.Add(this.cbxSingleCut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtREnzyme);
            this.Controls.Add(this.txtFEnzyme);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRTemp);
            this.Controls.Add(this.txtFTemp);
            this.Controls.Add(this.txtRPrimer);
            this.Controls.Add(this.txtFPrimer);
            this.Controls.Add(this.rtxtSequence);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstUserPicks);
            this.Name = "frmDigestPrimers";
            this.Text = "Digets Primers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaseNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gcClampSize;
        private System.Windows.Forms.CheckBox cbxGC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstLibrary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNa;
        private System.Windows.Forms.CheckBox cbxSingleCut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtREnzyme;
        private System.Windows.Forms.TextBox txtFEnzyme;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRTemp;
        private System.Windows.Forms.TextBox txtFTemp;
        private System.Windows.Forms.TextBox txtRPrimer;
        private System.Windows.Forms.TextBox txtFPrimer;
        private System.Windows.Forms.RichTextBox rtxtSequence;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstUserPicks;

    }
}

